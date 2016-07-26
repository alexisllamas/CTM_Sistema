using Ctm_Col.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctm_Col
{
    public partial class ChoferControl : UserControl
    {
        private string search = "";
        private Models.Chofer _chofer;
        private bool isModoVer;

        private Chofer Chofer
        {
            get
            {
                return _chofer;
            }

            set
            {
                _chofer = value;
                if(_chofer != null)
                {
                    modoVer();
                } else
                {
                    modoNuevo();
                }
            }
        }
        public ChoferControl()
        {
            InitializeComponent();

            using (var db = new Db())
            {
                var choferes = db.Choferes.OrderBy(c => c.ApellidoPaterno).ThenBy(c => c.ApellidoMaterno).ThenBy(c => c.Nombres);
                cargarDatos(choferes);

                if (choferes.Any())
                    Chofer = choferes.First();
                else
                    modoNuevo();
            }
        }

        private void cargarDatos(IOrderedQueryable<Models.Chofer> choferes)
        {
            lvChoferes.Items.Clear();
            var choferesFil = choferes.Where(u => u.Id.ToString().StartsWith(search) ||
               u.Nombres.StartsWith(search) ||
               u.ApellidoPaterno.StartsWith(search) ||
               u.ApellidoMaterno.StartsWith(search) ||
               u.Telefono.StartsWith(search) ||
               u.Municipio.StartsWith(search));

            foreach (var chofer in choferesFil)
            {
                var lvi = new ListViewItem(chofer.Id.ToString());
                lvi.SubItems.Add(chofer.Nombres);
                lvi.SubItems.Add(chofer.ApellidoPaterno);
                lvi.SubItems.Add(chofer.ApellidoMaterno);
                lvi.SubItems.Add(chofer.Municipio);
                lvi.SubItems.Add(chofer.Telefono);
                lvi.SubItems.Add(chofer.Licencia);

                lvChoferes.Items.Add(lvi);
            }
        }
        private void llenarDatos()
        {
            if (Chofer != null)
            {
                txtConId.Text = Chofer.Id.ToString();
                txtNombre.Text = Chofer.Nombres;
                txtApPaterno.Text = Chofer.ApellidoPaterno;
                txtApMaterno.Text = Chofer.ApellidoMaterno;
                txtConCalle.Text = Chofer.Domicilio;
                txtConColonia.Text = Chofer.Colonia;
                dtConNacimiento.Value = Chofer.FechaNacimiento;
                cmbConMunicipio.SelectedItem = Chofer.Municipio;
                txtConTelefono.Text = Chofer.Telefono;
                txtLicencia.Text = Chofer.Licencia;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                modoNuevo();
            }
            else
            {
                var chofer = new Models.Chofer
                {
                    Nombres = txtNombre.Text.Trim(),
                    ApellidoPaterno = txtApPaterno.Text.Trim(),
                    ApellidoMaterno = txtApMaterno.Text.Trim(),
                    Domicilio = txtConCalle.Text.Trim(),
                    Colonia = txtConColonia.Text.Trim(),
                    FechaNacimiento = dtConNacimiento.Value,
                    Municipio = (string)cmbConMunicipio.SelectedItem,
                    Telefono = txtConTelefono.Text.Trim(),
                    Licencia = txtLicencia.Text.Trim()
                };

                using (var db = new Db())
                {

                    db.Choferes.Add(chofer);
                    db.SaveChanges();

                    Chofer = db.Choferes.Where(u => u.Telefono == chofer.Telefono).First();
                    cargarDatos(db.Choferes.OrderBy(c => c.ApellidoPaterno).ThenBy(c => c.ApellidoMaterno).ThenBy(c => c.Nombres));
                }

                modoVer();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Chofer != null)
            {
                using (var db = new Db())
                {
                    var chofer = db.Choferes.Where(u => u.Id == Chofer.Id).First();

                    chofer.Nombres = txtNombre.Text.Trim();
                    chofer.ApellidoPaterno = txtApPaterno.Text.Trim();
                    chofer.ApellidoMaterno = txtApMaterno.Text.Trim();
                    chofer.Colonia = txtConColonia.Text.Trim();
                    chofer.Domicilio = txtConCalle.Text.Trim();
                    chofer.FechaNacimiento = dtConNacimiento.Value;
                    chofer.Municipio = (string)cmbConMunicipio.SelectedItem;
                    chofer.Telefono = txtConTelefono.Text.Trim();

                    db.SaveChanges();

                    Chofer = chofer;

                    cargarDatos(db.Choferes.OrderBy(x => x.ApellidoPaterno).ThenBy(x => x.ApellidoMaterno).ThenBy(x => x.Nombres));
                }

                DialogResult boton = MessageBox.Show("Concesionario modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Chofer != null)
            {
                using (var db = new Db())
                {
                    var chofer = db.Choferes.Where(u => u.Id == Chofer.Id).First();
                    DialogResult boton = MessageBox.Show(string.Format("¿Quieres eliminar a {0} {1}?", 
                                                             chofer.Nombres, 
                                                             chofer.ApellidoPaterno), "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                    if (boton == DialogResult.Yes)
                    {
                        if (chofer.RecibosCredencial.Any())
                        {
                            foreach (var recibos in db.RecibosCredencial.Where((System.Linq.Expressions.Expression<Func<ReciboCredencial, bool>>)(x => x.Chofer.Id == Chofer.Id)))
                            {
                                db.RecibosCredencial.Remove(recibos);
                            }
                        }

                        db.Choferes.Remove(chofer);
                        db.SaveChanges();

                        var choferes = db.Choferes.OrderBy(x => x.ApellidoPaterno).ThenBy(x => x.ApellidoMaterno).ThenBy(x => x.Nombres);
                        if (choferes.Any())
                            Chofer = choferes.First();
                        else
                            Chofer = null;
                        cargarDatos(choferes);
                    }
                }
            }
        }

        private void lvChoferes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            using (var db = new Db())
            {
                switch (e.Column)
                {
                    case 0:
                        cargarDatos(db.Choferes.OrderBy(x => x.Id));
                        break;
                    case 1:
                        cargarDatos(db.Choferes.OrderBy(x => x.Nombres));
                        break;
                    case 2:
                        cargarDatos(db.Choferes.OrderBy(x => x.ApellidoPaterno));
                        break;
                    case 3:
                        cargarDatos(db.Choferes.OrderBy(x => x.ApellidoMaterno));
                        break;
                    case 4:
                        cargarDatos(db.Choferes.OrderBy(x => x.Municipio));
                        break;
                    case 5:
                        cargarDatos(db.Choferes.OrderBy(x => x.Telefono));
                        break;
                }
            }
        }

        private void lvChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChoferes.SelectedIndices.Count == 0) return;

            int id = Int32.Parse(lvChoferes.SelectedItems[0].SubItems[0].Text);

            using (var db = new Db())
            {
                var chofer = db.Choferes.Where(u => u.Id == id).First();
                Chofer = chofer;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            search = txtBuscar.Text.Trim();
            using (var db = new Db())
            {
                var choferes = db.Choferes.OrderBy(x => x.ApellidoPaterno).ThenBy(x => x.ApellidoMaterno).ThenBy(x => x.Nombres);
                cargarDatos(choferes);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            using(var db = new Db())
            {
                if (db.Choferes.Any())
                    modoVer();
            }
        }

        private void modoNuevo()
        {
            txtConId.Text = "";
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtConCalle.Text = "";
            txtConColonia.Text = "";
            dtConNacimiento.Value = new DateTime(1980, 1, 1);
            txtConTelefono.Text = "";
            cmbConMunicipio.SelectedIndex = -1;
            txtLicencia.Text = "";
            ActiveControl = txtNombre;

            btnNuevo.Text = "Guardar";
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            isModoVer = false;
        }

        private void modoVer()
        {

            llenarDatos();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Text = "Nuevo";
            isModoVer = true;

            ActiveControl = lvChoferes;
        }

        private void btnReciboCredencial_Click(object sender, EventArgs e)
        {
            if (isModoVer)
            {
                var reciboForm = new ReciboCredencialForm(Chofer);
                reciboForm.ShowDialog();
                return;
            }
            MessageBox.Show("Selecciona un Chofer primero", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCredencial_Click(object sender, EventArgs e)
        {
            if (!isModoVer)
            {
                MessageBox.Show("Selecciona un Chofer primero", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var recibosForm = new RecibosCredencialControl();
                using (var db = new Db())
                {
                    var chofer = db.Choferes.Where(x => x.Id == Chofer.Id).First();
                    if (chofer.Credencial == null)
                    {
                        DialogResult button = MessageBox.Show("Sin credencial, ¿Tramitar Credencial?", "Hola", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (button == DialogResult.Yes)
                        {
                            chofer.Credencial = new Credencial
                            {
                                FechaInicioVigencia = DateTime.Today,
                                FechaFinalVigencia = DateTime.Today.AddYears(1)
                            };
                            db.SaveChanges();
                            var recibo = new ReciboCredencial
                            {
                                Fecha = DateTime.Today,
                                Cantidad = 200
                            };
                            chofer.RecibosCredencial.Add(recibo);
                            db.SaveChanges();
                            DialogResult reciboImprimir = MessageBox.Show("¿Imprimir recibo?", "Hola", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (reciboImprimir == DialogResult.Yes)
                            {

                            }
                            var credencialForm = new CredencialForm(Chofer);
                            credencialForm.ShowDialog();
                        }
                    }
                    else
                    {
                        var credencialForm = new CredencialForm(Chofer);

                        credencialForm.Show();
                    }
                }
            }
        }

        private void btnReciboDeducible_Click(object sender, EventArgs e)
        {
            if (isModoVer)
            {
                var recibosForm = new ReciboDeducibleForm(Chofer);
                recibosForm.ShowDialog();
                return;
            }
            MessageBox.Show("Selecciona un Chofer primero", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void lvChoferes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnEliminar_Click(null, null);
            }
        }
    }
}
