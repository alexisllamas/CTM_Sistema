namespace Ctm_Col
{
    partial class ReciboDeducibleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciboDeducibleForm));
            this.recibosDeducibleControl1 = new Ctm_Col.RecibosDeducibleControl();
            this.SuspendLayout();
            // 
            // recibosDeducibleControl1
            // 
            this.recibosDeducibleControl1.Chofer = null;
            this.recibosDeducibleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recibosDeducibleControl1.Location = new System.Drawing.Point(0, 0);
            this.recibosDeducibleControl1.Name = "recibosDeducibleControl1";
            this.recibosDeducibleControl1.Recibo = null;
            this.recibosDeducibleControl1.Size = new System.Drawing.Size(598, 472);
            this.recibosDeducibleControl1.TabIndex = 0;
            // 
            // ReciboDeducibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 472);
            this.Controls.Add(this.recibosDeducibleControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReciboDeducibleForm";
            this.Text = "Recibo Deducible";
            this.ResumeLayout(false);

        }

        #endregion

        private RecibosDeducibleControl recibosDeducibleControl1;
    }
}