using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataLayer
{
    public interface ISqlMethods
    {
        tbl_blogs SelectBlog(int blogID);
        List<tbl_blogs> SelectAllBlogs();
        bool UpdateBlog(tbl_blogs Blog);
        bool InsertBlog(tbl_blogs Blog);
        bool DeleteBlog(tbl_blogs Blog);
        List<tbl_blogs> Search(string SearchText);
        long BlogsCount();
        bool DeleteBlog(int blogID);
    }
}
