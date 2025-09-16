using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccess.Abstract
{
    public interface IGenericDal<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetAll();
        T GetById(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
