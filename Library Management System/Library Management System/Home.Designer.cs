﻿namespace Library_Management_System
{
    partial class las
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(las));
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.iconButtonMax = new FontAwesome.Sharp.IconButton();
            this.iconButtonclose = new FontAwesome.Sharp.IconButton();
            this.iconButtonMin = new FontAwesome.Sharp.IconButton();
            this.lblTitlechildform = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.Desktoppanel = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnBook = new FontAwesome.Sharp.IconButton();
            this.btnCheckout = new FontAwesome.Sharp.IconButton();
            this.btnNews = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnCompetition = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTitlebar.SuspendLayout();
            this.Desktoppanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(158)))), ((int)(((byte)(73)))));
            this.panelTitlebar.Controls.Add(this.iconButtonMax);
            this.panelTitlebar.Controls.Add(this.iconButtonclose);
            this.panelTitlebar.Controls.Add(this.iconButtonMin);
            this.panelTitlebar.Controls.Add(this.lblTitlechildform);
            this.panelTitlebar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(200, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(694, 32);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // iconButtonMax
            // 
            this.iconButtonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMax.FlatAppearance.BorderSize = 0;
            this.iconButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMax.IconColor = System.Drawing.Color.White;
            this.iconButtonMax.IconSize = 21;
            this.iconButtonMax.Location = new System.Drawing.Point(624, 3);
            this.iconButtonMax.Name = "iconButtonMax";
            this.iconButtonMax.Rotation = 0D;
            this.iconButtonMax.Size = new System.Drawing.Size(32, 22);
            this.iconButtonMax.TabIndex = 4;
            this.iconButtonMax.UseVisualStyleBackColor = true;
            this.iconButtonMax.Click += new System.EventHandler(this.iconButtonMax_Click);
            // 
            // iconButtonclose
            // 
            this.iconButtonclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonclose.FlatAppearance.BorderSize = 0;
            this.iconButtonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonclose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonclose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonclose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonclose.IconColor = System.Drawing.Color.White;
            this.iconButtonclose.IconSize = 21;
            this.iconButtonclose.Location = new System.Drawing.Point(659, 6);
            this.iconButtonclose.Name = "iconButtonclose";
            this.iconButtonclose.Rotation = 0D;
            this.iconButtonclose.Size = new System.Drawing.Size(32, 17);
            this.iconButtonclose.TabIndex = 3;
            this.iconButtonclose.UseVisualStyleBackColor = true;
            this.iconButtonclose.Click += new System.EventHandler(this.iconButtonclose_Click);
            // 
            // iconButtonMin
            // 
            this.iconButtonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMin.FlatAppearance.BorderSize = 0;
            this.iconButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMin.IconColor = System.Drawing.Color.White;
            this.iconButtonMin.IconSize = 21;
            this.iconButtonMin.Location = new System.Drawing.Point(597, -1);
            this.iconButtonMin.Name = "iconButtonMin";
            this.iconButtonMin.Rotation = 0D;
            this.iconButtonMin.Size = new System.Drawing.Size(21, 26);
            this.iconButtonMin.TabIndex = 2;
            this.iconButtonMin.UseVisualStyleBackColor = true;
            this.iconButtonMin.Click += new System.EventHandler(this.iconButtonMin_Click);
            // 
            // lblTitlechildform
            // 
            this.lblTitlechildform.AutoSize = true;
            this.lblTitlechildform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlechildform.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitlechildform.Location = new System.Drawing.Point(51, 6);
            this.lblTitlechildform.Name = "lblTitlechildform";
            this.lblTitlechildform.Size = new System.Drawing.Size(56, 20);
            this.lblTitlechildform.TabIndex = 1;
            this.lblTitlechildform.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(82)))), ((int)(((byte)(19)))));
            this.iconCurrentChildForm.IconSize = 34;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, -1);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Rotation = 0D;
            this.iconCurrentChildForm.Size = new System.Drawing.Size(64, 36);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // Desktoppanel
            // 
            this.Desktoppanel.BackColor = System.Drawing.Color.White;
            this.Desktoppanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Desktoppanel.BackgroundImage")));
            this.Desktoppanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desktoppanel.Controls.Add(this.label5);
            this.Desktoppanel.Controls.Add(this.label4);
            this.Desktoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desktoppanel.Location = new System.Drawing.Point(200, 32);
            this.Desktoppanel.Name = "Desktoppanel";
            this.Desktoppanel.Size = new System.Drawing.Size(694, 468);
            this.Desktoppanel.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Home);
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 64);
            this.panelLogo.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(0, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(70, 43);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 0;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Library Management  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NSBM   ";
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Dove;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconSize = 33;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 64);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Dashboard";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAccount.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.IconSize = 33;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 124);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAccount.Rotation = 0D;
            this.btnAccount.Size = new System.Drawing.Size(200, 60);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBook.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBook.IconSize = 33;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 184);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBook.Rotation = 0D;
            this.btnBook.Size = new System.Drawing.Size(200, 60);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckout.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnCheckout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCheckout.IconSize = 33;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(0, 244);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCheckout.Rotation = 0D;
            this.btnCheckout.Size = new System.Drawing.Size(200, 60);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnNews
            // 
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNews.FlatAppearance.BorderSize = 0;
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNews.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNews.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNews.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnNews.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNews.IconSize = 33;
            this.btnNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.Location = new System.Drawing.Point(0, 304);
            this.btnNews.Name = "btnNews";
            this.btnNews.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNews.Rotation = 0D;
            this.btnNews.Size = new System.Drawing.Size(200, 60);
            this.btnNews.TabIndex = 7;
            this.btnNews.Text = "News";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(140)))));
            this.panelMenu.Controls.Add(this.iconButton6);
            this.panelMenu.Controls.Add(this.btnCompetition);
            this.panelMenu.Controls.Add(this.btnNews);
            this.panelMenu.Controls.Add(this.btnCheckout);
            this.panelMenu.Controls.Add(this.btnBook);
            this.panelMenu.Controls.Add(this.btnAccount);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 500);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconSize = 33;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 424);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(200, 60);
            this.iconButton6.TabIndex = 9;
            this.iconButton6.Text = "Report";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btnCompetition
            // 
            this.btnCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetition.FlatAppearance.BorderSize = 0;
            this.btnCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetition.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCompetition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompetition.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.btnCompetition.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCompetition.IconSize = 33;
            this.btnCompetition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetition.Location = new System.Drawing.Point(0, 364);
            this.btnCompetition.Name = "btnCompetition";
            this.btnCompetition.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompetition.Rotation = 0D;
            this.btnCompetition.Size = new System.Drawing.Size(200, 60);
            this.btnCompetition.TabIndex = 8;
            this.btnCompetition.Text = "Competition";
            this.btnCompetition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompetition.UseVisualStyleBackColor = true;
            this.btnCompetition.Click += new System.EventHandler(this.btnCompetition_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(173, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(276, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "to NSBM Library";
            // 
            // las
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(894, 500);
            this.Controls.Add(this.Desktoppanel);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "las";
            this.Text = "Form1";
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.Desktoppanel.ResumeLayout(false);
            this.Desktoppanel.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitlechildform;
        private System.Windows.Forms.Panel Desktoppanel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Home;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnBook;
        private FontAwesome.Sharp.IconButton btnCheckout;
        private FontAwesome.Sharp.IconButton btnNews;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonMax;
        private FontAwesome.Sharp.IconButton iconButtonclose;
        private FontAwesome.Sharp.IconButton iconButtonMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnCompetition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

