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
    public partial class Petugas : Form
    {
        Koneksi conn = new Koneksi();
        SqlDataAdapter sda;
        DataTable dt = new DataTable();
        public Petugas()
        {
            InitializeComponent();
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            sda = new SqlDataAdapter("SELECT * FROM tb_petugas",cn);
            sda.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Enter)
            {
                this.textBox2.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBox3.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBox4.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.comboBox1.Focus();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("nama_petugas like '%{0}%'", textBoxSearch.Text);
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
            cmd.CommandText = "select * from tb_petugas";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            cn.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            if (Validation())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from tb_petugas where username = @username", cn);
                cmd.Parameters.AddWithValue("@username", textBox3.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    MessageBox.Show("Username Sudah Dipakai Oleh Pengguna Lain, Harap Masukan Username Yang Berbeda !","Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Insert into [tb_petugas] (nama_petugas,username,password,level) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", cn);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Tambah Data Berhasil", "berhasil", MessageBoxButtons.OK);
                    refreshData();
                    cn.Close();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select id_petugas from tb_petugas where id_petugas = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (textBox1.Text == string.Empty || !dr.HasRows)
            {
                MessageBox.Show("Update Gagal! Mohon Masukan ID Petugas Yang Ingin Anda Update Dengan Benar", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update [tb_petugas] Set nama_petugas = '" + textBox2.Text + "', username = '" + textBox3.Text + "', password = '" + textBox4.Text + "', level = '" + comboBox1.Text + "' where id_petugas = '" + textBox1.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select id_petugas from tb_petugas where id_petugas = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (!dr.HasRows || textBox1.Text == "")
            {
                MessageBox.Show("Data Salah Atau Tidak Ada !!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tb_petugas where id_petugas = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refreshData();
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK);
                cn.Close();
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_petugas where id_petugas = '" + textBox1.Text + "'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox2.Text = (string)dr["nama_petugas"].ToString();
                    textBox3.Text = (string)dr["username"].ToString();
                    textBox4.Text = (string)dr["password"].ToString();
                    comboBox1.Text = (string)dr["level"].ToString();
                }
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
