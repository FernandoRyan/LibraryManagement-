namespace Library_Management_System
{
    partial class News
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(News));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadmore = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnLatestNews = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(69)))));
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.btnLatestNews);
            this.groupBox1.Controls.Add(this.btnNews);
            this.groupBox1.Controls.Add(this.btnReadmore);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latest News";
            // 
            // btnReadmore
            // 
            this.btnReadmore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReadmore.Location = new System.Drawing.Point(520, 352);
            this.btnReadmore.Name = "btnReadmore";
            this.btnReadmore.Size = new System.Drawing.Size(193, 46);
            this.btnReadmore.TabIndex = 1;
            this.btnReadmore.Text = "Read more";
            this.btnReadmore.UseVisualStyleBackColor = true;
            // 
            // btnNews
            // 
            this.btnNews.Image = ((System.Drawing.Image)(resources.GetObject("btnNews.Image")));
            this.btnNews.Location = new System.Drawing.Point(30, 56);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(310, 86);
            this.btnNews.TabIndex = 2;
            this.btnNews.UseVisualStyleBackColor = true;
            // 
            // btnLatestNews
            // 
            this.btnLatestNews.Image = ((System.Drawing.Image)(resources.GetObject("btnLatestNews.Image")));
            this.btnLatestNews.Location = new System.Drawing.Point(30, 256);
            this.btnLatestNews.Name = "btnLatestNews";
            this.btnLatestNews.Size = new System.Drawing.Size(310, 168);
            this.btnLatestNews.TabIndex = 3;
            this.btnLatestNews.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(397, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 174);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "The COVID-19 pandemic has upended the lives of children and their families as hea" +
    "lth systems buckle, borders close, and schools and businesses shutter. ";
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "News";
            this.Text = "News";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLatestNews;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnReadmore;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}