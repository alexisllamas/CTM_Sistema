namespace Ctm_Col
{
    partial class MainForm
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
            this.btnConcesionarios = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnChoferes = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnConcesionarios
            // 
            this.btnConcesionarios.AutoSize = true;
            this.btnConcesionarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConcesionarios.Depth = 0;
            this.btnConcesionarios.Location = new System.Drawing.Point(40, 108);
            this.btnConcesionarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConcesionarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConcesionarios.Name = "btnConcesionarios";
            this.btnConcesionarios.Primary = false;
            this.btnConcesionarios.Size = new System.Drawing.Size(128, 36);
            this.btnConcesionarios.TabIndex = 0;
            this.btnConcesionarios.Text = "Concesionarios";
            this.btnConcesionarios.UseVisualStyleBackColor = true;
            this.btnConcesionarios.Click += new System.EventHandler(this.btnConcesionarios_Click);
            // 
            // btnChoferes
            // 
            this.btnChoferes.AutoSize = true;
            this.btnChoferes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChoferes.Depth = 0;
            this.btnChoferes.Location = new System.Drawing.Point(196, 108);
            this.btnChoferes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChoferes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Primary = false;
            this.btnChoferes.Size = new System.Drawing.Size(80, 36);
            this.btnChoferes.TabIndex = 1;
            this.btnChoferes.Text = "Choferes";
            this.btnChoferes.UseVisualStyleBackColor = true;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 202);
            this.Controls.Add(this.btnChoferes);
            this.Controls.Add(this.btnConcesionarios);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnConcesionarios;
        private MaterialSkin.Controls.MaterialFlatButton btnChoferes;
    }
}