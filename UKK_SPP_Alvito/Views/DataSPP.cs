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

namespace UKK_SPP_Alvito.Views
{
    public partial class DataSPP : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        public DataSPP()
        {
            InitializeComponent();
        }

        private void DataSPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SPPDataSetSPP.tb_spp' table. You can move, or remove it, as needed.
            this.tb_sppTableAdapter.Fill(this.dB_SPPDataSetSPP.tb_spp);

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
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("Tidak Boleh Ada Yang Kosong! Mohon Masukan Ulang Semua Data!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update [tb_spp] Set Tahun = '" + textBox2.Text + "', nominal = '" + textBox3.Text + "' where id_spp = '" + textBox1.Text + "'", cn);
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
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Mohon Masukan Data Yang Ingin Dihapus Berdasarkan ID SPP!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cn = conn.GetConn();
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tb_spp where id_spp = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refreshData();
                cn.Close();
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK);
            }
        }
    }
}
