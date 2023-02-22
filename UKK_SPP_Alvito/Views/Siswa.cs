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
    public partial class Siswa : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        public Siswa()
        {
            InitializeComponent();
        }

        private void Siswa_Load(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            cn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_siswa",cn);
            sda.Fill(dt);
            dataGridView1.DataSource= dt;

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
            cmd.CommandText = "select * from tb_siswa";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
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
            if (Validation())
            {
                SqlCommand cmd = new SqlCommand("Insert into [tb_siswa] (nisn,nis,nama,username,password,alamat,id_kelas,no_telp) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.SelectedValue + "','"+textBox7.Text+"')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            foreach (TextBox txtbox in panelEdit.Controls.OfType<TextBox>())
            {
                if(txtbox.Text == string.Empty)
                {
                    MessageBox.Show("Tidak Boleh Ada Yang Kosong! Mohon Masukan Ulang Semua Data!","Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                SqlCommand cmd = new SqlCommand("Update [tb_siswa] Set nisn = '" + textBox1.Text + "', nis = '" + textBox2.Text + "', nama = '"+textBox3.Text+"', username = '"+textBox4.Text+"', password = '" + textBox5.Text + "', alamat = '" + textBox6.Text + "', no_telp = '" + textBox7.Text + "', id_kelas = '" + comboBox1.SelectedValue + "' where nisn = '" + textBox1.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Data Berhasil", "berhasil", MessageBoxButtons.OK);
                refreshData();
                cn.Close();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Mohon Masukan Data Yang Ingin Dihapus Berdasarkan NISN!", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cn = conn.GetConn();
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tb_siswa where nisn = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refreshData();
                cn.Close();
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
