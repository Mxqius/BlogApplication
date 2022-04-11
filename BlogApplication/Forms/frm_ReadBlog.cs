using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlogDataLayer;
using BlogDataLayer.Context;
using BlogUtility;

namespace BlogApplication.Forms
{
    public partial class frm_ReadBlog : Form
    {
        private int BlogID = 0;
        UnitOfWork sqlMethods;
        public frm_ReadBlog(int BlogID)
        {
            InitializeComponent();
            this.BlogID = BlogID;
        }

        private void frm_ReadBlog_Load(object sender, EventArgs e)
        {
            ConvertImage u = new ConvertImage();
            sqlMethods = new UnitOfWork();
            var Tabel = sqlMethods.SqlMethods.SelectBlog(BlogID);
            txt_body.Text = Tabel.BlogBody;
            lbl_title.Text = Tabel.BlogTitle;
            lbl_author.Text = Tabel.BlogAuthor;
            lbl_createDate.Text = Tabel.BlogCreateDate;
            pic_blog.Image = u.ConvertArrayToImage(Tabel.BlogPicture);
            sqlMethods.Dispose();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
