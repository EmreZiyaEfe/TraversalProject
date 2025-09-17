using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Commands.DestinationCommands;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly AppDbContext _appDbContext;

        public UpdateDestinationCommandHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _appDbContext.Destinations.Find(command.Id);
            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;
            _appDbContext.SaveChanges();
        }
    }
}
