namespace Library_Management_System
{
    partial class Account
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.TextBox();
			this.uname = new System.Windows.Forms.TextBox();
			this.contact = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.lname = new System.Windows.Forms.TextBox();
			this.fname = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(269, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(729, 200);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(36, 36);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_Keyup);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.password);
			this.panel1.Controls.Add(this.uname);
			this.panel1.Controls.Add(this.contact);
			this.panel1.Controls.Add(this.email);
			this.panel1.Controls.Add(this.lname);
			this.panel1.Controls.Add(this.fname);
			this.panel1.Location = new System.Drawing.Point(269, 251);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(729, 162);
			this.panel1.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(274, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(515, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Username";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(38, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Contact";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(538, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(274, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Last Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(38, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "First Name";
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(370, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(358, 87);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(100, 20);
			this.password.TabIndex = 5;
			// 
			// uname
			// 
			this.uname.Location = new System.Drawing.Point(594, 87);
			this.uname.Name = "uname";
			this.uname.Size = new System.Drawing.Size(100, 20);
			this.uname.TabIndex = 4;
			// 
			// contact
			// 
			this.contact.Location = new System.Drawing.Point(121, 87);
			this.contact.Name = "contact";
			this.contact.Size = new System.Drawing.Size(100, 20);
			this.contact.TabIndex = 3;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(594, 20);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(100, 20);
			this.email.TabIndex = 2;
			// 
			// lname
			// 
			this.lname.Location = new System.Drawing.Point(358, 20);
			this.lname.Name = "lname";
			this.lname.Size = new System.Drawing.Size(100, 20);
			this.lname.TabIndex = 1;
			// 
			// fname
			// 
			this.fname.Location = new System.Drawing.Point(121, 20);
			this.fname.Name = "fname";
			this.fname.Size = new System.Drawing.Size(100, 20);
			this.fname.TabIndex = 0;
			// 
			// Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Account";
			this.Text = "Account";
			this.Load += new System.EventHandler(this.Account_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox uname;
		private System.Windows.Forms.TextBox contact;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.TextBox lname;
		private System.Windows.Forms.TextBox fname;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}