using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccess.Concrete;

namespace Traversal.DataAccess.UnitOfWork
{
    public class UowDal : IUowDal
    {
        private readonly AppDbContext _appDbContext;

        public UowDal(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }
    }
}
