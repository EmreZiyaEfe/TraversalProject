using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete.Entities;

namespace Traversal.DataAccess.Abstract
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        Destination GetDestinationWithGuide(int id);
        List<Destination> GetLast4Destinations();
    }
}
