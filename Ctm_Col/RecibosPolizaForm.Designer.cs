namespace Ctm_Col
{
    partial class RecibosPolizaForm
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
            this.lvRecibos = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDescartar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chckSitio = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbSitios = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.chckFecha = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtId = new Ctm_Col.MaterialTextBox();
            this.txtApMaterno = new Ctm_Col.MaterialTextBox();
            this.txtApPaterno = new Ctm_Col.MaterialTextBox();
            this.txtNombre = new Ctm_Col.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRecibos
            // 
            this.lvRecibos.AllowColumnReorder = true;
            this.lvRecibos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader4});
            this.lvRecibos.FullRowSelect = true;
            this.lvRecibos.GridLines = true;
            this.lvRecibos.Location = new System.Drawing.Point(14, 399);
            this.lvRecibos.Name = "lvRecibos";
            this.lvRecibos.Size = new System.Drawing.Size(443, 148);
            this.lvRecibos.TabIndex = 0;
            this.lvRecibos.UseCompatibleStateImageBehavior = false;
            this.lvRecibos.View = System.Windows.Forms.View.Details;
            this.lvRecibos.SelectedIndexChanged += new System.EventHandler(this.lvRecibos_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 31;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cantidad";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Número";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sitio";
            this.columnHeader4.Width = 115;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(14, 153);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(147, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DecimalPlaces = 2;
            this.txtCantidad.Location = new System.Drawing.Point(241, 153);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(14, 204);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(84, 36);
            this.btnActualizar.TabIndex = 54;
            this.btnActualizar.Text = "Modificar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(115, 204);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = false;
            this.btnNuevo.Size = new System.Drawing.Size(57, 36);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(288, 204);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.AutoSize = true;
            this.btnDescartar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDescartar.Depth = 0;
            this.btnDescartar.Location = new System.Drawing.Point(189, 204);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDescartar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Primary = false;
            this.btnDescartar.Size = new System.Drawing.Size(82, 36);
            this.btnDescartar.TabIndex = 55;
            this.btnDescartar.Text = "Cancelar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(379, 204);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton1.TabIndex = 57;
            this.materialFlatButton1.Text = "Imprimir";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 76;
            this.label3.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(6, 51);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(144, 23);
            this.txtBuscar.TabIndex = 75;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // chckSitio
            // 
            this.chckSitio.AutoSize = true;
            this.chckSitio.Depth = 0;
            this.chckSitio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chckSitio.Location = new System.Drawing.Point(164, 27);
            this.chckSitio.Margin = new System.Windows.Forms.Padding(0);
            this.chckSitio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckSitio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckSitio.Name = "chckSitio";
            this.chckSitio.Ripple = true;
            this.chckSitio.Size = new System.Drawing.Size(81, 30);
            this.chckSitio.TabIndex = 77;
            this.chckSitio.Text = "Por sitio";
            this.chckSitio.UseVisualStyleBackColor = true;
            this.chckSitio.CheckedChanged += new System.EventHandler(this.chckSitio_CheckedChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Enabled = false;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(294, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(28, 12);
            this.lblFecha.TabIndex = 79;
            this.lblFecha.Text = "Sitio";
            // 
            // cmbSitios
            // 
            this.cmbSitios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSitios.FormattingEnabled = true;
            this.cmbSitios.Location = new System.Drawing.Point(296, 32);
            this.cmbSitios.Name = "cmbSitios";
            this.cmbSitios.Size = new System.Drawing.Size(121, 21);
            this.cmbSitios.TabIndex = 78;
            this.cmbSitios.SelectedIndexChanged += new System.EventHandler(this.cmbSitios_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaIni);
            this.groupBox1.Controls.Add(this.chckFecha);
            this.groupBox1.Controls.Add(this.chckSitio);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.cmbSitios);
            this.groupBox1.Location = new System.Drawing.Point(14, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 109);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 84;
            this.label5.Text = "Fecha final";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(350, 77);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaFin.TabIndex = 83;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "Fecha Inicial";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(251, 77);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaIni.TabIndex = 81;
            this.dtpFechaIni.ValueChanged += new System.EventHandler(this.dtpFechaIni_ValueChanged);
            // 
            // chckFecha
            // 
            this.chckFecha.AutoSize = true;
            this.chckFecha.Depth = 0;
            this.chckFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chckFecha.Location = new System.Drawing.Point(164, 68);
            this.chckFecha.Margin = new System.Windows.Forms.Padding(0);
            this.chckFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckFecha.Name = "chckFecha";
            this.chckFecha.Ripple = true;
            this.chckFecha.Size = new System.Drawing.Size(67, 30);
            this.chckFecha.TabIndex = 80;
            this.chckFecha.Text = "Fecha";
            this.chckFecha.UseVisualStyleBackColor = true;
            this.chckFecha.CheckedChanged += new System.EventHandler(this.chckFecha_CheckedChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(14, 72);
            this.txtId.Name = "txtId";
            this.txtId.Placeholder = "ID";
            this.txtId.Size = new System.Drawing.Size(46, 48);
            this.txtId.TabIndex = 56;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Enabled = false;
            this.txtApMaterno.Location = new System.Drawing.Point(288, 72);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Placeholder = "Apellido Materno";
            this.txtApMaterno.Size = new System.Drawing.Size(126, 48);
            this.txtApMaterno.TabIndex = 18;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Enabled = false;
            this.txtApPaterno.Location = new System.Drawing.Point(168, 72);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Placeholder = "Apellido Paterno";
            this.txtApPaterno.Size = new System.Drawing.Size(114, 48);
            this.txtApPaterno.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(77, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Placeholder = "Nombre(s)";
            this.txtNombre.Size = new System.Drawing.Size(85, 48);
            this.txtNombre.TabIndex = 16;
            // 
            // RecibosPolizaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lvRecibos);
            this.Name = "RecibosPolizaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recibos Póliza";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRecibos;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private MaterialTextBox txtNombre;
        private MaterialTextBox txtApPaterno;
        private MaterialTextBox txtApMaterno;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnNuevo;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnDescartar;
        private MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialCheckBox chckSitio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbSitios;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckBox chckFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}