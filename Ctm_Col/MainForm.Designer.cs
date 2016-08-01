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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Credencial");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Deducible");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Poliza");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Primer Ingreso");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Recibos", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Generar Pólizas");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Acciones", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Ajuste");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConcesionario = new System.Windows.Forms.Button();
            this.btnChofer = new System.Windows.Forms.Button();
            this.btnReciboCredencial = new System.Windows.Forms.Button();
            this.btnReciboDeducible = new System.Windows.Forms.Button();
            this.btnReciboPoliza = new System.Windows.Forms.Button();
            this.btnReciboPrimer = new System.Windows.Forms.Button();
            this.btnGenerarPoliza = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "Listo";
            // 
            // btnConcesionario
            // 
            this.btnConcesionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConcesionario.Location = new System.Drawing.Point(0, 0);
            this.btnConcesionario.Name = "btnConcesionario";
            this.btnConcesionario.Size = new System.Drawing.Size(108, 23);
            this.btnConcesionario.TabIndex = 0;
            this.btnConcesionario.Text = "Concesionario";
            this.btnConcesionario.UseVisualStyleBackColor = true;
            this.btnConcesionario.Click += new System.EventHandler(this.btnConcesionario_Click);
            // 
            // btnChofer
            // 
            this.btnChofer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChofer.Location = new System.Drawing.Point(0, 23);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(108, 23);
            this.btnChofer.TabIndex = 1;
            this.btnChofer.Text = "Chofer";
            this.btnChofer.UseVisualStyleBackColor = true;
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // btnReciboCredencial
            // 
            this.btnReciboCredencial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReciboCredencial.Location = new System.Drawing.Point(0, 46);
            this.btnReciboCredencial.Name = "btnReciboCredencial";
            this.btnReciboCredencial.Size = new System.Drawing.Size(108, 23);
            this.btnReciboCredencial.TabIndex = 2;
            this.btnReciboCredencial.Text = "Recibo Credencial";
            this.btnReciboCredencial.UseVisualStyleBackColor = true;
            this.btnReciboCredencial.Click += new System.EventHandler(this.btnReciboCredencial_Click);
            // 
            // btnReciboDeducible
            // 
            this.btnReciboDeducible.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReciboDeducible.Location = new System.Drawing.Point(0, 69);
            this.btnReciboDeducible.Name = "btnReciboDeducible";
            this.btnReciboDeducible.Size = new System.Drawing.Size(108, 23);
            this.btnReciboDeducible.TabIndex = 3;
            this.btnReciboDeducible.Text = "Recibo Deducible";
            this.btnReciboDeducible.UseVisualStyleBackColor = true;
            this.btnReciboDeducible.Click += new System.EventHandler(this.btnReciboDeducible_Click);
            // 
            // btnReciboPoliza
            // 
            this.btnReciboPoliza.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReciboPoliza.Location = new System.Drawing.Point(0, 92);
            this.btnReciboPoliza.Name = "btnReciboPoliza";
            this.btnReciboPoliza.Size = new System.Drawing.Size(108, 23);
            this.btnReciboPoliza.TabIndex = 4;
            this.btnReciboPoliza.Text = "Recibo Poliza";
            this.btnReciboPoliza.UseVisualStyleBackColor = true;
            this.btnReciboPoliza.Click += new System.EventHandler(this.btnReciboPoliza_Click);
            // 
            // btnReciboPrimer
            // 
            this.btnReciboPrimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReciboPrimer.Location = new System.Drawing.Point(0, 115);
            this.btnReciboPrimer.Name = "btnReciboPrimer";
            this.btnReciboPrimer.Size = new System.Drawing.Size(108, 23);
            this.btnReciboPrimer.TabIndex = 5;
            this.btnReciboPrimer.Text = "Recibo Primer Ingreso";
            this.btnReciboPrimer.UseVisualStyleBackColor = true;
            this.btnReciboPrimer.Click += new System.EventHandler(this.btnReciboPrimer_Click);
            // 
            // btnGenerarPoliza
            // 
            this.btnGenerarPoliza.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerarPoliza.Location = new System.Drawing.Point(0, 138);
            this.btnGenerarPoliza.Name = "btnGenerarPoliza";
            this.btnGenerarPoliza.Size = new System.Drawing.Size(108, 23);
            this.btnGenerarPoliza.TabIndex = 6;
            this.btnGenerarPoliza.Text = "Generar Poliza";
            this.btnGenerarPoliza.UseVisualStyleBackColor = true;
            this.btnGenerarPoliza.Click += new System.EventHandler(this.btnGenerarPoliza_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(0, 161);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node9";
            treeNode1.Text = "Node9";
            treeNode2.ImageIndex = -2;
            treeNode2.Name = "Node10";
            treeNode2.Text = "Node10";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Usuarios";
            treeNode4.Name = "Node11";
            treeNode4.Text = "Credencial";
            treeNode5.Name = "Node12";
            treeNode5.Text = "Deducible";
            treeNode6.Name = "Node14";
            treeNode6.Text = "Poliza";
            treeNode7.Name = "Node16";
            treeNode7.Text = "Primer Ingreso";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Recibos";
            treeNode9.Name = "Node17";
            treeNode9.Text = "Generar Pólizas";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Acciones";
            treeNode11.Name = "Node3";
            treeNode11.Text = "Ajuste";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode10,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(108, 69);
            this.treeView1.TabIndex = 7;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerarPoliza);
            this.splitContainer1.Panel1.Controls.Add(this.btnReciboPrimer);
            this.splitContainer1.Panel1.Controls.Add(this.btnReciboPoliza);
            this.splitContainer1.Panel1.Controls.Add(this.btnReciboDeducible);
            this.splitContainer1.Panel1.Controls.Add(this.btnReciboCredencial);
            this.splitContainer1.Panel1.Controls.Add(this.btnChofer);
            this.splitContainer1.Panel1.Controls.Add(this.btnConcesionario);
            this.splitContainer1.Size = new System.Drawing.Size(627, 728);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 728);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisionario";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnConcesionario;
        private System.Windows.Forms.Button btnChofer;
        private System.Windows.Forms.Button btnReciboCredencial;
        private System.Windows.Forms.Button btnReciboDeducible;
        private System.Windows.Forms.Button btnReciboPoliza;
        private System.Windows.Forms.Button btnReciboPrimer;
        private System.Windows.Forms.Button btnGenerarPoliza;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}