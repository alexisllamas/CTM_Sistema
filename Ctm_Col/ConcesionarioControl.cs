using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ctm_Col.Models;
using System.Data.Entity;
using MaterialSkin.Controls;
using MaterialSkin;
using DevExpress.XtraEditors;

namespace Ctm_Col
{
    public partial class ConcesionarioControl : UserControl
    {
        private string search = "";
        private Models.Concesionario _concesionario;
        private bool isModoVer;
        private int sort = -1;

        private Concesionario Concesionario
        {
            get
            {
                return _concesionario;
            }

            set
            {
                _concesionario = value;
                if (_concesionario != null)
                {
                    modoVer();
                } else
                {
                    modoNuevo();
                }
                
            }
        }
        public ConcesionarioControl()
        {
            InitializeComponent();

            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);

            using (var db = new Db())
            {
                var concesionarios = db.Concesionarios.OrderBy(c => c.ApellidoPaterno).ThenBy(c => c.ApellidoMaterno).ThenBy(c => c.Nombres);

                if (concesionarios.Any())
                    Concesionario = concesionarios.First();
                else
                    modoNuevo();

                var sitios = db.Taxis.Select(x => x.Sitio).Distinct();

                foreach (var sitio in sitios)
                {
                    cmbSitios.Items.Add(sitio);
                }
            }
            cargarDatos();
        }

        private void cargarDatos()
        {
            lvConcesionarios.Items.Clear();
            Console.WriteLine(chckSitio.Checked);
            using (var db = new Db())
            {
                var concesionarios = db.Concesionarios.Where(u => u.Id.ToString().StartsWith(search) ||
                   u.Nombres.Contains(search) ||
                   u.ApellidoPaterno.StartsWith(search) ||
                   u.ApellidoMaterno.StartsWith(search) ||
                   u.Telefono.StartsWith(search) ||
                   u.Municipio.StartsWith(search) ||
                   u.Taxi.NumeroEconomico.Equals(search) ||
                   u.Taxi.Sitio.StartsWith(search));

                if (chckSitio.Checked)
                    concesionarios = concesionarios.Where(x => x.Taxi.Sitio == (string)cmbSitios.SelectedItem);

                switch (sort)
                {
                    case 0:
                        concesionarios = concesionarios.OrderBy(x => x.Id);
                        break;
                    case 1:
                        concesionarios = concesionarios.OrderBy(x => x.Nombres);
                        break;
                    case 2:
                        concesionarios = concesionarios.OrderBy(x => x.ApellidoPaterno);
                        break;
                    case 3:
                        concesionarios = concesionarios.OrderBy(x => x.ApellidoMaterno);
                        break;
                    case 4:
                        concesionarios = concesionarios.OrderBy(x => x.Municipio);
                        break;
                    case 5:
                        concesionarios = concesionarios.OrderBy(x => x.Telefono);
                        break;
                    case 6:
                        concesionarios = concesionarios.OrderBy(x =>x.Taxi.NumeroEconomico);
                        break;
                    case 7:
                        concesionarios = concesionarios.OrderBy(x => x.Taxi.Sitio);
                        break;
                    case 8:
                        concesionarios = concesionarios.OrderBy(x => x.Cargo);
                        break;
                    default:
                        concesionarios = concesionarios.OrderBy(x => x.ApellidoPaterno).ThenBy(x => x.ApellidoMaterno).ThenBy(x => x.Nombres);
                        break;

                }
                foreach (var con in concesionarios)
                {
                    var lvi = new ListViewItem(con.Id.ToString());
                    lvi.SubItems.Add(con.Nombres);
                    lvi.SubItems.Add(con.ApellidoPaterno);
                    lvi.SubItems.Add(con.ApellidoMaterno);
                    lvi.SubItems.Add(con.Municipio);
                    lvi.SubItems.Add(con.Telefono);
                    if (con.Taxi != null)
                    {
                        lvi.SubItems.Add(con.Taxi.NumeroEconomico);
                        lvi.SubItems.Add(con.Taxi.Sitio);
                    }
                    lvi.SubItems.Add(con.Cargo);

                    lvConcesionarios.Items.Add(lvi);
                }
            }
        }

        

        private void llenarDatos()
        {
            if (Concesionario != null)
            {
                txtConId.Text = Concesionario.Id.ToString();
                txtNombre.Text = Concesionario.Nombres;
                txtApPaterno.Text = Concesionario.ApellidoPaterno;
                txtApMaterno.Text = Concesionario.ApellidoMaterno;
                txtConCalle.Text = Concesionario.Domicilio;
                txtConColonia.Text = Concesionario.Colonia;
                txtCargo.Text = Concesionario.Cargo;
                txtRfc.Text = Concesionario.Rfc;
                dtConNacimiento.Value = Concesionario.FechaNacimiento;
                cmbConMunicipio.SelectedItem = Concesionario.Municipio;
                txtConTelefono.Text = Concesionario.Telefono;
                if (Concesionario.Taxi != null)
                {
                    txtNumero.Text = Concesionario.Taxi.NumeroEconomico;
                    txtSitio.Text = Concesionario.Taxi.Sitio;
                    txtPlaca.Text = Concesionario.Taxi.Placa;
                    txtNumSerie.Text = Concesionario.Taxi.NumeroSerie;
                    txtCapacidad.Value = int.Parse((string)Concesionario.Taxi.Capacidad);
                    txtMarca.Text = Concesionario.Taxi.Marca;
                    txtModelo.Value = new DateTime(int.Parse((string)Concesionario.Taxi.Modelo), 01, 01);
                    txtMotor.Text = Concesionario.Taxi.Motor;
                }
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
                var concesionario = new Models.Concesionario
                {
                    Nombres = txtNombre.Text.Trim(),
                    ApellidoPaterno = txtApPaterno.Text.Trim(),
                    ApellidoMaterno = txtApMaterno.Text.Trim(),
                    Domicilio = txtConCalle.Text.Trim(),
                    Colonia = txtConColonia.Text.Trim(),
                    Cargo = txtCargo.Text.Trim(),
                    Rfc = txtRfc.Text.Trim(),
                    FechaNacimiento = dtConNacimiento.Value,
                    Municipio = (string)cmbConMunicipio.SelectedItem,
                    Telefono = txtConTelefono.Text.Trim(),
                    Taxi = new Taxi
                    {
                        NumeroEconomico = txtNumero.Text.Trim(),
                        Sitio = txtSitio.Text.Trim(),
                        Placa = txtPlaca.Text.Trim(),
                        NumeroSerie = txtNumSerie.Text.Trim(),
                        Capacidad = txtCapacidad.Value.ToString(),
                        Marca = txtMarca.Text.Trim(),
                        Modelo = txtModelo.Text.Trim(),
                        Motor = txtMotor.Text.Trim()
                    }
                };

                using (var db = new Db())
                {
                    db.Concesionarios.Add(concesionario);
                    db.SaveChanges();

                    Concesionario = db.Concesionarios.Where(u => u.Telefono == concesionario.Telefono).First();
                }
                cargarDatos();

                modoVer();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Concesionario != null)
            {
                using (var db = new Db())
                {
                    var concesionario = db.Concesionarios.Where(u => u.Id == Concesionario.Id).First();

                    concesionario.Nombres = txtNombre.Text.Trim();
                    concesionario.ApellidoPaterno = txtApPaterno.Text.Trim();
                    concesionario.ApellidoMaterno = txtApMaterno.Text.Trim();
                    concesionario.Cargo = txtCargo.Text.Trim();
                    concesionario.Colonia = txtConColonia.Text.Trim();
                    concesionario.Domicilio = txtConCalle.Text.Trim();
                    concesionario.Rfc = txtRfc.Text.Trim();
                    concesionario.FechaNacimiento = dtConNacimiento.Value;
                    concesionario.Municipio = (string)cmbConMunicipio.SelectedItem;
                    concesionario.Telefono = txtConTelefono.Text.Trim();
                    concesionario.Taxi.Capacidad = txtCapacidad.Value.ToString();
                    concesionario.Taxi.Marca = txtMarca.Text.Trim();
                    concesionario.Taxi.Modelo = txtModelo.Text.Trim();
                    concesionario.Taxi.Motor = txtMotor.Text.Trim();
                    concesionario.Taxi.NumeroEconomico = txtNumero.Text.Trim();
                    concesionario.Taxi.NumeroSerie = txtNumSerie.Text.Trim();
                    concesionario.Taxi.Placa = txtPlaca.Text.Trim();
                    concesionario.Taxi.Sitio = txtSitio.Text.Trim();

                    db.SaveChanges();

                    Concesionario = concesionario;

                }
                cargarDatos();

                DialogResult boton = MessageBox.Show("Concesionario modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Concesionario != null)
            {
                using (var db = new Db())
                {
                    var concesionario = db.Concesionarios.Where(u => u.Id == Concesionario.Id).First();
                    DialogResult boton = MessageBox.Show(string.Format("¿Quieres eliminar a {0} {1}?", 
                                                             concesionario.Nombres, 
                                                             concesionario.ApellidoPaterno), "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                    if (boton == DialogResult.Yes)
                    {

                        if (concesionario.Taxi != null)
                            db.Taxis.Remove(concesionario.Taxi);

                        if (concesionario.Poliza != null)
                            db.Polizas.Remove(concesionario.Poliza);

                        if (concesionario.ReciboPoliza.Any())
                        {
                            foreach(var recibos in db.RecibosPoliza.Where(x=>x.Concesionario.Id == concesionario.Id))
                            {
                                db.RecibosPoliza.Remove(recibos);
                            }
                        }

                        if (concesionario.ReciboPrimerIngreso.Any())
                        {
                            foreach (var recibos in db.RecibosPrimerIngreso.Where(x => x.Concesionario.Id == concesionario.Id))
                            {
                                db.RecibosPrimerIngreso.Remove(recibos);
                            }
                        }

                        db.Concesionarios.Remove(concesionario);
                        db.SaveChanges();
                        var concesionarios = db.Concesionarios.OrderBy(x => x.ApellidoPaterno).ThenBy(x => x.ApellidoMaterno).ThenBy(x => x.Nombres);

                        if (concesionarios.Any())
                            Concesionario = concesionarios.First();
                        else
                            Concesionario = null;
                    }
                }
                cargarDatos();
            }
        }
        
        private void lvConcesionarios_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sort = e.Column;
            cargarDatos();    
        }

        private void lvConcesionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConcesionarios.SelectedIndices.Count == 0) return;

            int id = Int32.Parse(lvConcesionarios.SelectedItems[0].SubItems[0].Text);

            using (var db = new Db())
            {
                var user = db.Concesionarios.Where(u => u.Id == id).First();
                Concesionario = user;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            search = txtBuscar.Text.Trim();
            cargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            using (var db = new Db())
            {
                if (db.Concesionarios.Any())
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
            txtCargo.Text = "";
            txtRfc.Text = "";
            dtConNacimiento.Value = new DateTime(1980, 1, 1);
            txtConTelefono.Text = "";
            cmbConMunicipio.SelectedIndex = -1;
            txtNumero.Text = "";
            txtSitio.Text = "";
            txtPlaca.Text = "";
            txtNumSerie.Text = "";
            txtCapacidad.Value = 0;
            txtMarca.Text = "";
            txtModelo.Value = new DateTime(2015, 01, 01);
            txtMotor.Text = "";

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

            ActiveControl = lvConcesionarios;

            isModoVer = true;
        }

        private void btnReciboPoliza_Click(object sender, EventArgs e)
        {
            if (isModoVer)
            {
                var recibosForm = new ReciboPolizaForm(Concesionario);
                recibosForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un Concesionario primero", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnPoliza_Click(object sender, EventArgs e)
        {
            if (isModoVer)
            {
                var polizaForm = new PolizaForm(Concesionario);
                polizaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un Concesionario primero", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrimerIngreso_Click(object sender, EventArgs e)
        {
            if (isModoVer)
            {
                var recibosForm = new ReciboPrimerIngresoForm(Concesionario);
                recibosForm.ShowDialog();
                return;
            }
            MessageBox.Show("Selecciona un Concesionario primero", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void chckSitio_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cmbSitios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void lvConcesionarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lvConcesionarios.SelectedIndices.Count == 0) return;

            int id = Int32.Parse(lvConcesionarios.SelectedItems[0].SubItems[0].Text);

            if (e.KeyChar == (char)Keys.Delete)
            {
                

                Console.WriteLine(id);
            } else if(e.KeyChar == (char)Keys.B)
            {
                Console.WriteLine("b" + id);
            }
        }

        private void lvConcesionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnEliminar_Click(null, null);
            }
        }
    }
}
