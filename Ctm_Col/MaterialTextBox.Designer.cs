namespace Ctm_Col
{
    partial class MaterialTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.placeholder = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Enabled = false;
            this.placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.Location = new System.Drawing.Point(-3, 3);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(0, 13);
            this.placeholder.TabIndex = 100;
            // 
            // txt
            // 
            this.txt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt.Location = new System.Drawing.Point(0, 22);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(106, 20);
            this.txt.TabIndex = 101;
            // 
            // MaterialTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.placeholder);
            this.Name = "MaterialTextBox";
            this.Size = new System.Drawing.Size(106, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.TextBox txt;
    }
}
