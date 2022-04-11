using BlogDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUtility;
using BlogDataLayer.Context;
using System.Windows.Forms;

namespace BlogApplication.Forms
{
    public partial class frm_blogsPreview : Form
    {
        UnitOfWork sqlMethods;
        public frm_blogsPreview()
        {
            InitializeComponent();
        }

        void LoadBlogs()
        {
            ConvertImage u = new ConvertImage();
            sqlMethods = new UnitOfWork();
            int count = (int)sqlMethods.SqlMethods.BlogsCount();
            var Tabel = sqlMethods.SqlMethods.SelectAllBlogs();
            for (int i = 1; i <= count; i++)
            {
                BlogPreview bg = new BlogPreview()
                {
                    Dock = DockStyle.Top,
                    TextLabelTitle = Tabel[i - 1].BlogTitle,
                    TextLabelAuthor = Tabel[i - 1].BlogAuthor,
                    PicturePreview = u.ConvertArrayToImage(Tabel[i - 1].BlogPicture),
                    BlogID = Tabel[i - 1].BlogID
                };

                pnl_blogs.Controls.Add(bg);

            }
            sqlMethods.Dispose();
        }
        private void frm_blogsPreview_Load(object sender, EventArgs e)
        {
            LoadBlogs();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_manageBlogs_Click(object sender, EventArgs e)
        {
            frm_manageBlogs fp = new frm_manageBlogs();
            if (fp.ShowDialog() == DialogResult.OK)
            {
                pnl_blogs.Controls.Clear();
                LoadBlogs();
            }
        }
    }
}
