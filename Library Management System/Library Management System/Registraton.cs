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

namespace Library_Management_System
{
    public partial class Registraton : Form
    {
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
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Git hub projects\LibraryManagement -\Library Management System\Library Management System\TestDB.mdf';Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    String insert = "insert into login (StudentID,Fname,Lname,email,contact,password) values ('" + SID.Text + "','" + Fnametxt.Text + "','" + Lnametxt.Text + "','" + emailtxt.Text + "','" + contacttxt.Text + "','" + pwtxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    las home = new las();
                    home.Show();
                    MessageBox.Show("Registration succesfull.!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something wrong in registration {ex}");
            }
           


        }
    }
}
