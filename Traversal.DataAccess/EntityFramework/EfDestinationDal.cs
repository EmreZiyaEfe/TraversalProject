using Microsoft.EntityFrameworkCore;
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

        public Destination GetDestinationWithGuide(int id)
        {
            return _appDbContext.Destinations.Where(x => x.Id == id).Include(x => x.Guide).FirstOrDefault();
        }

        public List<Destination> GetLast4Destinations()
        {
            var values = _appDbContext.Destinations.Take(4).OrderByDescending(x => x.Id).ToList();
            return values;
        }
    }


}
