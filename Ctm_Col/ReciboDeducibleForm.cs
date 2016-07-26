using Ctm_Col.Models;
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
    public partial class ReciboDeducibleForm : Form
    {
        public ReciboDeducibleForm(Chofer Chofer)
        {
            InitializeComponent();

            recibosDeducibleControl1.Chofer = Chofer;
        }
    }
}
