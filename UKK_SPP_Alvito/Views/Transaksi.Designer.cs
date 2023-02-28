namespace UKK_SPP_Alvito.Views
{
    partial class Transaksi
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
            this.components = new System.ComponentModel.Container();
            this.tbpembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SPPDataSetTransaksi = new UKK_SPP_Alvito.DB_SPPDataSetTransaksi();
            this.tb_pembayaranTableAdapter = new UKK_SPP_Alvito.DB_SPPDataSetTransaksiTableAdapters.tb_pembayaranTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dB_SPPDataSetSPP = new UKK_SPP_Alvito.DB_SPPDataSetSPP();
            this.tbsppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_sppTableAdapter = new UKK_SPP_Alvito.DB_SPPDataSetSPPTableAdapters.tb_sppTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbsppBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nisnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbsiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SPPDataSetSiswa = new UKK_SPP_Alvito.DB_SPPDataSetSiswa();
            this.tbsiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_siswaTableAdapter = new UKK_SPP_Alvito.DB_SPPDataSetSiswaTableAdapters.tb_siswaTableAdapter();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbpembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetSPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsppBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetSiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsiswaBindingSource)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpembayaranBindingSource
            // 
            this.tbpembayaranBindingSource.DataMember = "tb_pembayaran";
            this.tbpembayaranBindingSource.DataSource = this.dB_SPPDataSetTransaksi;
            // 
            // dB_SPPDataSetTransaksi
            // 
            this.dB_SPPDataSetTransaksi.DataSetName = "DB_SPPDataSetTransaksi";
            this.dB_SPPDataSetTransaksi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_pembayaranTableAdapter
            // 
            this.tb_pembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halaman Transaksi";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(121, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(291, 26);
            this.textBox2.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Jumlah Bayar :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Bulan Dibayar :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Tahun Dibayar :";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "July",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBox1.Location = new System.Drawing.Point(121, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 28);
            this.comboBox1.TabIndex = 48;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(717, 208);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 57);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Tambahkan";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(717, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 57);
            this.button1.TabIndex = 51;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dB_SPPDataSetSPP
            // 
            this.dB_SPPDataSetSPP.DataSetName = "DB_SPPDataSetSPP";
            this.dB_SPPDataSetSPP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbsppBindingSource
            // 
            this.tbsppBindingSource.DataMember = "tb_spp";
            this.tbsppBindingSource.DataSource = this.dB_SPPDataSetSPP;
            // 
            // tb_sppTableAdapter
            // 
            this.tb_sppTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.DataSource = this.tbsppBindingSource1;
            this.comboBox2.DisplayMember = "tahun";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(291, 28);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.ValueMember = "id_spp";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tbsppBindingSource1
            // 
            this.tbsppBindingSource1.DataMember = "tb_spp";
            this.tbsppBindingSource1.DataSource = this.dB_SPPDataSetSPP;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 26);
            this.textBox1.TabIndex = 54;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "NISN               :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tanggal :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nisnDataGridViewTextBoxColumn,
            this.nisDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.idkelasDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbsiswaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(821, 131);
            this.dataGridView1.TabIndex = 57;
            // 
            // nisnDataGridViewTextBoxColumn
            // 
            this.nisnDataGridViewTextBoxColumn.DataPropertyName = "nisn";
            this.nisnDataGridViewTextBoxColumn.HeaderText = "nisn";
            this.nisnDataGridViewTextBoxColumn.Name = "nisnDataGridViewTextBoxColumn";
            this.nisnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nisDataGridViewTextBoxColumn
            // 
            this.nisDataGridViewTextBoxColumn.DataPropertyName = "nis";
            this.nisDataGridViewTextBoxColumn.HeaderText = "nis";
            this.nisDataGridViewTextBoxColumn.Name = "nisDataGridViewTextBoxColumn";
            this.nisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idkelasDataGridViewTextBoxColumn
            // 
            this.idkelasDataGridViewTextBoxColumn.DataPropertyName = "id_kelas";
            this.idkelasDataGridViewTextBoxColumn.HeaderText = "id_kelas";
            this.idkelasDataGridViewTextBoxColumn.Name = "idkelasDataGridViewTextBoxColumn";
            this.idkelasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "no_telp";
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            this.notelpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbsiswaBindingSource1
            // 
            this.tbsiswaBindingSource1.DataMember = "tb_siswa";
            this.tbsiswaBindingSource1.DataSource = this.dB_SPPDataSetSiswa;
            // 
            // dB_SPPDataSetSiswa
            // 
            this.dB_SPPDataSetSiswa.DataSetName = "DB_SPPDataSetSiswa";
            this.dB_SPPDataSetSiswa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbsiswaBindingSource
            // 
            this.tbsiswaBindingSource.DataMember = "tb_siswa";
            this.tbsiswaBindingSource.DataSource = this.dB_SPPDataSetSiswa;
            // 
            // tb_siswaTableAdapter
            // 
            this.tb_siswaTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(180, 337);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(207, 26);
            this.textBoxSearch.TabIndex = 59;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cari Berdasarkan Nama :";
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.textBox4);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.textBox3);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.comboBox2);
            this.panelForm.Controls.Add(this.dateTimePicker1);
            this.panelForm.Controls.Add(this.label13);
            this.panelForm.Controls.Add(this.textBox1);
            this.panelForm.Controls.Add(this.label11);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label14);
            this.panelForm.Controls.Add(this.textBox2);
            this.panelForm.Controls.Add(this.button1);
            this.panelForm.Controls.Add(this.comboBox1);
            this.panelForm.Controls.Add(this.buttonAdd);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(845, 280);
            this.panelForm.TabIndex = 60;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(121, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(291, 26);
            this.textBox4.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Dibayar          :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Kembalian :";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(508, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(168, 26);
            this.textBox3.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Daftar Siswa";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbpembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetSPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsppBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetSiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsiswaBindingSource)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_SPPDataSetTransaksi dB_SPPDataSetTransaksi;
        private System.Windows.Forms.BindingSource tbpembayaranBindingSource;
        private DB_SPPDataSetTransaksiTableAdapters.tb_pembayaranTableAdapter tb_pembayaranTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
        private DB_SPPDataSetSPP dB_SPPDataSetSPP;
        private System.Windows.Forms.BindingSource tbsppBindingSource;
        private DB_SPPDataSetSPPTableAdapters.tb_sppTableAdapter tb_sppTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource tbsppBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_SPPDataSetSiswa dB_SPPDataSetSiswa;
        private System.Windows.Forms.BindingSource tbsiswaBindingSource;
        private DB_SPPDataSetSiswaTableAdapters.tb_siswaTableAdapter tb_siswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tbsiswaBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
    }
}