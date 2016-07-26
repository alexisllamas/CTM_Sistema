namespace Ctm_Col
{
    partial class GenerarPolizaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarPolizaForm));
            this.cmbSitios = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGenerar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarTodas = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSitios
            // 
            this.cmbSitios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSitios.FormattingEnabled = true;
            this.cmbSitios.Location = new System.Drawing.Point(25, 151);
            this.cmbSitios.Name = "cmbSitios";
            this.cmbSitios.Size = new System.Drawing.Size(121, 21);
            this.cmbSitios.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Enabled = false;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(23, 136);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(28, 12);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Sitio";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Depth = 0;
            this.btnGenerar.Location = new System.Drawing.Point(198, 149);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Primary = true;
            this.btnGenerar.Size = new System.Drawing.Size(139, 23);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar por sitio";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(25, 99);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaFin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha vigencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ajuste";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.DecimalPlaces = 2;
            this.txtCantidad.Location = new System.Drawing.Point(259, 98);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 20);
            this.txtCantidad.TabIndex = 63;
            // 
            // btnGenerarTodas
            // 
            this.btnGenerarTodas.Depth = 0;
            this.btnGenerarTodas.Location = new System.Drawing.Point(105, 211);
            this.btnGenerarTodas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarTodas.Name = "btnGenerarTodas";
            this.btnGenerarTodas.Primary = true;
            this.btnGenerarTodas.Size = new System.Drawing.Size(153, 35);
            this.btnGenerarTodas.TabIndex = 65;
            this.btnGenerarTodas.Text = "Generar Todas";
            this.btnGenerarTodas.UseVisualStyleBackColor = true;
            this.btnGenerarTodas.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // GenerarPolizaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 267);
            this.Controls.Add(this.btnGenerarTodas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbSitios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarPolizaForm";
            this.Text = "Generar Pólizas";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSitios;
        private System.Windows.Forms.Label lblFecha;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarTodas;
    }
}