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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConcesionarios_Click(object sender, EventArgs e)
        {
            var con = new ConcesionarioForm();
            con.Show();
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            var cho = new ChoferForm();
            cho.Show();
        }
    }
}
