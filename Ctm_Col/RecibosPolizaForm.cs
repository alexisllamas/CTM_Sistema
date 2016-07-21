﻿using Ctm_Col.Models;
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
    public partial class RecibosPolizaForm : MaterialForm
    {
        private Concesionario _concesionario;
        private ReciboPoliza _recibo;

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
                            modoNuevo();
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

        public RecibosPolizaForm()
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
                txtApPaterno.Text = Recibo.Concesionario.ApellidoPaterno;
                txtNombre.Text = Recibo.Concesionario.Nombres;
                txtApMaterno.Text = Recibo.Concesionario.ApellidoMaterno;
            }   
        }

        private void llenarTabla()
        {
            lvRecibos.Items.Clear();
            using (var db = new Db())
            {
                var recibos = db.RecibosPoliza.Where(x => x.Concesionario.Id == Concesionario.Id).OrderByDescending(x=>x.Fecha);
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
                    DialogResult boton = MessageBox.Show("¿Quieres eliminar este recibo " + Recibo.Id + "?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
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
                Recibo = recibo;
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
    }
}
