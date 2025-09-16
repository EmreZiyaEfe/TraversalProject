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
    public class AboutManager : IAboutService
    {
       private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
