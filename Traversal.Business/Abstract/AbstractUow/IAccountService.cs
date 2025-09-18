using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete.Entities;

namespace Traversal.Business.Abstract.AbstractUow
{
    public interface IAccountService : IGenericUowService<Account>
    {
    }
}
