using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        SqlDataAdapter sda;
        public Kelas()
        {
            InitializeComponent();
        }

        private void Kelas_Load(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_kelas",cn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("nama_kelas like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
        private bool Validation()
        {
            foreach (TextBox txtbox in panelEdit.Controls.OfType<TextBox>())
            {
                if (txtbox.Text == string.Empty)
                {
                    MessageBox.Show("Tidak Boleh Ada Data Yang Kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
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
            cn.Open();
            SqlCommand com = new SqlCommand("select id_kelas from tb_kelas where id_kelas = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (!Validation()|| !dr.HasRows)
            {
                MessageBox.Show("Tidak Boleh Ada Yang Kosong! Pastikan Semua Data Terisi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update [tb_kelas] Set nama_kelas = '" + textBox2.Text + "', jurusan = '" + textBox3.Text + "' where id_kelas = '" + textBox1.Text + "'", cn);
                cmd.CommandType = CommandType.Text;


                 cmd.ExecuteNonQuery();
                MessageBox.Show("Update Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            if (Validation() && textBox1.Text == "")
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
                MessageBox.Show("Kosongi Kolom ID!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select id_kelas from tb_kelas where id_kelas = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (!dr.HasRows || textBox1.Text == "")
            {
                MessageBox.Show("Data Salah Atau Tidak Ada !!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tb_kelas where id_kelas = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refreshData();
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK);
                cn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_kelas where id_kelas = '" + textBox1.Text + "'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox2.Text = (string)dr["nama_kelas"].ToString();
                    textBox3.Text = (string)dr["jurusan"].ToString();
                }
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
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
