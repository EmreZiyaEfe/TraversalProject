using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;

namespace Traversal.DataAccess.Repository
{
    public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericUowRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(T item)
        {
            _appDbContext.Add(item);
        }

        public T GetById(int id)
        {
            return _appDbContext.Set<T>().Find(id);
        }

        public void MultiUpdate(List<T> items)
        {
            _appDbContext.UpdateRange(items);
        }

        public void Update(T item)
        {
            _appDbContext.Update(item);
        }
    }
}
