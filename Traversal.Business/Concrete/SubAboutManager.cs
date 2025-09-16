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
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetAll()
        {
            return _subAboutDal.GetAll();
        }

        public SubAbout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
