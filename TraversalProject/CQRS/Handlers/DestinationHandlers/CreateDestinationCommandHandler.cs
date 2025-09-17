using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Commands.DestinationCommands;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly AppDbContext _appDbContext;

        public CreateDestinationCommandHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _appDbContext.Destinations.Add(new Destination
            {
                City = command.City,
                Price = command.Price,
                DayNight = command.DayNight,
                Capacity = command.Capacity,
                Image = command.Image,
                Description = command.Description,
                CoverImage = command.CoverImage,
                FirstContent = command.FirstContent,
                SecondContent = command.SecondContent,
                Image2 = command.Image2,
                Status = true,
            });
            _appDbContext.SaveChanges();
        }
    }
}
