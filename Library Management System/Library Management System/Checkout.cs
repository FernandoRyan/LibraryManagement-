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

        //load student details by student ID
        public void LoadStudentDetail()
        {
            String StudentId = txtSid.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Praneeth\Desktop\New folder\Register.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Fname,Lname,email,contact from LG where ID = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", StudentId);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                FnameLable.Text = da.GetValue(0).ToString();
                LnameLable.Text = da.GetValue(1).ToString();
                EmailLable.Text = da.GetValue(2).ToString();
                ContactLable.Text = da.GetValue(3).ToString();
            }
            conn.Close();




        }
        //load the gridviwe by student ID
        public void LoadGridviwe()
        {
            String StudentId = txtSid.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Praneeth\Desktop\New folder\Register.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select * from Lend where StudentId = @Id", con);
            cmd.Parameters.AddWithValue("@Id", StudentId);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DatagridViewLend.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //calling LoadStudent Function
            LoadStudentDetail();

            //calling Loadgideviwe function
            LoadGridviwe();
        }
    }
}
