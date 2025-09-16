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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination entity)
        {
            _destinationDal.Add(entity);
        }

        public void Delete(Destination entity)
        {
            _destinationDal.Delete(entity);
        }

        public List<Destination> GetAll()
        {
            return _destinationDal.GetAll();
        }

        public Destination GetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public void Update(Destination entity)
        {
            _destinationDal.Update(entity);
        }
    }
}
