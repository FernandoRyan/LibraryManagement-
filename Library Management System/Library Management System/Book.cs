using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBooks book = new AddBooks();
            book.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBook  book = new UpdateBook();
            book.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {  
           Search book = new Search();
           book.Show();
        }

      
    }
}
