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
    public partial class PolizaForm : MaterialForm
    {
        private Concesionario _concesionario;
        private Poliza _poliza;

        public PolizaForm(Concesionario conce)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);

            _concesionario = conce;

            using (var db = new Db())
            {
                var poliza = db.Concesionarios.Where(x => x.Id == _concesionario.Id).First().Poliza;

                if (poliza != null)
                {
                    _poliza = poliza;
                    cargarDatos();

                    if (isExpired(_poliza))
                    {
                        MessageBox.Show("Está expirada");
                        expirada();
                    }
                }
                else
                {
                    cargarDatosNoCredencial();
                }
            }
        }

        private void cargarDatos()
        {
            txtNombre.Text = _concesionario.Nombres;
            txtApPaterno.Text = _concesionario.ApellidoPaterno;
            txtApMaterno.Text = _concesionario.ApellidoMaterno;

            dtpFechaIni.Value = _poliza.FechaInicioVigencia;
            dtpFechaFin.Value = _poliza.FechaFinalVigencia;

            btnImprimir.Enabled = !isExpired(_poliza);
            btnRenovar.Text = "Renovar";

            btnRenovar.Enabled = isExpired(_poliza);
        }

        private void cargarDatosNoCredencial()
        {
            txtNombre.Text = _concesionario.Nombres;
            txtApPaterno.Text = _concesionario.ApellidoPaterno;
            txtApMaterno.Text = _concesionario.ApellidoMaterno;

            dtpFechaIni.Enabled = false;
            dtpFechaFin.Enabled = false;
            btnImprimir.Enabled = false;
            btnRenovar.Enabled = true;
            btnRenovar.Text = "Tramitar";
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            using (var db = new Db())
            {
                if (_poliza != null)
                {
                    var poliza = db.Polizas.Where(x => x.Id == _poliza.Id).First();
                    poliza.FechaInicioVigencia = DateTime.Today;
                    poliza.FechaFinalVigencia = DateTime.Today.AddYears(1);

                    db.SaveChanges();

                    _poliza = poliza;
                }
                else
                {
                    var poliza = new Poliza
                    {
                        FechaInicioVigencia = DateTime.Today,
                        FechaFinalVigencia = dtpFechaFin.Value
                    };

                    var concesionario = db.Concesionarios.Where(x => x.Id == _concesionario.Id).First();

                    concesionario.Poliza = poliza;

                    db.SaveChanges();

                    _poliza = db.Concesionarios.Where(x => x.Id == _concesionario.Id).First().Poliza;
                }

                var recibo = new ReciboPoliza
                {
                    Cantidad = 2000,
                    Fecha = DateTime.Today,
                    Concesionario = db.Concesionarios.Where(x => x.Id == _concesionario.Id).First()
                };

                db.RecibosPoliza.Add(recibo);
                db.SaveChanges();
                cargarDatos();
            }
        }

        private bool isExpired(Poliza poliza)
        {
            if (poliza.FechaFinalVigencia.CompareTo(DateTime.Today) < 0)
            {
                return true;
            }

            return false;
        }

        private void expirada()
        {
            btnImprimir.Enabled = false;
        }
    }
}
