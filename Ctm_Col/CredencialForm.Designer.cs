namespace Ctm_Col
{
    partial class CredencialForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRenovar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtApMaterno = new Ctm_Col.MaterialTextBox();
            this.txtApPaterno = new Ctm_Col.MaterialTextBox();
            this.txtNombre = new Ctm_Col.MaterialTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 70;
            this.label4.Text = "Fecha de expedición";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Enabled = false;
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(14, 182);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaIni.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "Fecha de vencimiento";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(200, 182);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaFin.TabIndex = 71;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(46, 211);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = false;
            this.btnImprimir.Size = new System.Drawing.Size(74, 36);
            this.btnImprimir.TabIndex = 73;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnRenovar
            // 
            this.btnRenovar.AutoSize = true;
            this.btnRenovar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRenovar.Depth = 0;
            this.btnRenovar.Enabled = false;
            this.btnRenovar.Location = new System.Drawing.Point(240, 211);
            this.btnRenovar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRenovar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Primary = false;
            this.btnRenovar.Size = new System.Drawing.Size(74, 36);
            this.btnRenovar.TabIndex = 74;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Enabled = false;
            this.txtApMaterno.Location = new System.Drawing.Point(234, 86);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Placeholder = "Apellido Materno";
            this.txtApMaterno.Size = new System.Drawing.Size(126, 48);
            this.txtApMaterno.TabIndex = 68;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Enabled = false;
            this.txtApPaterno.Location = new System.Drawing.Point(114, 86);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Placeholder = "Apellido Paterno";
            this.txtApPaterno.Size = new System.Drawing.Size(114, 48);
            this.txtApPaterno.TabIndex = 67;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(23, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Placeholder = "Nombre(s)";
            this.txtNombre.Size = new System.Drawing.Size(85, 48);
            this.txtNombre.TabIndex = 66;
            // 
            // CredencialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 283);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Name = "CredencialForm";
            this.Text = "Credencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialTextBox txtApMaterno;
        private MaterialTextBox txtApPaterno;
        private MaterialTextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private MaterialSkin.Controls.MaterialFlatButton btnImprimir;
        private MaterialSkin.Controls.MaterialFlatButton btnRenovar;
    }
}