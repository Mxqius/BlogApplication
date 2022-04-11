using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogApplication
{
    public partial class BlogPreview : UserControl
    {
        public BlogPreview()
        {
            InitializeComponent();
        }
        private int _blogID;
        public int BlogID
        {
            get { return this._blogID; }
            set { this._blogID = value; }
        }
        public string TextLabelTitle
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string TextLabelAuthor
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public Image PicturePreview
        {
            get { return guna2PictureBox1.Image; }
            set { guna2PictureBox1.Image = value;}
        }
        public Color PreviewColorBackgorund
        {
            get { return panel1.BackColor; }
            set { panel1.BackColor = value; }
        }
        public Point PreviewLocation
        {
            get { return panel1.Location; }
            set { panel1.Location = value; }    
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            PreviewColorBackgorund = Color.Transparent;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            PreviewColorBackgorund = Color.DarkKhaki;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Forms.frm_ReadBlog frb = new Forms.frm_ReadBlog(BlogID);            
            frb.ShowDialog();
        }
    }
}
