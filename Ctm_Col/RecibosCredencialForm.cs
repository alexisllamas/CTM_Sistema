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

namespace Ctm_Col
{
    public partial class RecibosCredencialForm : MaterialForm
    {
        private Chofer _chofer;
        private ReciboCredencial _recibo;
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
        public RecibosCredencialForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);

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
        }

        private void modoVer()
        {
            llenarTabla();
            cargarDatos();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
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

        private void llenarTabla()
        {
            lvRecibos.Items.Clear();
            using (var db = new Db())
            {
                var recibos = db.RecibosCredencial.Where(x => x.Chofer.Id == Chofer.Id).OrderByDescending(x => x.Fecha);
                foreach (var recibo in recibos)
                {
                    var lvi = new ListViewItem(recibo.Id.ToString());
                    lvi.SubItems.Add(recibo.Fecha.ToShortDateString());
                    lvi.SubItems.Add(String.Format("{0:c}", recibo.Cantidad));

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
                    DialogResult boton = MessageBox.Show("¿Quieres eliminar este recibo " + Recibo.Id + "?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
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
                Recibo = recibo;
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
    }
}
