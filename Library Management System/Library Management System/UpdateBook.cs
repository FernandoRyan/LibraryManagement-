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

namespace Library_Management_System
{
    public partial class UpdateBook : Form
    {
        System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Library System\Register.mdf';Integrated Security=True;Connect Timeout=30");

        public UpdateBook()
        {
            InitializeComponent();
        }
       

        private void Delete_UpdateBook_Load(object sender, EventArgs e)
        {
            dipBook();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int i;

            //Used to update the table 
            i = Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value.ToString());

            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books where ID="+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                foreach (DataRow dr in dt.Rows)
                {
                    BName.Text = dr["Name"].ToString();
                    Aname.Text = dr["Author"].ToString();
                    PubName.Text = dr["Publisher"].ToString();
                    dateTimePicker1.Text = dr["Purchase_date"].ToString();
                    BkPrice.Text = dr["Purchase_Price"].ToString();
                    Qty.Text = dr["Book_quantity"].ToString();
                }



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            conn.Close();


        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int i;

            //Used to update the table 
            i = Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value.ToString());
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Books set Name='" + BName.Text + "',Author='" + Aname.Text + "',Publisher='" + PubName.Text + "',Book_quantity='" + Qty.Text + "',Purchase_date='" + dateTimePicker1.Text + "',Purchase_Price='" + BkPrice.Text + "' where id='" + i + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dipBook();
                MessageBox.Show("Book Details sucesfully Updated!!");



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            conn.Close();
        }

      
        public void dipBook()
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

        private void button2_Click(object sender, EventArgs e)
        {
            int i;

            //Used to update the table 
            i = Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value.ToString());
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Books where id="+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dipBook();
                MessageBox.Show("Book Details Deleted Sucessfully");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            conn.Close();
        }
    }
}
