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
    public partial class Siswa : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        SqlDataAdapter sda;
        public Siswa()
        {
            InitializeComponent();
        }

        private void Siswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SPPDataSetKelas.tb_kelas' table. You can move, or remove it, as needed.
            this.tb_kelasTableAdapter.Fill(this.dB_SPPDataSetKelas.tb_kelas);
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select nisn,nis,nama,id_kelas,alamat,no_telp,password from tb_siswa",cn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

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
            cmd.CommandText = "select nisn,nis,nama,id_kelas,alamat,no_telp,password from tb_siswa";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            cn.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("nama like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select nisn from tb_siswa where nisn = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (Validation() && !dr.HasRows)
            {
                SqlCommand cmd = new SqlCommand("Insert into [tb_siswa] (nisn,nis,nama,password,alamat,id_kelas,no_telp) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedValue + "','"+textBox6.Text+"')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
            }
            else
            {
                MessageBox.Show("NISN Sudah Terdaftar","Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
                refreshData();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select nisn from tb_siswa where nisn = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if(!Validation() || !dr.HasRows)
            {
                MessageBox.Show("Tidak Boleh Ada Yang Kosong! Pastikan Semua Data Terisi Dengan Benar!","Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
            SqlCommand cmd = new SqlCommand("Update [tb_siswa] Set nisn = '" + textBox1.Text + "', nis = '" + textBox2.Text + "', nama = '"+textBox3.Text+"', password = '" + textBox4.Text + "', alamat = '" + textBox5.Text + "', no_telp = '" + textBox6.Text + "', id_kelas = '" + comboBox1.SelectedValue + "' where nisn = '" + textBox1.Text + "'", cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Data Berhasil", "berhasil", MessageBoxButtons.OK);
            refreshData();
            }
            cn.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select nisn from tb_siswa where nisn = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (!dr.HasRows || textBox1.Text == "")
            {
                MessageBox.Show("Data Salah Atau Tidak Ada !!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tb_siswa where nisn = '" + textBox1.Text + "'";
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
            SqlCommand cmd = new SqlCommand("select * from tb_siswa where nisn = '"+textBox1.Text+"'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox2.Text = (string)dr["nis"].ToString();
                    textBox3.Text = (string)dr["nama"].ToString();
                    textBox4.Text = (string)dr["password"].ToString();
                    textBox5.Text = (string)dr["alamat"].ToString();
                    textBox6.Text = (string)dr["no_telp"].ToString();
                }
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
