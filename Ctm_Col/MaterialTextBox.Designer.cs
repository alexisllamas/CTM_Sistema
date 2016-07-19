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
            this.txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.placeholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Depth = 0;
            this.txt.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Hint = "";
            this.txt.Location = new System.Drawing.Point(0, 19);
            this.txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(169, 23);
            this.txt.TabIndex = 0;
            this.txt.TabStop = false;
            this.txt.Enter += new System.EventHandler(this.txt_Enter);
            this.txt.Leave += new System.EventHandler(this.txt_Leave);
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
            this.placeholder.Visible = false;
            // 
            // MaterialTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.txt);
            this.Name = "MaterialTextBox";
            this.Size = new System.Drawing.Size(172, 48);
            this.Resize += new System.EventHandler(this.MaterialTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txt;
        private System.Windows.Forms.Label placeholder;
    }
}
