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
    public partial class Search : Form
    {

        // Setting connection 
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Library System\Register.mdf';Integrated Security=True;Connect Timeout=30");
        public Search()
        {
            InitializeComponent();
        }

        //Data grid view 
        private void Search_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                bunifuDataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        //New Sectiion

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books where Name like('%" + bunifuTextBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                bunifuDataGridView1.DataSource = dt;

                if (i == 0)
                {
                    MessageBox.Show("The Book is not found");
                }



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }

      

        //Second search by authur
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books where Author like('%" + bunifuTextBox2.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                bunifuDataGridView1.DataSource = dt;

                if (i == 0)
                {
                    MessageBox.Show("The Book is not found");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }

        private void bunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books where Name like('%" + bunifuTextBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                bunifuDataGridView1.DataSource = dt;

                if (i == 0)
                {
                    MessageBox.Show("The Book is not found");
                }



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            conn.Close();

        }

        private void bunifuTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books where Author like('%" + bunifuTextBox2.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                bunifuDataGridView1.DataSource = dt;

                if (i == 0)
                {
                    MessageBox.Show("The Book is not found");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }
    }
}
