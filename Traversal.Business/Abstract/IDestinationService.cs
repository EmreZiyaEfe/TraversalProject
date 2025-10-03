using Traversal.Core.Concrete.Entities;

namespace Traversal.Business.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        Destination TGetDestinationWithGuide(int id);
    }
}
