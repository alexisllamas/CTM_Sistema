using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ctm_Col.Models;
using System.Data.Entity;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Ctm_Col
{
    public partial class UsuarioFormulario : MaterialForm
    {
        public string search = "";
        public string order = "id";
        public UsuarioFormulario()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);

            using (var db = new Db())
            {

                //var users = db.Usuarios;
                //cargarDatos(users);

                //if (db.Usuarios.Count() > 0)
                //    Usuario = db.Usuarios.OrderBy(x => x.ApellidoPaterno).ThenBy(x => x.ApellidoMaterno).ThenBy(x => x.Nombres).First();
                //else
                //{
                //    MessageBox.Show("No hay datos, agrega algunos");
                //}
            }
        }

        private void cargarDatos(IOrderedQueryable<Usuario> users)
        {
            //lvUsuarios.Items.Clear();
            //users = users.Where( u => u.Id.ToString().StartsWith(search) ||
            //    u.Nombres.StartsWith(search) || 
            //    u.ApellidoPaterno.StartsWith(search) || 
            //    u.ApellidoMaterno.StartsWith(search) ||
            //    u.Telefono.StartsWith(search) ||
            //    u.Municipio.StartsWith(search) ||
            //    u.Taxi.NumeroEconomico.Equals(search) ||
            //    u.Taxi.Sitio.StartsWith(search) ||
            //    u.Licencia.StartsWith(search)) 
            //    .OrderBy(x => x.ApellidoPaterno).ThenBy(x => x.ApellidoMaterno).ThenBy(x => x.Nombres);

            //int i = 0;
            //foreach (var user in users)
            //{
            //    var lvi = new ListViewItem(user.Id.ToString());
            //    lvi.SubItems.Add(user.Nombres);
            //    lvi.SubItems.Add(user.ApellidoPaterno);
            //    lvi.SubItems.Add(user.ApellidoMaterno);
            //    lvi.SubItems.Add(user.Municipio);
            //    lvi.SubItems.Add(user.Telefono);
            //    lvi.SubItems.Add(user.Taxi.NumeroEconomico);
            //    lvi.SubItems.Add(user.Taxi.Sitio);
            //    lvi.SubItems.Add(user.Licencia);

            //    lvUsuarios.Items.Add(lvi);
            //    i++;
            //}
        }

        //private Usuario _usuario;

        //public Usuario Usuario
        //{
        //    get
        //    {
        //        return _usuario;
        //    }

        //    set
        //    {
        //        _usuario = value;
        //        if (_usuario != null)
        //        {
        //            modoVer();
        //        }
        //    }
        //}

        private void llenarDatos()
        {
            //txtId.Text = _usuario.Id.ToString();
            //txtNombre.Text = _usuario.Nombres;
            //txtApPaterno.Text = _usuario.ApellidoPaterno;
            //txtApMaterno.Text = _usuario.ApellidoMaterno;
            //txtCalle.Text = _usuario.Domicilio;
            //txtColonia.Text = _usuario.Colonia;
            //txtCargo.Text = _usuario.Cargo;
            //txtLicencia.Text = _usuario.Licencia;
            //txtRfc.Text = _usuario.Rfc;
            //txtObservaciones.Text = _usuario.Observaciones;
            //dtNacimiento.Value = _usuario.FechaNacimiento;
            //cmbMunicipio.SelectedItem = _usuario.Municipio;
            //txtTelefono.Text = _usuario.Telefono;
            //txtNumero.Text = _usuario.Taxi.NumeroEconomico;
            //txtSitio.Text = _usuario.Taxi.Sitio;
            //txtPlaca.Text = _usuario.Taxi.Placa;
            //txtNumSerie.Text = _usuario.Taxi.NumeroSerie;
            //txtCapacidad.Value = Int32.Parse(_usuario.Taxi.Capacidad);
            //txtMarca.Text = _usuario.Taxi.Marca;
            //txtModelo.Value = new DateTime(Int32.Parse(_usuario.Taxi.Modelo), 01, 01);
            //txtMotor.Text = _usuario.Taxi.Motor;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
        //    if (btnNuevo.Text == "Nuevo")
        //    {
        //        modoNuevo();
        //    } else
        //    {
        //        var user = new Usuario
        //        {
        //            Nombres = txtNombre.Text.Trim(),
        //            ApellidoPaterno = txtApPaterno.Text.Trim(),
        //            ApellidoMaterno = txtApMaterno.Text.Trim(),
        //            Domicilio = txtCalle.Text.Trim(),
        //            Colonia = txtColonia.Text.Trim(),
        //            Cargo = txtCargo.Text.Trim(),
        //            Licencia = txtLicencia.Text.Trim(),
        //            Rfc = txtRfc.Text.Trim(),
        //            Observaciones = txtObservaciones.Text.Trim(),
        //            FechaNacimiento = dtNacimiento.Value,
        //            Municipio = (string)cmbMunicipio.SelectedItem,
        //            Telefono = txtTelefono.Text.Trim(),
        //            Taxi = new Taxi
        //            {
        //                NumeroEconomico = txtNumero.Text.Trim(),
        //                Sitio = txtSitio.Text.Trim(),
        //                Placa = txtPlaca.Text.Trim(),
        //                NumeroSerie = txtNumSerie.Text.Trim(),
        //                Capacidad = txtCapacidad.Value.ToString(),
        //                Marca = txtMarca.Text.Trim(),
        //                Modelo = txtModelo.Text.Trim(),
        //                Motor = txtMotor.Text.Trim()                        
        //            }
        //    };

        //        using (var db = new Db())
        //        {
        //            db.Usuarios.Add(user);
        //            db.SaveChanges();

        //            Usuario = db.Usuarios.Where(u => u.Telefono == user.Telefono).First();
        //            cargarDatos(db.Usuarios);
        //        }

        //        modoVer();
        //    }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(_usuario.Id);
            //if (_usuario != null)
            //{
            //    using (var db = new Db())
            //    {
            //        var user = db.Usuarios.Where(u => u.Id == _usuario.Id).First();

            //        user.Nombres = txtNombre.Text.Trim();
            //        user.ApellidoPaterno = txtApPaterno.Text.Trim();
            //        user.ApellidoMaterno = txtApMaterno.Text.Trim();
            //        user.Cargo = txtCargo.Text.Trim();
            //        user.Colonia = txtColonia.Text.Trim();
            //        user.Domicilio = txtCalle.Text.Trim();
            //        user.Licencia = txtLicencia.Text.Trim();
            //        user.Rfc = txtRfc.Text.Trim();
            //        user.Observaciones = txtObservaciones.Text.Trim();
            //        user.FechaNacimiento = dtNacimiento.Value;
            //        user.Municipio = (string)cmbMunicipio.SelectedItem;
            //        user.Telefono = txtTelefono.Text.Trim();
            //        user.Taxi.Capacidad = txtCapacidad.Value.ToString();
            //        user.Taxi.Marca = txtMarca.Text.Trim();
            //        user.Taxi.Modelo = txtModelo.Text.Trim();
            //        user.Taxi.Motor = txtMotor.Text.Trim();
            //        user.Taxi.NumeroEconomico = txtNumero.Text.Trim();
            //        user.Taxi.NumeroSerie = txtNumSerie.Text.Trim();
            //        user.Taxi.Placa = txtPlaca.Text.Trim();
            //        user.Taxi.Sitio = txtSitio.Text.Trim();

            //        db.SaveChanges();

            //        cargarDatos(db.Usuarios);
            //    }

            //    DialogResult boton = MessageBox.Show("Usuario modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (_usuario != null)
            //{
            //    using (var db = new Db())
            //    {
            //        var user = db.Usuarios.Where(u => u.Id == _usuario.Id).First();
            //        DialogResult boton = MessageBox.Show("¿Quieres eliminar a " + user.Nombres + " " + user.ApellidoPaterno + "?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
            //        if (boton == DialogResult.Yes)
            //        {

            //            if (user.Taxi != null)
            //                db.Taxis.Remove(user.Taxi);

            //            db.Usuarios.Remove(user);
            //            Usuario = db.Usuarios.First();
            //            db.SaveChanges();
            //            cargarDatos(db.Usuarios);
            //        }
            //    }
            //}
        }

        private void lvUsuarios_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //using (var db = new Db())
            //{
            //    switch (e.Column)
            //    {
            //        case 0:
            //            cargarDatos(db.Usuarios.OrderBy(x => x.Id));
            //            break;
            //        case 1:
            //            cargarDatos(db.Usuarios.OrderBy(x => x.Nombres));
            //            break;
            //        case 2:
            //            cargarDatos(db.Usuarios.OrderBy(x => x.ApellidoPaterno));
            //            break;
            //        case 3:
            //            cargarDatos(db.Usuarios.OrderBy(x => x.ApellidoMaterno));
            //            break;
            //        case 4:
            //            cargarDatos(db.Usuarios.OrderBy(x => x.Telefono));
            //            break;
            //        case 5:
            //            cargarDatos(db.Usuarios.OrderBy(x => x.Rfc));
            //            break;
            //    }
            //}
        }

        private void lvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvUsuarios.SelectedIndices.Count == 0) return;

            //int id = Int32.Parse(lvUsuarios.SelectedItems[0].SubItems[0].Text);

            //using (var db = new Db())
            //{
            //    var user = db.Usuarios.Where(u => u.Id == id).First();
            //    Usuario = user;
            //}
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //search = txtBuscar.Text.Trim();
            //using (var db = new Db())
            //{
            //    var users = db.Usuarios;
            //    cargarDatos(users);
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modoVer();
        }

        private void modoNuevo()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtCalle.Text = "";
            txtColonia.Text = "";
            txtCargo.Text = "";
            txtLicencia.Text = "";
            txtRfc.Text = "";
            txtObservaciones.Text = "";
            dtNacimiento.Value = new DateTime(1980, 1, 1);
            txtTelefono.Text = "";
            cmbMunicipio.SelectedIndex = -1;
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
            btnCancelar.Enabled = true;
        }

        private void modoVer()
        {
            llenarDatos();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Text = "Nuevo";
            btnCancelar.Enabled = false;

            ActiveControl = lvUsuarios;
        }
    }
}
