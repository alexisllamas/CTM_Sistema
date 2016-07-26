using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ctm_Col.Models;
using System.Data.Entity;

namespace Ctm_Col
{
    public partial class RecibosCredencialControl : UserControl
    {
        private Models.Chofer _chofer;
        private ReciboCredencial _recibo;
        private bool porFecha = false;
        private string search = "";
        public Chofer Chofer
        {
            get
            {
                return _chofer;
            }

            set
            {
                _chofer = value;
                using (var db = new Db())
                {
                    if (_chofer != null)
                    {
                        if (db.RecibosCredencial.Where(x => x.Chofer.Id == _chofer.Id).Any())
                        {
                            Recibo = (db.RecibosCredencial.Where(x => x.Chofer.Id == _chofer.Id).OrderByDescending(x => x.Fecha).First());

                            modoVer();
                            cargarDatos();
                        } else
                        {
                            modoNuevo();
                            llenarTabla();
                        }
                    }
                }
            }
        }
        public ReciboCredencial Recibo
        {
            get
            {
                return _recibo;
            }

            set
            {
                _recibo = value;
                if (_recibo != null)
                {
                    modoVer();
                    cargarDatos();
                }
            }
        }
        public RecibosCredencialControl()
        {
            InitializeComponent();
            if (Chofer == null)
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
                    var recibo = new ReciboCredencial
                    {
                        Fecha = dtpFecha.Value,
                        Cantidad = (Double)txtCantidad.Value,
                        Chofer = db.Choferes.Where(x => x.Id == Chofer.Id).First()
                    };


                    db.RecibosCredencial.Add(recibo);
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

            btnDescartar.Enabled = true;
            btnNuevo.Enabled = true;
            dtpFecha.Enabled = true;
            txtCantidad.Enabled = true;

            btnNuevo.Text = "Nuevo";
        }

        private void cargarDatos()
        {
            if (Recibo != null)
            {
                txtId.Text = Recibo.Id.ToString();
                dtpFecha.Value = Recibo.Fecha;
                txtCantidad.Value = (decimal)Recibo.Cantidad;
                txtApPaterno.Text = Recibo.Chofer.ApellidoPaterno;
                txtNombre.Text = Recibo.Chofer.Nombres;
                txtApMaterno.Text = Recibo.Chofer.ApellidoMaterno;
            }
        }

        public void llenarTabla()
        {
            lvRecibos.Items.Clear();
            using (var db = new Db())
            {
                IQueryable<ReciboCredencial> recibos;
                if (Chofer != null)
                    recibos = db.RecibosCredencial.Where(x => x.Chofer.Id == Chofer.Id).OrderByDescending(x => x.Fecha);
                else
                    recibos = db.RecibosCredencial.OrderByDescending(x=>x.Fecha);

                if (porFecha)
                    recibos = recibos.Where(x => DbFunctions.TruncateTime(x.Fecha) >= DbFunctions.TruncateTime(dtpFechaIni.Value)
                        && DbFunctions.TruncateTime(x.Fecha) <= DbFunctions.TruncateTime(dtpFechaFin.Value));

                recibos = recibos.Where(x => x.Id.ToString().StartsWith(search) ||
                    x.Chofer.Nombres.Contains(search) ||
                    x.Chofer.ApellidoPaterno.StartsWith(search) ||
                    x.Chofer.ApellidoMaterno.StartsWith(search));

                foreach (var recibo in recibos)
                {
                    var lvi = new ListViewItem(recibo.Id.ToString());
                    lvi.SubItems.Add(recibo.Fecha.ToShortDateString());
                    lvi.SubItems.Add(String.Format("{0:c}", recibo.Cantidad));
                    lvi.SubItems.Add(recibo.Chofer.Nombres);
                    lvi.SubItems.Add(recibo.Chofer.ApellidoPaterno);
                    lvi.SubItems.Add(recibo.Chofer.ApellidoMaterno);

                    lvRecibos.Items.Add(lvi);
                }
            }
        }

        private void llenarTabla(IQueryable<ReciboCredencial> recibos)
        {
            lvRecibos.Items.Clear();
            using (var db = new Db())
            {
                if (Chofer != null)
                    recibos = recibos.Where(x => x.Chofer.Id == Chofer.Id).OrderByDescending(x => x.Fecha);
                else
                    recibos = recibos.OrderBy(x => x.Fecha);

                foreach (var recibo in recibos)
                {
                    var lvi = new ListViewItem(recibo.Id.ToString());
                    lvi.SubItems.Add(recibo.Fecha.ToShortDateString());
                    lvi.SubItems.Add(String.Format("{0:c}", recibo.Cantidad));
                    lvi.SubItems.Add(recibo.Chofer.Nombres);
                    lvi.SubItems.Add(recibo.Chofer.ApellidoPaterno);
                    lvi.SubItems.Add(recibo.Chofer.ApellidoMaterno);

                    lvRecibos.Items.Add(lvi);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Recibo != null)
            {
                using (var db = new Db())
                {
                    var recibo = db.RecibosCredencial.Where(x => x.Id == Recibo.Id).First();

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
                        var recibo = db.RecibosCredencial.Where(x => x.Id == Recibo.Id).First();
                        db.RecibosCredencial.Remove(recibo);
                        db.SaveChanges();

                        if (db.RecibosCredencial.Where(x => x.Chofer.Id == Chofer.Id).Any())
                            Recibo = db.RecibosCredencial.Where(x => x.Chofer.Id == Chofer.Id).First();
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
            using (var db = new Db())
            {
                var recibo = db.RecibosCredencial.Where(x => x.Id == id).First();
                _recibo = recibo;
                cargarDatos();
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            using (var db = new Db())
            {
                if (db.RecibosCredencial.Where(x=>x.Chofer.Id == Chofer.Id).Any())
                    modoVer();
            }
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

        private void filtrarFecha()
        {
            porFecha = chckFecha.Checked;

            llenarTabla();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            search = txtBuscar.Text;
            llenarTabla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ReciboCredencial(_recibo);
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
