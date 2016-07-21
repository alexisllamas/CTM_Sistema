namespace Ctm_Col
{
    partial class PolizaForm
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
            this.materialTextBox1 = new Ctm_Col.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.Location = new System.Drawing.Point(184, 140);
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Placeholder = "";
            this.materialTextBox1.Size = new System.Drawing.Size(172, 48);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "materialTextBox1";
            // 
            // PolizaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 328);
            this.Controls.Add(this.materialTextBox1);
            this.Name = "PolizaForm";
            this.Text = "Póliza";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialTextBox materialTextBox1;
    }
}