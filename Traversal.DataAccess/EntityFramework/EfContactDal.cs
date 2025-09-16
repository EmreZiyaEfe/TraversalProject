using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
