using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public EfDestinationDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }


}
