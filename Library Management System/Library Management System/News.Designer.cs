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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLatestNews = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnReadmore = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(588, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latest News";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(298, 66);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 142);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "The COVID-19 pandemic has upended the lives of children and their families as hea" +
    "lth systems buckle, borders close, and schools and businesses shutter. ";
            // 
            // btnLatestNews
            // 
            this.btnLatestNews.Image = ((System.Drawing.Image)(resources.GetObject("btnLatestNews.Image")));
            this.btnLatestNews.Location = new System.Drawing.Point(22, 208);
            this.btnLatestNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLatestNews.Name = "btnLatestNews";
            this.btnLatestNews.Size = new System.Drawing.Size(232, 136);
            this.btnLatestNews.TabIndex = 3;
            this.btnLatestNews.UseVisualStyleBackColor = true;
            // 
            // btnNews
            // 
            this.btnNews.Image = ((System.Drawing.Image)(resources.GetObject("btnNews.Image")));
            this.btnNews.Location = new System.Drawing.Point(4, 29);
            this.btnNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(250, 87);
            this.btnNews.TabIndex = 2;
            this.btnNews.UseVisualStyleBackColor = true;
            // 
            // btnReadmore
            // 
            this.btnReadmore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReadmore.Location = new System.Drawing.Point(390, 286);
            this.btnReadmore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReadmore.Name = "btnReadmore";
            this.btnReadmore.Size = new System.Drawing.Size(145, 37);
            this.btnReadmore.TabIndex = 1;
            this.btnReadmore.Text = "Read more";
            this.btnReadmore.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(607, 370);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "News";
            this.Text = "News";
            this.Load += new System.EventHandler(this.News_Load);
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