using MaterialSkin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ctm_Col
{
    public partial class MainForm : Form
    {
        ConcesionarioControl con;
        ChoferControl chofer;
        RecibosCredencialControl reciboCredencial;
        RecibosDeducibleControl reciboDeducible;
        RecibosPolizaControl reciboPoliza;
        RecibosPrimerIngresoControl reciboPrimer;
        const int SPACE = 20;
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void btnConcesionario_Click(object sender, System.EventArgs e)
        {
            Text = "Concesionario";
            Cursor.Current = Cursors.WaitCursor;
            splitContainer1.Panel2.Controls.Clear();
            if (con == null)
            {
                con = new ConcesionarioControl { Dock = DockStyle.Fill };
            }
            splitContainer1.Panel2.Controls.Add(con);

            setSize(787);
        }

        private void btnChofer_Click(object sender, System.EventArgs e)
        {
            Text = "Chofer";
            Cursor.Current = Cursors.WaitCursor;
            splitContainer1.Panel2.Controls.Clear();
            if (chofer == null)
            {
                chofer = new ChoferControl() { Dock = DockStyle.Fill };
            }
            splitContainer1.Panel2.Controls.Add(chofer);

            setSize(629);
        }

        private void btnReciboCredencial_Click(object sender, System.EventArgs e)
        {
            Text = "Recibos Credencial";
            Cursor.Current = Cursors.WaitCursor;
            splitContainer1.Panel2.Controls.Clear();
            if (reciboCredencial == null)
            {
                reciboCredencial = new RecibosCredencialControl() { Dock = DockStyle.Fill };
            }
            reciboCredencial.llenarTabla();
            splitContainer1.Panel2.Controls.Add(reciboCredencial);

            setSize(539);
        }

        private void btnReciboDeducible_Click(object sender, System.EventArgs e)
        {
            Text = "Recibos Deducible";
            Cursor.Current = Cursors.WaitCursor;
            splitContainer1.Panel2.Controls.Clear();
            if (reciboDeducible == null)
            {
                reciboDeducible = new RecibosDeducibleControl() { Dock = DockStyle.Fill };
            }
            reciboDeducible.llenarTabla();
            splitContainer1.Panel2.Controls.Add(reciboDeducible);

            setSize(601);
        }

        private void btnReciboPoliza_Click(object sender, System.EventArgs e)
        {
            Text = "Recibos Póliza";
            Cursor.Current = Cursors.WaitCursor;
            splitContainer1.Panel2.Controls.Clear();
            if (reciboPoliza == null)
            {
                reciboPoliza = new RecibosPolizaControl() { Dock = DockStyle.Fill };
            }
            reciboPoliza.llenarTabla();
            splitContainer1.Panel2.Controls.Add(reciboPoliza);

            setSize(463);
        }

        private void btnReciboPrimer_Click(object sender, System.EventArgs e)
        {
            Text = "Recibos Primer Ingreso";
            MinimumSize = new System.Drawing.Size();
            Cursor.Current = Cursors.WaitCursor;
            splitContainer1.Panel2.Controls.Clear();
            if (reciboPrimer == null)
            {
                reciboPrimer = new RecibosPrimerIngresoControl() { Dock = DockStyle.Fill };
            }
            reciboPrimer.llenarTabla();
            splitContainer1.Panel2.Controls.Add(reciboPrimer);

            setSize(467);
        }

        private void btnGenerarPoliza_Click(object sender, System.EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //var form = new GenerarPolizaForm();
            //form.ShowDialog();
        }

        private void setSize(int width)
        {
            width += splitContainer1.Panel1.Width + SPACE;
            MinimumSize = new Size(width, 0);
            Width = width;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine(e.Node.Text);
        }
    }
}
