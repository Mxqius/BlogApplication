namespace BlogApplication
{
    partial class frm_manageBlogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deletePost = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editPost = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addPost = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_posts = new System.Windows.Forms.DataGridView();
            this.pnl_header.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(165)))), ((int)(((byte)(34)))));
            this.pnl_header.Controls.Add(this.txt_search);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.btn_deletePost);
            this.pnl_header.Controls.Add(this.btn_editPost);
            this.pnl_header.Controls.Add(this.btn_addPost);
            this.pnl_header.Location = new System.Drawing.Point(28, 26);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1341, 72);
            this.pnl_header.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Animated = true;
            this.txt_search.BorderRadius = 2;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(360, 15);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(387, 45);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
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
            this.btn_exit.Location = new System.Drawing.Point(14, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(180, 45);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_deletePost
            // 
            this.btn_deletePost.Animated = true;
            this.btn_deletePost.BorderRadius = 5;
            this.btn_deletePost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deletePost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deletePost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deletePost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deletePost.FillColor = System.Drawing.Color.White;
            this.btn_deletePost.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePost.ForeColor = System.Drawing.Color.Black;
            this.btn_deletePost.Location = new System.Drawing.Point(771, 15);
            this.btn_deletePost.Name = "btn_deletePost";
            this.btn_deletePost.Size = new System.Drawing.Size(180, 45);
            this.btn_deletePost.TabIndex = 0;
            this.btn_deletePost.Text = "Delete Post";
            this.btn_deletePost.Click += new System.EventHandler(this.btn_deletePost_Click);
            // 
            // btn_editPost
            // 
            this.btn_editPost.Animated = true;
            this.btn_editPost.BorderRadius = 5;
            this.btn_editPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editPost.FillColor = System.Drawing.Color.White;
            this.btn_editPost.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editPost.ForeColor = System.Drawing.Color.Black;
            this.btn_editPost.Location = new System.Drawing.Point(957, 15);
            this.btn_editPost.Name = "btn_editPost";
            this.btn_editPost.Size = new System.Drawing.Size(180, 45);
            this.btn_editPost.TabIndex = 0;
            this.btn_editPost.Text = "Edit Post";
            this.btn_editPost.Click += new System.EventHandler(this.btn_editPost_Click);
            // 
            // btn_addPost
            // 
            this.btn_addPost.Animated = true;
            this.btn_addPost.BorderRadius = 5;
            this.btn_addPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addPost.FillColor = System.Drawing.Color.White;
            this.btn_addPost.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPost.ForeColor = System.Drawing.Color.Black;
            this.btn_addPost.Location = new System.Drawing.Point(1143, 15);
            this.btn_addPost.Name = "btn_addPost";
            this.btn_addPost.Size = new System.Drawing.Size(180, 45);
            this.btn_addPost.TabIndex = 0;
            this.btn_addPost.Text = "Add Post";
            this.btn_addPost.Click += new System.EventHandler(this.btn_addPost_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.panel1);
            this.pnl_main.Controls.Add(this.pnl_header);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1398, 771);
            this.pnl_main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(165)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.dgv_posts);
            this.panel1.Location = new System.Drawing.Point(28, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 587);
            this.panel1.TabIndex = 2;
            // 
            // dgv_posts
            // 
            this.dgv_posts.AllowUserToAddRows = false;
            this.dgv_posts.AllowUserToDeleteRows = false;
            this.dgv_posts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_posts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_posts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_posts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_posts.Location = new System.Drawing.Point(14, 18);
            this.dgv_posts.Name = "dgv_posts";
            this.dgv_posts.ReadOnly = true;
            this.dgv_posts.RowHeadersWidth = 51;
            this.dgv_posts.RowTemplate.Height = 24;
            this.dgv_posts.Size = new System.Drawing.Size(1309, 548);
            this.dgv_posts.TabIndex = 1;
            // 
            // frm_manageBlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1398, 771);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_manageBlogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.frm_pereview_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_main;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_addPost;
        private System.Windows.Forms.DataGridView dgv_posts;
        private Guna.UI2.WinForms.Guna2Button btn_deletePost;
        private Guna.UI2.WinForms.Guna2Button btn_editPost;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
    }
}

