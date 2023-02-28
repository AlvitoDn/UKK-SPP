using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKK_SPP_Alvito.Views
{
    public partial class Laporan : Form
    {
        Koneksi conn = new Koneksi();
        Bitmap memoryImage;
        DataTable dt = new DataTable();
        SqlDataAdapter sda;
        public Laporan()
        {
            InitializeComponent();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {

        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = conn.GetConn();
            SqlCommand cmd = new SqlCommand("select * from tb_pembayaran where id_pembayaran = @id", cn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if(textBox1.Text == row[0].ToString())
                {
                    labelNisn.Text = row[2].ToString();
                    labelTanggal.Text = row[3].ToString();
                    labelBulan.Text = row[4].ToString();
                    labelTahun.Text = row[5].ToString();
                    labelJumlah.Text = row[7].ToString();
                }
                else
                {
                    labelNisn.Text = "";
                    labelTanggal.Text = "";
                    labelBulan.Text = "";
                    labelTahun.Text = "";
                    labelJumlah.Text = "";
                }
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
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
    }
}
