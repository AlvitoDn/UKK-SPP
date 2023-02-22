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
    public partial class History : Form
    {
        Koneksi con = new Koneksi();
        DataTable dt = new DataTable();
        SqlDataAdapter sda;
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            SqlConnection cn = con.GetConn();
            if (Session.UserClass == "siswa")
            {
                SqlCommand cmd = new SqlCommand("select tgl_bayar,bulan_dibayar,tahun_dibayar,jumlah_bayar from tb_pembayaran where nisn = @nisn",cn);
                cmd.Parameters.AddWithValue("@nisn", Session.NISN);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                label1.Hide();
                textBoxSearch.Hide();
            }
            else
            {
                sda = new SqlDataAdapter("select * from tb_pembayaran",cn);
                sda.Fill(dt);
                dataGridView1.DataSource = dt; 
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("nisn like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
