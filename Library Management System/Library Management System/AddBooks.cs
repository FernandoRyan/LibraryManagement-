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
using System.Linq.Expressions;

namespace Library_Management_System
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
              
                
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Library System\Register.mdf';Integrated Security=True;Connect Timeout=30");

                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " insert into Books(Name,Author,Publisher,Book_quantity,Purchase_date,Purchase_Price)  values('" + Bname.Text + "', '" + AName.Text + "', '" + Publsiher.Text + "'," + Quan.Text + ",'"+ dateTimePicker1.Text+"',"+ Price .Text+ ")";
                    cmd.ExecuteNonQuery();

                    Bname.Text = "";
                    AName.Text = "";
                    Publsiher.Text = "";
                    Quan.Text = "";
                    Price.Text = "";


                    MessageBox.Show("The Book has being added to the shelfs");

                    conn.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"The Book failed to be added due to error {ex}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }
    }
}
