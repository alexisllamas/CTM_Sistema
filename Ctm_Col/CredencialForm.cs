using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Ctm_Col.Models;

namespace Ctm_Col
{
    public partial class CredencialForm : MaterialForm
    {
        private Models.Chofer _chofer;
        private Credencial _credencial;

        public CredencialForm(Models.Chofer chofer)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);

            Console.WriteLine(chofer.Nombres);
            _chofer = chofer;

            using (var db = new Db())
            {
                var credencial = db.Choferes.Where(x => x.Id == _chofer.Id).First().Credencial;

                if(credencial != null)
                {
                    _credencial = credencial;
                    cargarDatos();

                    if (isExpired(_credencial))
                    {
                        MessageBox.Show("Está expirada");
                        expirada();
                    }
                } else
                {
                    cargarDatosNoCredencial();
                }
            }
        }

        private void cargarDatos()
        {
            txtNombre.Text = _chofer.Nombres;
            txtApPaterno.Text = _chofer.ApellidoPaterno;
            txtApMaterno.Text = _chofer.ApellidoMaterno;

            dtpFechaIni.Value = _credencial.FechaInicioVigencia;
            dtpFechaFin.Value = _credencial.FechaFinalVigencia;

            btnImprimir.Enabled = !isExpired(_credencial);
            btnRenovar.Text = "Renovar";

            btnRenovar.Enabled = isExpired(_credencial);
        }

        private void cargarDatosNoCredencial()
        {
            txtNombre.Text = _chofer.Nombres;
            txtApPaterno.Text = _chofer.ApellidoPaterno;
            txtApMaterno.Text = _chofer.ApellidoMaterno;

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
                if (_credencial != null)
                {
                    var credencial = db.Credenciales.Where(x => x.Id == _credencial.Id).First();
                    credencial.FechaInicioVigencia = DateTime.Today;
                    credencial.FechaFinalVigencia = DateTime.Today.AddYears(1);

                    db.SaveChanges();

                    _credencial = credencial;
                } else
                {
                    var credencial = new Credencial
                    {
                        FechaInicioVigencia = DateTime.Today,
                        FechaFinalVigencia = DateTime.Today.AddYears(1)
                    };

                    var chofer = db.Choferes.Where(x => x.Id == _chofer.Id).First();

                    chofer.Credencial = credencial;

                    db.SaveChanges();

                    _credencial = db.Choferes.Where(x => x.Id == _chofer.Id).First().Credencial;
                }
                var recibo = new ReciboCredencial
                {
                    Cantidad = 200,
                    Fecha = DateTime.Today,
                    Chofer = db.Choferes.Where(x => x.Id == _chofer.Id).First()
                };

                db.RecibosCredencial.Add(recibo);
                db.SaveChanges();
                cargarDatos();
            }
        }

        private bool isExpired(Credencial credencial)
        {
            if(credencial.FechaFinalVigencia.CompareTo(DateTime.Today) < 0)
            {
                return true;
            }

            return false;
        }
        
        private void expirada()
        {
            btnImprimir.Enabled = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.Credencial(_credencial, this);
        }
    }
}
