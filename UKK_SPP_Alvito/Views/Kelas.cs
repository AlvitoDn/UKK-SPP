using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace UKK_SPP_Alvito.Views
{
    public partial class Kelas : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        public Kelas()
        {
            InitializeComponent();
        }

        private void Kelas_Load(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_kelas",cn);
            sda.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("nama_kelas like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
        public void refreshData()
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_kelas";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            cn.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("Tidak Boleh Ada Yang Kosong! Mohon Masukan Ulang Semua Data!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update [tb_kelas] Set nama_kelas = '" + textBox2.Text + "', jurusan = '" + textBox3.Text + "' where id_kelas = '" + textBox1.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            if (textBox2.Text != string.Empty || textBox3.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("Insert into [tb_kelas] (nama_kelas,jurusan) values ('" + textBox2.Text + "','" + textBox3.Text + "')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Kolom Nama Kelas Dan Jurusan Harus Diisi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Mohon Masukan Nama Yang Ingin Dihapus", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cn = conn.GetConn();
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tb_kelas where id_kelas = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refreshData();
                cn.Close();
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK);
            }
        }
    }
}
