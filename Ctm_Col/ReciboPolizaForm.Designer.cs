namespace Ctm_Col
{
    partial class ReciboPolizaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciboPolizaForm));
            this.recibosPolizaControl1 = new Ctm_Col.RecibosPolizaControl();
            this.SuspendLayout();
            // 
            // recibosPolizaControl1
            // 
            this.recibosPolizaControl1.Concesionario = null;
            this.recibosPolizaControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recibosPolizaControl1.Location = new System.Drawing.Point(0, 0);
            this.recibosPolizaControl1.Name = "recibosPolizaControl1";
            this.recibosPolizaControl1.Recibo = null;
            this.recibosPolizaControl1.Size = new System.Drawing.Size(456, 494);
            this.recibosPolizaControl1.TabIndex = 0;
            // 
            // ReciboPolizaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 494);
            this.Controls.Add(this.recibosPolizaControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReciboPolizaForm";
            this.Text = "Recibo Poliza";
            this.ResumeLayout(false);

        }

        #endregion

        private RecibosPolizaControl recibosPolizaControl1;
    }
}