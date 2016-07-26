namespace Ctm_Col
{
    partial class RecibosCredencialControl
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
            this.btnImprimir = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtId = new Ctm_Col.MaterialTextBox();
            this.btnDescartar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtApMaterno = new Ctm_Col.MaterialTextBox();
            this.txtApPaterno = new Ctm_Col.MaterialTextBox();
            this.txtNombre = new Ctm_Col.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lvRecibos = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.chckFecha = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(373, 6);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = false;
            this.btnImprimir.Size = new System.Drawing.Size(74, 36);
            this.btnImprimir.TabIndex = 71;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(7, 3);
            this.txtId.Name = "txtId";
            this.txtId.Placeholder = "ID";
            this.txtId.Size = new System.Drawing.Size(46, 48);
            this.txtId.TabIndex = 70;
            // 
            // btnDescartar
            // 
            this.btnDescartar.AutoSize = true;
            this.btnDescartar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDescartar.Depth = 0;
            this.btnDescartar.Location = new System.Drawing.Point(181, 6);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDescartar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Primary = false;
            this.btnDescartar.Size = new System.Drawing.Size(82, 36);
            this.btnDescartar.TabIndex = 69;
            this.btnDescartar.Text = "Cancelar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(4, 6);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(84, 36);
            this.btnActualizar.TabIndex = 68;
            this.btnActualizar.Text = "Modificar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(106, 6);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = false;
            this.btnNuevo.Size = new System.Drawing.Size(57, 36);
            this.btnNuevo.TabIndex = 67;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(281, 6);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Enabled = false;
            this.txtApMaterno.Location = new System.Drawing.Point(281, 3);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Placeholder = "Apellido Materno";
            this.txtApMaterno.Size = new System.Drawing.Size(126, 48);
            this.txtApMaterno.TabIndex = 65;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Enabled = false;
            this.txtApPaterno.Location = new System.Drawing.Point(161, 3);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Placeholder = "Apellido Paterno";
            this.txtApPaterno.Size = new System.Drawing.Size(114, 48);
            this.txtApPaterno.TabIndex = 64;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(70, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Placeholder = "Nombre(s)";
            this.txtNombre.Size = new System.Drawing.Size(85, 48);
            this.txtNombre.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 62;
            this.label1.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "Fecha";
            // 
            // txtCantidad
            // 
            this.txtCantidad.DecimalPlaces = 2;
            this.txtCantidad.Location = new System.Drawing.Point(234, 84);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 20);
            this.txtCantidad.TabIndex = 60;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(7, 84);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(147, 20);
            this.dtpFecha.TabIndex = 59;
            // 
            // lvRecibos
            // 
            this.lvRecibos.AllowColumnReorder = true;
            this.lvRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRecibos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRecibos.FullRowSelect = true;
            this.lvRecibos.GridLines = true;
            this.lvRecibos.Location = new System.Drawing.Point(8, 267);
            this.lvRecibos.Name = "lvRecibos";
            this.lvRecibos.Size = new System.Drawing.Size(519, 167);
            this.lvRecibos.TabIndex = 58;
            this.lvRecibos.UseCompatibleStateImageBehavior = false;
            this.lvRecibos.View = System.Windows.Forms.View.Details;
            this.lvRecibos.SelectedIndexChanged += new System.EventHandler(this.lvRecibos_SelectedIndexChanged);
            this.lvRecibos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvRecibos_KeyDown);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cantidad";
            this.columnHeader7.Width = 89;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre(s)";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido Paterno";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido Materno";
            this.columnHeader3.Width = 98;
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.dtpFechaFin);
            this.grpFilter.Controls.Add(this.txtBuscar);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.dtpFechaIni);
            this.grpFilter.Controls.Add(this.chckFecha);
            this.grpFilter.Location = new System.Drawing.Point(50, 180);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(437, 72);
            this.grpFilter.TabIndex = 83;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filtrar";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 84;
            this.label5.Text = "Fecha final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 82;
            this.label3.Text = "Buscar:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(336, 38);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaFin.TabIndex = 83;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(3, 35);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(144, 23);
            this.txtBuscar.TabIndex = 81;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "Fecha Inicial";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(237, 38);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaIni.TabIndex = 81;
            this.dtpFechaIni.ValueChanged += new System.EventHandler(this.dtpFechaIni_ValueChanged);
            // 
            // chckFecha
            // 
            this.chckFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chckFecha.AutoSize = true;
            this.chckFecha.Depth = 0;
            this.chckFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckFecha.Location = new System.Drawing.Point(150, 29);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnDescartar);
            this.panel1.Location = new System.Drawing.Point(35, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 49);
            this.panel1.TabIndex = 84;
            // 
            // RecibosCredencialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lvRecibos);
            this.Name = "RecibosCredencialControl";
            this.Size = new System.Drawing.Size(539, 450);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvRecibos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnImprimir;
        private MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialFlatButton btnDescartar;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnNuevo;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialTextBox txtApMaterno;
        private MaterialTextBox txtApPaterno;
        private MaterialTextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListView lvRecibos;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private MaterialSkin.Controls.MaterialCheckBox chckFecha;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
    }
}