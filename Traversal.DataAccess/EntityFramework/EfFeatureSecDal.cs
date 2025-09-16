using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfFeatureSecDal : GenericRepository<FeatureSec>, IFeatureSecDal
    {
        public EfFeatureSecDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

}
