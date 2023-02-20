namespace UKK_SPP_Alvito.Views
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            this.panelNav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonFullscreen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonTrans = new System.Windows.Forms.Button();
            this.buttonSPP = new System.Windows.Forms.Button();
            this.buttonKelas = new System.Windows.Forms.Button();
            this.buttonSiswa = new System.Windows.Forms.Button();
            this.buttonPetugas = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonLaporan = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelNav.Controls.Add(this.label2);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Controls.Add(this.buttonMinimize);
            this.panelNav.Controls.Add(this.buttonFullscreen);
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Controls.Add(this.panel3);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1258, 43);
            this.panelNav.TabIndex = 0;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Silver;
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(1126, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(40, 27);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonFullscreen
            // 
            this.buttonFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFullscreen.BackColor = System.Drawing.Color.Silver;
            this.buttonFullscreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFullscreen.BackgroundImage")));
            this.buttonFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFullscreen.FlatAppearance.BorderSize = 0;
            this.buttonFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullscreen.Location = new System.Drawing.Point(1172, 0);
            this.buttonFullscreen.Name = "buttonFullscreen";
            this.buttonFullscreen.Size = new System.Drawing.Size(40, 27);
            this.buttonFullscreen.TabIndex = 1;
            this.buttonFullscreen.UseVisualStyleBackColor = false;
            this.buttonFullscreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Silver;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1218, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 27);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCollapse);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 43);
            this.panel3.TabIndex = 0;
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCollapse.BackgroundImage")));
            this.buttonCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCollapse.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCollapse.FlatAppearance.BorderSize = 0;
            this.buttonCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollapse.Location = new System.Drawing.Point(0, 0);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(53, 43);
            this.buttonCollapse.TabIndex = 0;
            this.buttonCollapse.UseVisualStyleBackColor = true;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelSide.Controls.Add(this.buttonLaporan);
            this.panelSide.Controls.Add(this.buttonLogout);
            this.panelSide.Controls.Add(this.buttonHistory);
            this.panelSide.Controls.Add(this.buttonTrans);
            this.panelSide.Controls.Add(this.buttonSPP);
            this.panelSide.Controls.Add(this.buttonKelas);
            this.panelSide.Controls.Add(this.buttonSiswa);
            this.panelSide.Controls.Add(this.buttonPetugas);
            this.panelSide.Controls.Add(this.buttonHome);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 43);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 745);
            this.panelSide.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(0, 680);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(183, 85);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Tag = "LOGOUT";
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonHistory.Image")));
            this.buttonHistory.Location = new System.Drawing.Point(0, 510);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(183, 85);
            this.buttonHistory.TabIndex = 9;
            this.buttonHistory.Tag = "HISTORY";
            this.buttonHistory.Text = "HISTORY";
            this.buttonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonTrans
            // 
            this.buttonTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTrans.FlatAppearance.BorderSize = 0;
            this.buttonTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrans.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrans.ForeColor = System.Drawing.Color.White;
            this.buttonTrans.Image = ((System.Drawing.Image)(resources.GetObject("buttonTrans.Image")));
            this.buttonTrans.Location = new System.Drawing.Point(0, 425);
            this.buttonTrans.Name = "buttonTrans";
            this.buttonTrans.Size = new System.Drawing.Size(183, 85);
            this.buttonTrans.TabIndex = 8;
            this.buttonTrans.Tag = "TRANSAKSI";
            this.buttonTrans.Text = "TRANSAKSI";
            this.buttonTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTrans.UseVisualStyleBackColor = true;
            this.buttonTrans.Click += new System.EventHandler(this.buttonTrans_Click);
            // 
            // buttonSPP
            // 
            this.buttonSPP.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSPP.FlatAppearance.BorderSize = 0;
            this.buttonSPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSPP.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSPP.ForeColor = System.Drawing.Color.White;
            this.buttonSPP.Image = ((System.Drawing.Image)(resources.GetObject("buttonSPP.Image")));
            this.buttonSPP.Location = new System.Drawing.Point(0, 340);
            this.buttonSPP.Name = "buttonSPP";
            this.buttonSPP.Size = new System.Drawing.Size(183, 85);
            this.buttonSPP.TabIndex = 7;
            this.buttonSPP.Tag = "DATA SPP";
            this.buttonSPP.Text = "DATA SPP";
            this.buttonSPP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSPP.UseVisualStyleBackColor = true;
            this.buttonSPP.Click += new System.EventHandler(this.buttonSPP_Click);
            // 
            // buttonKelas
            // 
            this.buttonKelas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKelas.FlatAppearance.BorderSize = 0;
            this.buttonKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKelas.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKelas.ForeColor = System.Drawing.Color.White;
            this.buttonKelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonKelas.Image")));
            this.buttonKelas.Location = new System.Drawing.Point(0, 255);
            this.buttonKelas.Name = "buttonKelas";
            this.buttonKelas.Size = new System.Drawing.Size(183, 85);
            this.buttonKelas.TabIndex = 6;
            this.buttonKelas.Tag = "KELAS";
            this.buttonKelas.Text = "KELAS";
            this.buttonKelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKelas.UseVisualStyleBackColor = true;
            this.buttonKelas.Click += new System.EventHandler(this.buttonKelas_Click);
            // 
            // buttonSiswa
            // 
            this.buttonSiswa.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSiswa.FlatAppearance.BorderSize = 0;
            this.buttonSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiswa.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiswa.ForeColor = System.Drawing.Color.White;
            this.buttonSiswa.Image = ((System.Drawing.Image)(resources.GetObject("buttonSiswa.Image")));
            this.buttonSiswa.Location = new System.Drawing.Point(0, 170);
            this.buttonSiswa.Name = "buttonSiswa";
            this.buttonSiswa.Size = new System.Drawing.Size(183, 85);
            this.buttonSiswa.TabIndex = 5;
            this.buttonSiswa.Tag = "SISWA";
            this.buttonSiswa.Text = "SISWA";
            this.buttonSiswa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSiswa.UseVisualStyleBackColor = true;
            this.buttonSiswa.Click += new System.EventHandler(this.buttonSiswa_Click);
            // 
            // buttonPetugas
            // 
            this.buttonPetugas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPetugas.FlatAppearance.BorderSize = 0;
            this.buttonPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPetugas.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPetugas.ForeColor = System.Drawing.Color.White;
            this.buttonPetugas.Image = ((System.Drawing.Image)(resources.GetObject("buttonPetugas.Image")));
            this.buttonPetugas.Location = new System.Drawing.Point(0, 85);
            this.buttonPetugas.Name = "buttonPetugas";
            this.buttonPetugas.Size = new System.Drawing.Size(183, 85);
            this.buttonPetugas.TabIndex = 4;
            this.buttonPetugas.Tag = "PETUGAS";
            this.buttonPetugas.Text = "PETUGAS";
            this.buttonPetugas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPetugas.UseVisualStyleBackColor = true;
            this.buttonPetugas.Click += new System.EventHandler(this.buttonPetugas_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(183, 85);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Tag = "HOME";
            this.buttonHome.Text = "HOME";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 43);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1058, 745);
            this.panelMain.TabIndex = 2;
            // 
            // buttonLaporan
            // 
            this.buttonLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLaporan.FlatAppearance.BorderSize = 0;
            this.buttonLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaporan.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaporan.ForeColor = System.Drawing.Color.White;
            this.buttonLaporan.Image = ((System.Drawing.Image)(resources.GetObject("buttonLaporan.Image")));
            this.buttonLaporan.Location = new System.Drawing.Point(0, 595);
            this.buttonLaporan.Name = "buttonLaporan";
            this.buttonLaporan.Size = new System.Drawing.Size(183, 85);
            this.buttonLaporan.TabIndex = 11;
            this.buttonLaporan.Tag = "HISTORY";
            this.buttonLaporan.Text = "LAPORAN";
            this.buttonLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLaporan.UseVisualStyleBackColor = true;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 788);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelNav);
            this.Name = "Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APP SPP";
            this.Load += new System.EventHandler(this.Layout_Load);
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button buttonFullscreen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonTrans;
        private System.Windows.Forms.Button buttonSPP;
        private System.Windows.Forms.Button buttonKelas;
        private System.Windows.Forms.Button buttonSiswa;
        private System.Windows.Forms.Button buttonPetugas;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLaporan;
    }
}