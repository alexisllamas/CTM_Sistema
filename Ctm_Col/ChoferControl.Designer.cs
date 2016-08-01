namespace Ctm_Col
{
    partial class ChoferControl
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
            this.btnCredencial = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReciboCredencial = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lvChoferes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtConNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConMunicipio = new System.Windows.Forms.ComboBox();
            this.grpboxCredencial = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAccidentes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReciboDeducible = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtLicencia = new Ctm_Col.MaterialTextBox();
            this.txtNombre = new Ctm_Col.MaterialTextBox();
            this.txtApPaterno = new Ctm_Col.MaterialTextBox();
            this.txtApMaterno = new Ctm_Col.MaterialTextBox();
            this.txtConTelefono = new Ctm_Col.MaterialTextBox();
            this.txtConCalle = new Ctm_Col.MaterialTextBox();
            this.txtConColonia = new Ctm_Col.MaterialTextBox();
            this.txtConId = new Ctm_Col.MaterialTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpboxCredencial.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCredencial
            // 
            this.btnCredencial.Depth = 0;
            this.btnCredencial.Location = new System.Drawing.Point(11, 65);
            this.btnCredencial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCredencial.Name = "btnCredencial";
            this.btnCredencial.Primary = true;
            this.btnCredencial.Size = new System.Drawing.Size(174, 23);
            this.btnCredencial.TabIndex = 80;
            this.btnCredencial.Text = "Credencial";
            this.btnCredencial.UseVisualStyleBackColor = true;
            this.btnCredencial.Click += new System.EventHandler(this.btnCredencial_Click);
            // 
            // btnReciboCredencial
            // 
            this.btnReciboCredencial.Depth = 0;
            this.btnReciboCredencial.Location = new System.Drawing.Point(11, 19);
            this.btnReciboCredencial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReciboCredencial.Name = "btnReciboCredencial";
            this.btnReciboCredencial.Primary = true;
            this.btnReciboCredencial.Size = new System.Drawing.Size(174, 23);
            this.btnReciboCredencial.TabIndex = 79;
            this.btnReciboCredencial.Text = "Recibos";
            this.btnReciboCredencial.UseVisualStyleBackColor = true;
            this.btnReciboCredencial.Click += new System.EventHandler(this.btnReciboCredencial_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(89, 286);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(84, 36);
            this.btnActualizar.TabIndex = 78;
            this.btnActualizar.Text = "Modificar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(189, 286);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = false;
            this.btnNuevo.Size = new System.Drawing.Size(57, 36);
            this.btnNuevo.TabIndex = 77;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(360, 286);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 76;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(262, 286);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 36);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 74;
            this.label3.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(2, 453);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(144, 23);
            this.txtBuscar.TabIndex = 68;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lvChoferes
            // 
            this.lvChoferes.AllowColumnReorder = true;
            this.lvChoferes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader6,
            this.columnHeader5});
            this.lvChoferes.FullRowSelect = true;
            this.lvChoferes.GridLines = true;
            this.lvChoferes.Location = new System.Drawing.Point(5, 500);
            this.lvChoferes.MultiSelect = false;
            this.lvChoferes.Name = "lvChoferes";
            this.lvChoferes.Size = new System.Drawing.Size(611, 147);
            this.lvChoferes.TabIndex = 67;
            this.lvChoferes.UseCompatibleStateImageBehavior = false;
            this.lvChoferes.View = System.Windows.Forms.View.Details;
            this.lvChoferes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvChoferes_ColumnClick);
            this.lvChoferes.SelectedIndexChanged += new System.EventHandler(this.lvChoferes_SelectedIndexChanged);
            this.lvChoferes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvChoferes_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombres";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido Paterno";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellido Materno";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Municipio";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Teléfono";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Licencia";
            this.columnHeader5.Width = 123;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtApPaterno);
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.txtApMaterno);
            this.groupBox2.Controls.Add(this.dtConNacimiento);
            this.groupBox2.Location = new System.Drawing.Point(51, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 73);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Enabled = false;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(372, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 12);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // dtConNacimiento
            // 
            this.dtConNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtConNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConNacimiento.Location = new System.Drawing.Point(374, 34);
            this.dtConNacimiento.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtConNacimiento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtConNacimiento.Name = "dtConNacimiento";
            this.dtConNacimiento.Size = new System.Drawing.Size(101, 20);
            this.dtConNacimiento.TabIndex = 5;
            this.dtConNacimiento.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConTelefono);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConCalle);
            this.groupBox1.Controls.Add(this.txtConColonia);
            this.groupBox1.Controls.Add(this.cmbConMunicipio);
            this.groupBox1.Location = new System.Drawing.Point(51, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 97);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Municipio";
            // 
            // cmbConMunicipio
            // 
            this.cmbConMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConMunicipio.FormattingEnabled = true;
            this.cmbConMunicipio.Items.AddRange(new object[] {
            "Armería",
            "Colima",
            "Comala",
            "Coquimatlán",
            "Cuauhtémoc",
            "Ixtlahuacán",
            "Manzanillo",
            "Minatitlán",
            "Tecomán",
            "Villa de Alvarez"});
            this.cmbConMunicipio.Location = new System.Drawing.Point(357, 38);
            this.cmbConMunicipio.Name = "cmbConMunicipio";
            this.cmbConMunicipio.Size = new System.Drawing.Size(121, 21);
            this.cmbConMunicipio.TabIndex = 9;
            // 
            // grpboxCredencial
            // 
            this.grpboxCredencial.Controls.Add(this.btnCredencial);
            this.grpboxCredencial.Controls.Add(this.btnReciboCredencial);
            this.grpboxCredencial.Location = new System.Drawing.Point(27, 331);
            this.grpboxCredencial.Name = "grpboxCredencial";
            this.grpboxCredencial.Size = new System.Drawing.Size(200, 100);
            this.grpboxCredencial.TabIndex = 82;
            this.grpboxCredencial.TabStop = false;
            this.grpboxCredencial.Text = "Credencial";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAccidentes);
            this.groupBox3.Controls.Add(this.btnReciboDeducible);
            this.groupBox3.Location = new System.Drawing.Point(326, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deducible";
            // 
            // btnAccidentes
            // 
            this.btnAccidentes.Depth = 0;
            this.btnAccidentes.Location = new System.Drawing.Point(11, 65);
            this.btnAccidentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccidentes.Name = "btnAccidentes";
            this.btnAccidentes.Primary = true;
            this.btnAccidentes.Size = new System.Drawing.Size(174, 23);
            this.btnAccidentes.TabIndex = 80;
            this.btnAccidentes.Text = "Accidentes";
            this.btnAccidentes.UseVisualStyleBackColor = true;
            // 
            // btnReciboDeducible
            // 
            this.btnReciboDeducible.Depth = 0;
            this.btnReciboDeducible.Location = new System.Drawing.Point(11, 19);
            this.btnReciboDeducible.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReciboDeducible.Name = "btnReciboDeducible";
            this.btnReciboDeducible.Primary = true;
            this.btnReciboDeducible.Size = new System.Drawing.Size(174, 23);
            this.btnReciboDeducible.TabIndex = 79;
            this.btnReciboDeducible.Text = "Recibos";
            this.btnReciboDeducible.UseVisualStyleBackColor = true;
            this.btnReciboDeducible.Click += new System.EventHandler(this.btnReciboDeducible_Click);
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(282, 17);
            this.txtLicencia.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtLicencia.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Placeholder = "Licencia";
            this.txtLicencia.Size = new System.Drawing.Size(0, 32);
            this.txtLicencia.TabIndex = 81;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(-4, 19);
            this.txtNombre.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtNombre.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Placeholder = "Nombre(s)";
            this.txtNombre.Size = new System.Drawing.Size(0, 32);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(128, 19);
            this.txtApPaterno.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtApPaterno.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Placeholder = "Apellido Paterno";
            this.txtApPaterno.Size = new System.Drawing.Size(122, 32);
            this.txtApPaterno.TabIndex = 3;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(250, 19);
            this.txtApMaterno.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtApMaterno.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Placeholder = "Apellido Materno";
            this.txtApMaterno.Size = new System.Drawing.Size(0, 32);
            this.txtApMaterno.TabIndex = 4;
            // 
            // txtConTelefono
            // 
            this.txtConTelefono.Location = new System.Drawing.Point(268, 19);
            this.txtConTelefono.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtConTelefono.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtConTelefono.Name = "txtConTelefono";
            this.txtConTelefono.Placeholder = "Teléfono";
            this.txtConTelefono.Size = new System.Drawing.Size(0, 32);
            this.txtConTelefono.TabIndex = 7;
            // 
            // txtConCalle
            // 
            this.txtConCalle.Location = new System.Drawing.Point(7, 19);
            this.txtConCalle.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtConCalle.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtConCalle.Name = "txtConCalle";
            this.txtConCalle.Placeholder = "Calle y número";
            this.txtConCalle.Size = new System.Drawing.Size(0, 32);
            this.txtConCalle.TabIndex = 6;
            // 
            // txtConColonia
            // 
            this.txtConColonia.Location = new System.Drawing.Point(162, 19);
            this.txtConColonia.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtConColonia.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtConColonia.Name = "txtConColonia";
            this.txtConColonia.Placeholder = "Colonia";
            this.txtConColonia.Size = new System.Drawing.Size(0, 32);
            this.txtConColonia.TabIndex = 8;
            // 
            // txtConId
            // 
            this.txtConId.Enabled = false;
            this.txtConId.Location = new System.Drawing.Point(58, 17);
            this.txtConId.MaximumSize = new System.Drawing.Size(0, 32);
            this.txtConId.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtConId.Name = "txtConId";
            this.txtConId.Placeholder = "Id";
            this.txtConId.Size = new System.Drawing.Size(0, 32);
            this.txtConId.TabIndex = 73;
            this.txtConId.Text = "3";
            // 
            // ChoferControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpboxCredencial);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lvChoferes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConId);
            this.Name = "ChoferControl";
            this.Size = new System.Drawing.Size(627, 660);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvChoferes_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboxCredencial.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCredencial;
        private MaterialSkin.Controls.MaterialRaisedButton btnReciboCredencial;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnNuevo;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.ListView lvChoferes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialTextBox txtNombre;
        private MaterialTextBox txtApPaterno;
        private System.Windows.Forms.Label lblFecha;
        private MaterialTextBox txtApMaterno;
        private System.Windows.Forms.DateTimePicker dtConNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialTextBox txtConTelefono;
        private System.Windows.Forms.Label label1;
        private MaterialTextBox txtConCalle;
        private MaterialTextBox txtConColonia;
        private System.Windows.Forms.ComboBox cmbConMunicipio;
        private MaterialTextBox txtConId;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialTextBox txtLicencia;
        private System.Windows.Forms.GroupBox grpboxCredencial;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRaisedButton btnAccidentes;
        private MaterialSkin.Controls.MaterialRaisedButton btnReciboDeducible;
    }
}