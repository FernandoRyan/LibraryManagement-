using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class Registraton : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Registraton()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (SID.Text == "" || Fnametxt.Text == "" || Lnametxt.Text == "" || emailtxt.Text == "" || contacttxt.Text == "" || pwtxt.Text == "")
                {
                    MessageBox.Show("Please fill the all fields");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Library System\Register.mdf';Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    String insert = "insert into LG (ID,Fname,Lname,email,contact,password) values ('" + SID.Text + "','" + Fnametxt.Text + "','" + Lnametxt.Text + "','" + emailtxt.Text + "','" + contacttxt.Text + "','" + pwtxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    las home = new las();
                    home.Show();
                    MessageBox.Show("Registration succesfull!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something wrong in registration {ex}");
            }



        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButtonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButtonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registraton_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
