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
using UKK_SPP_Alvito.Views;

namespace UKK_SPP_Alvito
{
    public partial class Login : Form
    {
        Layout lay = new Layout();
        Koneksi con = new Koneksi();
        public Login()
        {
            InitializeComponent();
            this.textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = con.GetConn();
            conn.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Mohon Masukan Username Atau Password Dengan Benar!!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from tb_petugas where username = @username", conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from tb_petugas where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr["level"].ToString() == "admin")
                            {
                                this.Hide();
                                Session.UserID = "admin";
                                Session.UserName = (string)dr["nama_petugas"];
                                lay.Show();
                            }
                            else if (dr["level"].ToString() == "petugas")
                            {
                                this.Hide();
                                Session.UserID = "petugas";
                                Session.UserName = (string)dr["nama_petugas"];
                                lay.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password Salah!!");
                    }
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from tb_siswa where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            this.Hide();
                            Session.UserID = "siswa";
                            Session.UserName = (string)dr["nama"];
                            lay.Show();
                        }
                    }
                }
            }
            conn.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
