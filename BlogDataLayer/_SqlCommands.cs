using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace BlogDataLayer
{
    public class _SqlCommands : ISqlMethods
    {
        private BlogEntities bl;

        public _SqlCommands(BlogEntities be)
        {
            bl = be;
        }
        public bool InsertBlog(tbl_blogs Blog)
        {
            try
            {
                bl.tbl_blogs.Add(Blog);
                return true;

            }
            catch
            {
                return false;
            }

        }

        public bool DeleteBlog(tbl_blogs Blog)
        {
            try
            {
                bl.Entry<tbl_blogs>(Blog).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBlog(tbl_blogs Blog)
        {
            try
            {
                //bl.tbl_blogs.AddOrUpdate(Blog);
                bl.Entry(Blog).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<tbl_blogs> SelectAllBlogs()
        {
            return bl.tbl_blogs.ToList();
        }

        public tbl_blogs SelectBlog(int blogID)
        {
            //return bl.uvw_ShowBlogs.Where(n => n.BlogID == id).ToList();
            return bl.tbl_blogs.Find(blogID);
        }
        public List<tbl_blogs> Search(string SearchText)
        {
            return bl.tbl_blogs.Where(n => n.BlogTitle.Contains(SearchText) || n.BlogBody.Contains(SearchText)).ToList();
        }
        public long BlogsCount()
        {
            return bl.tbl_blogs.Count();
        }
        public bool DeleteBlog(int blogID)
        {
            try
            {
                var Tabel = SelectBlog(blogID);
                DeleteBlog(Tabel);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
