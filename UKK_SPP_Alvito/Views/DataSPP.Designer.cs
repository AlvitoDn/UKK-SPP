namespace UKK_SPP_Alvito.Views
{
    partial class DataSPP
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tb_kelasTableAdapter = new UKK_SPP_Alvito.DB_SPPDataSetKelasTableAdapters.tb_kelasTableAdapter();
            this.tbkelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SPPDataSetKelas = new UKK_SPP_Alvito.DB_SPPDataSetKelas();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpetugasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SPPDataSetPetugas = new UKK_SPP_Alvito.DB_SPPDataSetPetugas();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbsppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SPPDataSetSPP = new UKK_SPP_Alvito.DB_SPPDataSetSPP();
            this.tb_petugasTableAdapter = new UKK_SPP_Alvito.DB_SPPDataSetPetugasTableAdapters.tb_petugasTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sppTableAdapter = new UKK_SPP_Alvito.DB_SPPDataSetSPPTableAdapters.tb_sppTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbkelasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetKelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpetugasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetPetugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetSPP)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(102, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(378, 26);
            this.textBox3.TabIndex = 17;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tb_kelasTableAdapter
            // 
            this.tb_kelasTableAdapter.ClearBeforeFill = true;
            // 
            // tbkelasBindingSource
            // 
            this.tbkelasBindingSource.DataMember = "tb_kelas";
            this.tbkelasBindingSource.DataSource = this.dB_SPPDataSetKelas;
            // 
            // dB_SPPDataSetKelas
            // 
            this.dB_SPPDataSetKelas.DataSetName = "DB_SPPDataSetKelas";
            this.dB_SPPDataSetKelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "List Data SPP";
            // 
            // tbpetugasBindingSource
            // 
            this.tbpetugasBindingSource.DataMember = "tb_petugas";
            this.tbpetugasBindingSource.DataSource = this.dB_SPPDataSetPetugas;
            // 
            // dB_SPPDataSetPetugas
            // 
            this.dB_SPPDataSetPetugas.DataSetName = "DB_SPPDataSetPetugas";
            this.dB_SPPDataSetPetugas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.idsppDataGridViewTextBoxColumn,
            this.tahunDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbsppBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 290);
            this.dataGridView1.TabIndex = 24;
            // 
            // idsppDataGridViewTextBoxColumn
            // 
            this.idsppDataGridViewTextBoxColumn.DataPropertyName = "id_spp";
            this.idsppDataGridViewTextBoxColumn.HeaderText = "id_spp";
            this.idsppDataGridViewTextBoxColumn.Name = "idsppDataGridViewTextBoxColumn";
            this.idsppDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tahunDataGridViewTextBoxColumn
            // 
            this.tahunDataGridViewTextBoxColumn.DataPropertyName = "tahun";
            this.tahunDataGridViewTextBoxColumn.HeaderText = "tahun";
            this.tahunDataGridViewTextBoxColumn.Name = "tahunDataGridViewTextBoxColumn";
            // 
            // nominalDataGridViewTextBoxColumn
            // 
            this.nominalDataGridViewTextBoxColumn.DataPropertyName = "nominal";
            this.nominalDataGridViewTextBoxColumn.HeaderText = "nominal";
            this.nominalDataGridViewTextBoxColumn.Name = "nominalDataGridViewTextBoxColumn";
            // 
            // tbsppBindingSource
            // 
            this.tbsppBindingSource.DataMember = "tb_spp";
            this.tbsppBindingSource.DataSource = this.dB_SPPDataSetSPP;
            // 
            // dB_SPPDataSetSPP
            // 
            this.dB_SPPDataSetSPP.DataSetName = "DB_SPPDataSetSPP";
            this.dB_SPPDataSetSPP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_petugasTableAdapter
            // 
            this.tb_petugasTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(498, 452);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 58);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID SPP :";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(498, 385);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(98, 58);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(102, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(602, 385);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 58);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tahun :";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(102, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(378, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nominal :";
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEdit.Controls.Add(this.textBox3);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.textBox2);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Location = new System.Drawing.Point(0, 417);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(483, 105);
            this.panelEdit.TabIndex = 27;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(329, 8);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(372, 26);
            this.textBoxSearch.TabIndex = 26;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Search :";
            // 
            // tb_sppTableAdapter
            // 
            this.tb_sppTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(498, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 34);
            this.button1.TabIndex = 47;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataSPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataSPP";
            this.Text = "DataSPP";
            this.Load += new System.EventHandler(this.DataSPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbkelasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetKelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpetugasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetPetugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SPPDataSetSPP)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private DB_SPPDataSetKelasTableAdapters.tb_kelasTableAdapter tb_kelasTableAdapter;
        private System.Windows.Forms.BindingSource tbkelasBindingSource;
        private DB_SPPDataSetKelas dB_SPPDataSetKelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tbpetugasBindingSource;
        private DB_SPPDataSetPetugas dB_SPPDataSetPetugas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_SPPDataSetPetugasTableAdapters.tb_petugasTableAdapter tb_petugasTableAdapter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private DB_SPPDataSetSPP dB_SPPDataSetSPP;
        private System.Windows.Forms.BindingSource tbsppBindingSource;
        private DB_SPPDataSetSPPTableAdapters.tb_sppTableAdapter tb_sppTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}