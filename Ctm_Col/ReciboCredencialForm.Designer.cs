namespace Ctm_Col
{
    partial class ReciboCredencialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciboCredencialForm));
            this.recibosCredencialControl1 = new Ctm_Col.RecibosCredencialControl();
            this.SuspendLayout();
            // 
            // recibosCredencialControl1
            // 
            this.recibosCredencialControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recibosCredencialControl1.Chofer = null;
            this.recibosCredencialControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recibosCredencialControl1.Location = new System.Drawing.Point(0, 0);
            this.recibosCredencialControl1.Name = "recibosCredencialControl1";
            this.recibosCredencialControl1.Recibo = null;
            this.recibosCredencialControl1.Size = new System.Drawing.Size(528, 454);
            this.recibosCredencialControl1.TabIndex = 0;
            // 
            // ReciboCredencialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 454);
            this.Controls.Add(this.recibosCredencialControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReciboCredencialForm";
            this.Text = "Recibo Credencial";
            this.ResumeLayout(false);

        }

        #endregion

        private RecibosCredencialControl recibosCredencialControl1;
    }
}