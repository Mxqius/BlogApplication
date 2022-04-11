namespace BlogApplication.Forms
{
    partial class frm_blogsPreview
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
            this.btn_manageBlogs = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // pnl_blogs
            // 
            this.pnl_blogs.AutoScroll = true;
            this.pnl_blogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(165)))), ((int)(((byte)(34)))));
            this.pnl_blogs.Location = new System.Drawing.Point(12, 102);
            this.pnl_blogs.Name = "pnl_blogs";
            this.pnl_blogs.Size = new System.Drawing.Size(1042, 499);
            this.pnl_blogs.TabIndex = 0;
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
            this.btn_exit.Location = new System.Drawing.Point(12, 33);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(180, 45);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_manageBlogs
            // 
            this.btn_manageBlogs.Animated = true;
            this.btn_manageBlogs.BorderRadius = 5;
            this.btn_manageBlogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_manageBlogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_manageBlogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_manageBlogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_manageBlogs.FillColor = System.Drawing.Color.White;
            this.btn_manageBlogs.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageBlogs.ForeColor = System.Drawing.Color.Black;
            this.btn_manageBlogs.Location = new System.Drawing.Point(213, 33);
            this.btn_manageBlogs.Name = "btn_manageBlogs";
            this.btn_manageBlogs.Size = new System.Drawing.Size(180, 45);
            this.btn_manageBlogs.TabIndex = 1;
            this.btn_manageBlogs.Text = "Manage Blogs";
            this.btn_manageBlogs.Click += new System.EventHandler(this.btn_manageBlogs_Click);
            // 
            // frm_blogsPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1066, 613);
            this.Controls.Add(this.btn_manageBlogs);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_blogs);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_blogsPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_blogsPreview";
            this.Load += new System.EventHandler(this.frm_blogsPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_blogs;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_manageBlogs;
    }
}