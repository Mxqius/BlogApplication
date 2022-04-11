using BlogDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlogDataLayer.Context;

namespace BlogApplication
{
    public partial class frm_manageBlogs : Form
    {
        UnitOfWork sqlMethods;
        public frm_manageBlogs()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_addPost_Click(object sender, EventArgs e)
        {
            Forms.frm_AddOrEditPost fda = new Forms.frm_AddOrEditPost();
            if (fda.ShowDialog() == DialogResult.OK)
            {
                LoadBlogs();
            }
        }
        void LoadBlogs()
        {
            sqlMethods = new UnitOfWork();
            dgv_posts.DataSource = sqlMethods.SqlMethods.SelectAllBlogs();
            sqlMethods.Dispose();
        }
        private void frm_pereview_Load(object sender, EventArgs e)
        {
            LoadBlogs();
        }

        private void btn_editPost_Click(object sender, EventArgs e)
        {
            Forms.frm_AddOrEditPost fda = new Forms.frm_AddOrEditPost();
            fda.ID = int.Parse(dgv_posts.CurrentRow.Cells[0].Value.ToString());
            if (fda.ShowDialog() == DialogResult.OK)
            {
                LoadBlogs();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            sqlMethods = new UnitOfWork();
            var tabelRes = sqlMethods.SqlMethods.Search(txt_search.Text);
            dgv_posts.DataSource = tabelRes;
            //sqlMethods.Dispose();
        }

        private void btn_deletePost_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this blog?", "DeleteBlog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlMethods = new UnitOfWork();
                sqlMethods.SqlMethods.DeleteBlog(int.Parse(dgv_posts.CurrentRow.Cells[0].Value.ToString()));
                sqlMethods.SaveChanges();
                sqlMethods.Dispose();
                LoadBlogs();
            }
        }
    }
}
