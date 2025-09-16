using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfAnnouncenementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public EfAnnouncenementDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
