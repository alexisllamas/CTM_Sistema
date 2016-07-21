namespace Ctm_Col
{
    partial class RecibosForm
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
            this.btnReciboPolizas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnReciboPolizas
            // 
            this.btnReciboPolizas.Depth = 0;
            this.btnReciboPolizas.Location = new System.Drawing.Point(12, 76);
            this.btnReciboPolizas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReciboPolizas.Name = "btnReciboPolizas";
            this.btnReciboPolizas.Primary = true;
            this.btnReciboPolizas.Size = new System.Drawing.Size(173, 49);
            this.btnReciboPolizas.TabIndex = 0;
            this.btnReciboPolizas.Text = "Recibos de Pólizas";
            this.btnReciboPolizas.UseVisualStyleBackColor = true;
            this.btnReciboPolizas.Click += new System.EventHandler(this.btnReciboPolizas_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(229, 76);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(173, 49);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "Recibos de Credencial";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(122, 166);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(173, 49);
            this.materialRaisedButton3.TabIndex = 2;
            this.materialRaisedButton3.Text = "Recibos de Deducibles";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // RecibosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 256);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.btnReciboPolizas);
            this.Name = "RecibosForm";
            this.Text = "Recibos";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnReciboPolizas;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}