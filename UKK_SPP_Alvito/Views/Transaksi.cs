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
using TextBox = System.Windows.Forms.TextBox;

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
            this.tb_sppTableAdapter.Fill(this.dB_SPPDataSetSPP.tb_spp);
            this.tb_pembayaranTableAdapter.Fill(this.dB_SPPDataSetTransaksi.tb_pembayaran);
            validation();
            SqlConnection cn = conn.GetConn();
            sda = new SqlDataAdapter("select * from tb_siswa", cn);
            sda.Fill(dt);
            dataGridView1.DataSource= dt;
            cn.Close();
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

        private bool Validation()
        {
            foreach (TextBox txtbox in panelForm.Controls.OfType<TextBox>())
            {
                if (txtbox.Text == string.Empty)
                {
                    MessageBox.Show("Tidak Boleh Ada Data Yang Kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            if (Validation())
            {
            SqlCommand cmd = new SqlCommand("Insert into [tb_pembayaran] (id_petugas,nisn,tgl_bayar,bulan_dibayar,tahun_dibayar,id_spp,jumlah_bayar) values ('" + Session.UserID + "','" + textBox1.Text + "','"+dateTimePicker1.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+comboBox2.SelectedValue+"','"+textBox2.Text+"')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tambah Data Berhasil", "Berhasil", MessageBoxButtons.OK);
            refreshData();
            cn.Close();
            }

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
            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from tb_spp where tahun = '"+comboBox2.Text+"'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string jumlah = (string)dr[2].ToString();
                textBox2.Text = jumlah;
            }
            cn.Close();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("nama like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }
    }
}
