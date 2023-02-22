using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UKK_SPP_Alvito.Views
{
    public partial class Transaksi : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        SqlDataAdapter sda;
        public Transaksi()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SPPDataSetSiswa.tb_siswa' table. You can move, or remove it, as needed.
            this.tb_siswaTableAdapter.Fill(this.dB_SPPDataSetSiswa.tb_siswa);
            // TODO: This line of code loads data into the 'dB_SPPDataSetSPP.tb_spp' table. You can move, or remove it, as needed.
            this.tb_sppTableAdapter.Fill(this.dB_SPPDataSetSPP.tb_spp);
            // TODO: This line of code loads data into the 'dB_SPPDataSetTransaksi.tb_pembayaran' table. You can move, or remove it, as needed.
            this.tb_pembayaranTableAdapter.Fill(this.dB_SPPDataSetTransaksi.tb_pembayaran);
            validation();
            SqlConnection cn = conn.GetConn();
            sda = new SqlDataAdapter("select * from tb_siswa", cn);
            sda.Fill(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validation();
        }
        private void validation()
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select nisn from tb_siswa where nisn = @nisn", cn);
            cmd.Parameters.AddWithValue("@nisn", textBox1.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
            cn.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            SqlCommand cmd = new SqlCommand("Insert into [tb_pembayaran] (id_petugas,nisn,tgl_bayar,bulan_dibayar,tahun_dibayar,id_spp,jumlah_bayar) values ('" + Session.UserID + "','" + textBox1.Text + "','"+dateTimePicker1.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+comboBox2.SelectedValue+"','"+textBox2.Text+"')", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tambah Data Berhasil", "Berhasil", MessageBoxButtons.OK);
            refreshData();
            cn.Close();

        }
        public void refreshData()
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_pembayaran",cn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            cn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            SqlCommand cmd = new SqlCommand("select * from tb_spp where tahun = @tahun", cn);
            cmd.Parameters.AddWithValue("@tahun", textBox1.Text);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (comboBox2.ValueMember == row[1].ToString())
                {
                    textBox2.Text = row[2].ToString();
                }
                else
                {
                    textBox2.Text = "";
                }
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("nama like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
