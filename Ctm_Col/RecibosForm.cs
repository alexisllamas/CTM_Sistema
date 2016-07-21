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

namespace Ctm_Col
{
    public partial class RecibosForm : MaterialForm
    {
        public RecibosForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);

        }

        private void btnReciboPolizas_Click(object sender, EventArgs e)
        {
            var reciboForm = new RecibosPolizaForm();

            reciboForm.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var reciboForm = new RecibosCredencialForm();

            reciboForm.Show();
        }
    }
}
