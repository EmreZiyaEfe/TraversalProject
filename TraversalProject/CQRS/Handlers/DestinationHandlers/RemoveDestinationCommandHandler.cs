using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Commands.DestinationCommands;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly AppDbContext _appDbContext;

        public RemoveDestinationCommandHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _appDbContext.Destinations.Find(command.Id);
            _appDbContext.Destinations.Remove(values);
            _appDbContext.SaveChanges();
        }
    }
}
