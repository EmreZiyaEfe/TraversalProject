using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Business.Abstract.AbstractUow
{
    public interface IGenericUowService<T>
    {
        void TAdd(T item);
        void TUpdate(T item);
        void TMultiUpdate(List<T> items);
        T TGetById(int id);
    }
}
