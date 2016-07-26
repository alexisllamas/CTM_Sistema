using Ctm_Col.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctm_Col
{
    public partial class RecibosPolizaControl : UserControl
    {
        private Models.Concesionario _concesionario;
        private ReciboPoliza _recibo;
        private string search = "";

        public Concesionario Concesionario
        {
            get
            {
                return _concesionario;
            }

            set
            {
                _concesionario = value;
                using (var db = new Db())
                {
                    if (_concesionario != null)
                    {
                        if (db.RecibosPoliza.Where(x => x.Concesionario.Id == _concesionario.Id).Any())
                        {
                            Recibo = (db.RecibosPoliza.Where(x => x.Concesionario.Id == _concesionario.Id).OrderByDescending(x => x.Fecha).First());
                            modoVer();
                            cargarDatos();
                        }
                        else
                        {
                            modoNuevo();
                            llenarTabla();
                        }
                    } 
                }
            }
        }

        public ReciboPoliza Recibo
        {
            get
            {
                return _recibo;
            }

            set
            {
                _recibo = value;
                if(_recibo != null)
                {
                    modoVer();
                    cargarDatos();
                }
            }
        }

        public RecibosPolizaControl()
        {
            InitializeComponent();

            if(Concesionario == null)
            {
                llenarTabla();
                btnActualizar.Enabled = false;
                btnDescartar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = false;
                dtpFecha.Enabled = false;
                txtCantidad.Enabled = false;
            }

            dtpFechaFin.MinDate = dtpFechaIni.Value;

            using (var db = new Db())
            {
                var sitios = db.Taxis.Select(x => x.Sitio).Distinct();

                foreach (var sitio in sitios)
                {
                    cmbSitios.Items.Add(sitio);
                }
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (btnNuevo.Text == "Nuevo")
            {
                modoNuevo();
            }
            else if (btnNuevo.Text == "Guardar")
            {
                using (var db = new Db())
                {
                    var recibo = new ReciboPoliza
                    {
                        Fecha = dtpFecha.Value,
                        Cantidad = (Double)txtCantidad.Value,
                        Concesionario = db.Concesionarios.Where(x => x.Id == Concesionario.Id).First()

                    };

                
                    db.RecibosPoliza.Add(recibo);
                    Recibo = recibo;
                    db.SaveChanges();
                }

                modoVer();
                
            }
        }

        private void modoNuevo()
        {
            txtId.Text = "";
            txtCantidad.Value = 0;
            dtpFecha.Value = DateTime.Today;

            btnNuevo.Text = "Guardar";
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            btnDescartar.Enabled = true;
            btnNuevo.Enabled = true;
            dtpFecha.Enabled = true;
            txtCantidad.Enabled = true;
        }

        private void modoVer()
        {
            llenarTabla();
            cargarDatos();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Text = "Nuevo";

            btnDescartar.Enabled = true;
            btnNuevo.Enabled = true;
            dtpFecha.Enabled = true;
            txtCantidad.Enabled = true;


        }

        private void cargarDatos()
        {
            if (Recibo != null)
            {
                txtId.Text = Recibo.Id.ToString();
                dtpFecha.Value = Recibo.Fecha;
                txtCantidad.Value = (decimal)Recibo.Cantidad;
                txtApPaterno.Text = Recibo.Concesionario.ApellidoPaterno;
                txtNombre.Text = Recibo.Concesionario.Nombres;
                txtApMaterno.Text = Recibo.Concesionario.ApellidoMaterno;
            }   
        }

        public void llenarTabla()
        {
            lvRecibos.Items.Clear();
            using (var db = new Db())
            {
                IQueryable<ReciboPoliza> recibos;
                if (Concesionario != null)
                    recibos = db.RecibosPoliza.Where(x => x.Concesionario.Id == Concesionario.Id).OrderByDescending(x => x.Fecha);
                else
                    recibos = db.RecibosPoliza.OrderByDescending(x=>x.Fecha);

                if (chckFecha.Checked)
                    recibos = recibos.Where(x => DbFunctions.TruncateTime(x.Fecha) >= DbFunctions.TruncateTime(dtpFechaIni.Value)
                        && DbFunctions.TruncateTime(x.Fecha) <= DbFunctions.TruncateTime(dtpFechaFin.Value));

                if (chckSitio.Checked)
                    recibos = recibos.Where(x => x.Concesionario.Taxi.Sitio == (string)cmbSitios.SelectedItem);

                recibos = recibos.Where(x => x.Id.ToString().StartsWith(search) ||
                    //x.Concesionario.Nombres.Contains(search) ||
                    //x.Concesionario.ApellidoPaterno.StartsWith(search) ||
                    //x.Concesionario.ApellidoMaterno.StartsWith(search) ||
                    x.Concesionario.Taxi.NumeroEconomico.StartsWith(search) ||
                    x.Concesionario.Taxi.Sitio.StartsWith(search)); 

                foreach (var recibo in recibos)
                {
                    var lvi = new ListViewItem(recibo.Id.ToString());
                    lvi.SubItems.Add(recibo.Fecha.ToShortDateString());
                    lvi.SubItems.Add(String.Format("{0:c}", recibo.Cantidad));
                    lvi.SubItems.Add(recibo.Concesionario.Taxi.NumeroEconomico);
                    lvi.SubItems.Add(recibo.Concesionario.Taxi.Sitio);

                    lvRecibos.Items.Add(lvi);
                }
            }
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Recibo != null)
            {
                using(var db = new Db())
                {
                    var recibo = db.RecibosPoliza.Where(x => x.Id == Recibo.Id).First();

                    recibo.Cantidad = (double)txtCantidad.Value;
                    recibo.Fecha = dtpFecha.Value;

                    db.SaveChanges();

                    llenarTabla();
                }
                DialogResult boton = MessageBox.Show("Recibo modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Recibo != null)
            {
                using (var db = new Db())
                {
                    DialogResult boton = MessageBox.Show(string.Format("¿Quieres eliminar este recibo {0}?", Recibo.Id), "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                    if (boton == DialogResult.Yes)
                    {
                        var recibo = db.RecibosPoliza.Where(x => x.Id == Recibo.Id).First();
                        db.RecibosPoliza.Remove(recibo);
                        db.SaveChanges();

                        if (db.RecibosPoliza.Where(x => x.Concesionario.Id == _concesionario.Id).Any())
                            Recibo = (db.RecibosPoliza.Where(x => x.Concesionario.Id == _concesionario.Id).First());
                        else
                        {
                            modoNuevo();
                            llenarTabla();
                        }
                    }
                }
            }

        }

        private void lvRecibos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRecibos.SelectedIndices.Count == 0) return;

            var id = Int32.Parse(lvRecibos.SelectedItems[0].SubItems[0].Text);
            using(var db = new Db())
            {
                var recibo = db.RecibosPoliza.Where(x => x.Id == id).First();
                _recibo = recibo;
                cargarDatos();
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            using (var db = new Db())
            {
                if (db.RecibosPoliza.Where(x=>x.Concesionario.Id == Concesionario.Id).Any())
                    modoVer();
            }
        }

        private void chckSitio_CheckedChanged(object sender, EventArgs e)
        {
            filtrarSitio();
        }
        private void cmbSitios_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarSitio();
        }

        private void chckFecha_CheckedChanged(object sender, EventArgs e)
        {
            filtrarFecha();
        }

        private void dtpFechaIni_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaFin.MinDate = dtpFechaIni.Value;
            filtrarFecha();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            filtrarFecha();
        }

        private void filtrarSitio()
        {
            if (cmbSitios.SelectedIndex < 0) return;

            llenarTabla();
        }

        private void filtrarFecha()
        {
            llenarTabla();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            search = txtBuscar.Text;
            llenarTabla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using(var db = new Db())
            {
                var conce = db.Concesionarios.Where(x => x.Id == _recibo.Concesionario.Id).First();
                Imprimir.ReciboPoliza(_recibo, conce.Taxi);
            }
            
        }

        private void lvRecibos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnEliminar_Click(null, null);
            }
        }
    }
}
