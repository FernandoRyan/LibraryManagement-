using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(59, 67, 214);
            public static Color color2 = Color.FromArgb(212, 112, 61);
            public static Color color3 = Color.FromArgb(167, 183, 90);
            public static Color color4 = Color.FromArgb(221, 52, 57);
            public static Color color5 = Color.FromArgb(0, 128, 128);
            public static Color color6 = Color.FromArgb(212, 235, 208);
            public static Color color7 = Color.FromArgb(77, 62, 62);

        }
        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Currentchildform
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            // open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            // End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Desktoppanel.Controls.Add(childForm);
            Desktoppanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitlechildform.Text = childForm.Text;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Dashboard());
            Dashboard registraton = new Dashboard();
            registraton.Show();

        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Account());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Registraton());
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Book());
        }

        /*private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new SReport());
        }     */

        private void btnNews_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Checkout());
        }

      

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            las nw = new las();
            nw.Show();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitlechildform.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       

        private void iconButtonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Dashboard icons
       

        private void iconButtonAcc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account());
        }

        private void iconButtonBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Book());
        }

    

        private void iconButtoncheckout_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new Checkout());
        }

     

     
        private void iconButtonNews_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Registraton());
        }

     

      

     
    

      /*  private void iconButtonReport_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new SReport());
        }
             */
        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            las registraton = new las();
            registraton.Show();
        }

        private void pictureBoxacc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account());
        }

        private void pictureBoxbook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Book());

        }

        private void pictureBoxCheckout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Checkout());
        }

        private void pictureBoxNews_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Registraton());
        }

      

       /* private void pictureBoxReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SReport());
        }          */

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            MessageBox.Show("You are now logged out");
        }
    }
}
