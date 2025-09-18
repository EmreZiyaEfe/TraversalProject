using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccess.Abstract
{
    public interface IGenericUowDal<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void MultiUpdate(List<T> items);
        T GetById(int id);
    }
}
