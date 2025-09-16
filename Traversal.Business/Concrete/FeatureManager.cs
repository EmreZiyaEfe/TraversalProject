using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;

namespace Traversal.Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
