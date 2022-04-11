namespace BlogApplication.Forms
{
    partial class frm_ReadBlog
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
            this.pnl_blogs = new System.Windows.Forms.Panel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_createDate = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_body = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_blog = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_blogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_blog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_blogs
            // 
            this.pnl_blogs.AutoScroll = true;
            this.pnl_blogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(165)))), ((int)(((byte)(34)))));
            this.pnl_blogs.Controls.Add(this.btn_exit);
            this.pnl_blogs.Controls.Add(this.pic_blog);
            this.pnl_blogs.Controls.Add(this.lbl_createDate);
            this.pnl_blogs.Controls.Add(this.lbl_author);
            this.pnl_blogs.Controls.Add(this.lbl_title);
            this.pnl_blogs.Controls.Add(this.label4);
            this.pnl_blogs.Controls.Add(this.label3);
            this.pnl_blogs.Controls.Add(this.label2);
            this.pnl_blogs.Controls.Add(this.label1);
            this.pnl_blogs.Controls.Add(this.txt_body);
            this.pnl_blogs.Location = new System.Drawing.Point(34, 33);
            this.pnl_blogs.Name = "pnl_blogs";
            this.pnl_blogs.Size = new System.Drawing.Size(1111, 708);
            this.pnl_blogs.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.BorderRadius = 5;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(896, 307);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(180, 45);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Close";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_createDate
            // 
            this.lbl_createDate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createDate.ForeColor = System.Drawing.Color.White;
            this.lbl_createDate.Location = new System.Drawing.Point(184, 249);
            this.lbl_createDate.Name = "lbl_createDate";
            this.lbl_createDate.Size = new System.Drawing.Size(299, 27);
            this.lbl_createDate.TabIndex = 1;
            // 
            // lbl_author
            // 
            this.lbl_author.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(151, 156);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(273, 27);
            this.lbl_author.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(137, 65);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(480, 27);
            this.lbl_title.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Body :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "CreateDate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title :";
            // 
            // txt_body
            // 
            this.txt_body.Animated = true;
            this.txt_body.AutoScroll = true;
            this.txt_body.BackColor = System.Drawing.Color.Transparent;
            this.txt_body.BorderColor = System.Drawing.Color.White;
            this.txt_body.BorderRadius = 5;
            this.txt_body.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_body.DefaultText = "";
            this.txt_body.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_body.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_body.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_body.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_body.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(165)))), ((int)(((byte)(34)))));
            this.txt_body.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_body.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_body.ForeColor = System.Drawing.Color.White;
            this.txt_body.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_body.Location = new System.Drawing.Point(38, 375);
            this.txt_body.Margin = new System.Windows.Forms.Padding(6);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.PasswordChar = '\0';
            this.txt_body.PlaceholderText = "";
            this.txt_body.ReadOnly = true;
            this.txt_body.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_body.SelectedText = "";
            this.txt_body.Size = new System.Drawing.Size(1038, 308);
            this.txt_body.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_body.TabIndex = 0;
            // 
            // pic_blog
            // 
            this.pic_blog.BorderRadius = 2;
            this.pic_blog.ImageRotate = 0F;
            this.pic_blog.Location = new System.Drawing.Point(739, 31);
            this.pic_blog.Name = "pic_blog";
            this.pic_blog.Size = new System.Drawing.Size(337, 254);
            this.pic_blog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_blog.TabIndex = 2;
            this.pic_blog.TabStop = false;
            // 
            // frm_ReadBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1182, 770);
            this.Controls.Add(this.pnl_blogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ReadBlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ReadBlog";
            this.Load += new System.EventHandler(this.frm_ReadBlog_Load);
            this.pnl_blogs.ResumeLayout(false);
            this.pnl_blogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_blog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_blogs;
        private Guna.UI2.WinForms.Guna2TextBox txt_body;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_createDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2PictureBox pic_blog;
    }
}