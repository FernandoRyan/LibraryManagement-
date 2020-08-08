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
    public partial class Add_new_Book : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Library System\Register.mdf';Integrated Security=True;Connect Timeout=30");
        public Add_new_Book()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bname.Text == "" || AuthorN.Text == "" || PubN.Text == "" || Quantity.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please fill the all fields");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Books values('" + Bname.Text + "','" + AuthorN.Text + "','" + PubN.Text + "'," + Quantity.Text + ",'" + dateTimePicker1.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The insertion Sucessful");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error occured during insetion!! {ex}");
            }
                Bname.Text = "";
                AuthorN.Text = "";
                PubN.Text = "";
                Quantity.Text = "";
               

                
                conn.Close();
            




        }

       
    }
}
