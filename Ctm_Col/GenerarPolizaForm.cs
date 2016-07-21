using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Ctm_Col.Models;

namespace Ctm_Col
{
    public partial class GenerarPolizaForm : MaterialForm
    {
        public GenerarPolizaForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);

            using(var db = new Db())
            {
                var sitios = db.Taxis.Select(x => x.Sitio).Distinct();

                foreach (var sitio in sitios)
                {
                    Console.WriteLine(sitio);
                    cmbSitios.Items.Add(sitio);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            var name = "";
            if(boton.Name == "btnGenerar")
            {
                if (cmbSitios.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona un sitio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                name = "l sitio " + (string)cmbSitios.SelectedItem;
            } else
            {
                name = " todos";
            }
            DialogResult advertencia = MessageBox.Show("¿Quieres generar las pólizas de" + name + "?", "Hola", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (advertencia == DialogResult.Yes)
            {
                using (var db = new Db())
                {
                    IQueryable<Concesionario> concesionarios;
                    if (boton.Name == "btnGenerar")
                    {
                        concesionarios = db.Concesionarios.Where(x => x.Taxi.Sitio == (string)cmbSitios.SelectedItem);
                    }
                    else
                    {
                        concesionarios = db.Concesionarios;
                    }

                    foreach (var conce in concesionarios)
                    {
                        if (conce.Poliza == null)
                        {
                            var poliza = new Poliza
                            {
                                FechaInicioVigencia = DateTime.Today,
                                FechaFinalVigencia = dtpFechaFin.Value
                            };

                            var concesionario = db.Concesionarios.Where(x => x.Id == conce.Id).First();

                            concesionario.Poliza = poliza;
                        }
                        else
                        {
                            var poliza = db.Polizas.Where(x => x.Id == conce.Poliza.Id).First();
                            poliza.FechaInicioVigencia = DateTime.Today;
                            poliza.FechaFinalVigencia = DateTime.Today.AddYears(1);

                        }
                        var recibo = new ReciboPoliza
                        {
                            Cantidad = (double)txtCantidad.Value,
                            Fecha = DateTime.Today
                        };

                        conce.ReciboPoliza.Add(recibo);
                    }
                    db.SaveChanges();
                }

                DialogResult imprimir = MessageBox.Show("¿Imprimir las pólizas?", "Hola", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (advertencia == DialogResult.Yes)
                {

                }
            }
        }
    }
}
