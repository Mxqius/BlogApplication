using System;
using BlogDataLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlogUtility;
using BlogDataLayer.Context;
using DateTime = BlogUtility.DateTime;

namespace BlogApplication.Forms
{
    public partial class frm_AddOrEditPost : Form
    {
        public int ID = 0;
        UnitOfWork sqlMethods;
        private ConvertImage ImageConvert;
        private BlogUtility.DateTime dt;
        public frm_AddOrEditPost()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_picture_post_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG File|*jpg|PNG File|*.png";
            openFileDialog.Title = "Select Picture Post";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_picture_post.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void frm_AddOrEditPost_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                ConvertImage u = new ConvertImage();
                sqlMethods = new UnitOfWork();
                var Tabel = sqlMethods.SqlMethods.SelectBlog(ID);
                txt_title.Text = Tabel.BlogTitle;
                txt_author.Text = Tabel.BlogAuthor;
                txt_body.Text = Tabel.BlogBody;
                txt_category.Text = Tabel.BlogCategory;
                pb_picture_post.Image = u.ConvertArrayToImage(Tabel.BlogPicture);
                btn_addoredit.Text = "Edit";
                sqlMethods.Dispose();
            }
        }

        private void btn_addoredit_Click(object sender, EventArgs e)
        {
            try
            {
                sqlMethods = new UnitOfWork();
                dt = new DateTime();
                if (ID == 0)
                {
                    ImageConvert = new ConvertImage();
                    tbl_blogs tb = new tbl_blogs()
                    {
                        BlogBody = txt_body.Text,
                        BlogTitle = txt_title.Text,
                        BlogPicture = ImageConvert.ConvertImageToArray(pb_picture_post.Image),
                        BlogCategory = txt_category.Text,
                        BlogAuthor = txt_author.Text,
                        BlogCreateDate = dt.GetDate(),
                        BlogCreateTime = dt.GetTime()
                    };
                    sqlMethods.SqlMethods.InsertBlog(tb);
                    sqlMethods.SaveChanges();
                    MessageBox.Show("Added Sucessfuly");
                }
                else
                {
                    ImageConvert = new ConvertImage();
                    tbl_blogs tb = new tbl_blogs()
                    {
                        BlogID = ID,
                        BlogBody = txt_body.Text,
                        BlogTitle = txt_title.Text,
                        BlogPicture = ImageConvert.ConvertImageToArray(pb_picture_post.Image),
                        BlogCategory = txt_category.Text,
                        BlogAuthor = txt_author.Text,
                        BlogCreateDate = dt.GetDate(),
                        BlogCreateTime = dt.GetTime()
                    };
                    sqlMethods.SqlMethods.UpdateBlog(tb);
                    sqlMethods.SaveChanges();
                    MessageBox.Show("Update Sucessfuly");
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_author.Text = txt_body.Text = txt_body.Text = txt_title.Text = string.Empty;
        }
    }
}
