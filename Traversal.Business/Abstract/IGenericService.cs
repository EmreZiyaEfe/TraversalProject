using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Business.Abstract
{
    public interface IGenericService<T> 
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
        //List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
