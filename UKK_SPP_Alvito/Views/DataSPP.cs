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

namespace UKK_SPP_Alvito.Views
{
    public partial class DataSPP : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        SqlDataAdapter sda;
        public DataSPP()
        {
            InitializeComponent();
        }

        private void DataSPP_Load(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            sda = new SqlDataAdapter("SELECT * FROM tb_spp", cn);
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
            cmd.CommandText = "select * from tb_spp";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            cn.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("Tahun like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select id_spp from tb_spp where id_spp = '" + textBox1.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (textBox1.Text == string.Empty || !dr.HasRows)
            {
                MessageBox.Show("Update Gagal !! Data Tidak Dapat Ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update [tb_spp] Set Tahun = '" + textBox2.Text + "', nominal = '" + textBox3.Text + "' where id_spp = '" + textBox1.Text + "'", cn);
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
            if (Validation())
            {
                SqlCommand cmd = new SqlCommand("Insert into [tb_spp] (tahun,nominal) values ('" + textBox2.Text + "','" + textBox3.Text + "')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Kolom Tahun Dan Nominal Harus Diisi!","Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand com = new SqlCommand("select id_spp from tb_spp where id_spp = '"+textBox1.Text+"'",cn);
            SqlDataReader dr = com.ExecuteReader();
            if (!dr.HasRows || textBox1.Text == "")
            {
                MessageBox.Show("Data Salah Atau Tidak Ada !!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tb_spp where id_spp = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refreshData();
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK);
                cn.Close();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_spp where id_spp = '" + textBox1.Text + "'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox2.Text = (string)dr["tahun"].ToString();
                    textBox3.Text = (string)dr["nominal"].ToString();
                }
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
            }
            cn.Close();
        }
    }
}
