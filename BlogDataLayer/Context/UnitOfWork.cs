using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        BlogEntities bl = new BlogEntities();
        private ISqlMethods _sqlMethods;
        public ISqlMethods SqlMethods
        {
            get
            {
                if (_sqlMethods == null)
                {
                    _sqlMethods = new _SqlCommands(bl);
                }
                return _sqlMethods;
            }
        }
        public void SaveChanges()
        {
            bl.SaveChanges();
        }
        public void Dispose()
        {
            bl.Dispose();
        }
    }
}
