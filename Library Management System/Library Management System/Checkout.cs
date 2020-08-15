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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        public void InsertLend()
        {
            String date = txtMM.Text + "/" + txtdd.Text + "/" + txtyyyy.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Praneeth\Desktop\New folder\Register.mdf;Integrated Security=True;Connect Timeout=30");
            String insert = "insert into Lend (StudentID,Email,Contact,BookID,LendDate) values ('" + txtSid.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "','" + txtBookId.Text + "','" + date + "')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exInsert)
            {
                MessageBox.Show(exInsert.Message, "Error");
            }

            MessageBox.Show("Lending succesfull!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String date = txtMM.Text + "/" + txtdd.Text + "/" + txtyyyy.Text;
            try
            {
                date = Convert.ToDateTime(date).ToString("MM/dd/yyyy");
            }
            catch (Exception)
            {
                txtdd.Text = "";
                txtMM.Text = "";
                txtyyyy.Text = "";
                MessageBox.Show("Enter valid date type!", "Messege");
            }

            if (txtSid.Text == "" || txtEmail.Text == "" || txtContact.Text == "" || txtBookId.Text == "" || txtdd.Text == "" || txtMM.Text == "" || txtyyyy.Text == "")
            {
                MessageBox.Show("Please fill the all fields");
            }

            else
            {

                String email = txtSid.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Praneeth\Desktop\New folder\Register.mdf;Integrated Security=True;Connect Timeout=30");
                string stm = "SELECT COUNT(StudentID) FROM Lend WHERE StudentID = @SId";

                try
                {
                    conn.Open();
                    SqlCommand cmdCount = new SqlCommand(stm, conn);
                    cmdCount.Parameters.AddWithValue("@SId", email);
                    Int32 count = Convert.ToInt32(cmdCount.ExecuteScalar());
                    conn.Close();

                    switch (count)
                    {
                        case 0:
                            InsertLend();
                            TextClear();
                            break;
                        case 1:
                            InsertLend();
                            TextClear();
                            break;
                        case 2:
                            InsertLend();
                            TextClear();
                            break;

                        default:
                            MessageBox.Show("You already have lended 3 books");
                            TextClear();
                            break;
                    }

                }
                catch (Exception exCont)
                {
                    MessageBox.Show(exCont.Message, "Error");
                }

            }

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerDataSet1.Lend' table. You can move, or remove it, as needed.
            //this.lendTableAdapter.Fill(this.registerDataSet1.Lend);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ID = txtSearch.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Praneeth\Desktop\New folder\Register.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT LendDate FROM Lend WHERE BookID = @id";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {

                    DateTime firstDate = Convert.ToDateTime(da[0]);
                    DateTime secondDate = DateTime.Now;

                    TimeSpan diff = secondDate - firstDate;

                    int days = (((diff.Days * 24) * 3600) + (diff.Hours * 3600) + (diff.Minutes * 60) + (diff.Seconds)) / 100000;

                    if (days <= 14)
                    {
                        string message = "No fine for this book. Do you want to remove this lend?";
                        string title = "Return warning";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            ClearLend();
                            MessageBox.Show("Removing succesfull!", "Messege");
                        }

                    }
                    else
                    {
                        int payment = (days - 14) * 20;
                        string message = "Return day is expired. Fine is Rs." + int.Parse(payment.ToString()) + ". Do you want to proceed?";
                        string title = "Return worning";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            ClearLend();
                            MessageBox.Show("Removing succesfull!", "Messege");
                        }

                    }

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void ClearLend()
        {
            String ID = txtSearch.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Praneeth\Desktop\New folder\Register.mdf;Integrated Security=True;Connect Timeout=30");
            string DltQuery = "DELETE FROM Lend WHERE BookID = @id";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(DltQuery, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public void TextClear()
        {
            txtSid.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtBookId.Text = "";
            txtdd.Text = "";
            txtMM.Text = "";
            txtyyyy.Text = "";
        }
    }
}
