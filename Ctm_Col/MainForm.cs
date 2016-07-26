using System.Windows.Forms;

namespace Ctm_Col
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        ConcesionarioControl con;
        ChoferControl chofer;
        RecibosCredencialControl reciboCredencial;
        RecibosDeducibleControl reciboDeducible;
        RecibosPolizaControl reciboPoliza;
        RecibosPrimerIngresoControl reciboPrimer;
        public MainForm()
        {
            InitializeComponent();
        }

        private void nviConcesionario_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            splitContainerControl1.Panel2.Controls.Clear();
            if (con == null) { 
                con = new ConcesionarioControl { Dock = DockStyle.Fill };
            }
            splitContainerControl1.Panel2.Controls.Add(con);
        }

        private void nvbChofer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            splitContainerControl1.Panel2.Controls.Clear();
            if (chofer == null)
            {
                chofer = new ChoferControl() { Dock = DockStyle.Fill };
            }
            splitContainerControl1.Panel2.Controls.Add(chofer);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            splitContainerControl1.Panel2.Controls.Clear();
            if (reciboCredencial == null)
            {
                reciboCredencial = new RecibosCredencialControl() { Dock = DockStyle.Fill };
            }
            reciboCredencial.llenarTabla();
            splitContainerControl1.Panel2.Controls.Add(reciboCredencial);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new GenerarPolizaForm();
            form.ShowDialog();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            splitContainerControl1.Panel2.Controls.Clear();
            if (reciboDeducible == null)
            {
                reciboDeducible = new RecibosDeducibleControl() { Dock = DockStyle.Fill };
            }
            reciboDeducible.llenarTabla();
            splitContainerControl1.Panel2.Controls.Add(reciboDeducible);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            splitContainerControl1.Panel2.Controls.Clear();
            if (reciboPoliza == null)
            {
                reciboPoliza = new RecibosPolizaControl() { Dock = DockStyle.Fill };
            }
            reciboPoliza.llenarTabla();
            splitContainerControl1.Panel2.Controls.Add(reciboPoliza);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            splitContainerControl1.Panel2.Controls.Clear();
            if (reciboPrimer == null)
            {
                reciboPrimer = new RecibosPrimerIngresoControl() { Dock = DockStyle.Fill };
            }
            reciboPrimer.llenarTabla();
            splitContainerControl1.Panel2.Controls.Add(reciboPrimer);
        }
    }
}
