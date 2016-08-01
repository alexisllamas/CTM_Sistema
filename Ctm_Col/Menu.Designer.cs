namespace Ctm_Col
{
    partial class Menu
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
            this.navBar1 = new Ctm_Col.NavBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.concesionarioControl1 = new Ctm_Col.ConcesionarioControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.navBar1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar1
            // 
            this.navBar1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.navBar1.Controls.Add(this.tabPage1);
            this.navBar1.Controls.Add(this.tabPage2);
            this.navBar1.Controls.Add(this.tabPage3);
            this.navBar1.Controls.Add(this.tabPage4);
            this.navBar1.Controls.Add(this.tabPage5);
            this.navBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBar1.ItemSize = new System.Drawing.Size(30, 120);
            this.navBar1.Location = new System.Drawing.Point(0, 0);
            this.navBar1.Multiline = true;
            this.navBar1.Name = "navBar1";
            this.navBar1.SelectedIndex = 0;
            this.navBar1.Size = new System.Drawing.Size(799, 443);
            this.navBar1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.navBar1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.concesionarioControl1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "primera";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // concesionarioControl1
            // 
            this.concesionarioControl1.BackColor = System.Drawing.Color.White;
            this.concesionarioControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concesionarioControl1.Location = new System.Drawing.Point(3, 3);
            this.concesionarioControl1.Name = "concesionarioControl1";
            this.concesionarioControl1.Size = new System.Drawing.Size(665, 429);
            this.concesionarioControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage2.Location = new System.Drawing.Point(124, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "segunda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage3.Location = new System.Drawing.Point(124, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(671, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage4.Location = new System.Drawing.Point(124, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(671, 435);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage5.Location = new System.Drawing.Point(124, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(671, 435);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 443);
            this.Controls.Add(this.navBar1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.navBar1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private NavBar navBar1;
        private System.Windows.Forms.TabPage tabPage1;
        private ConcesionarioControl concesionarioControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}