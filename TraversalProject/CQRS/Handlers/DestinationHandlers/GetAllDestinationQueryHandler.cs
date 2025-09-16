using Microsoft.EntityFrameworkCore;
using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Results.DestinationResults;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly AppDbContext _appDbContext;

        public GetAllDestinationQueryHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _appDbContext.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.Id,
                capacity = x.Capacity,
                city = x.City,
                dayNight = x.DayNight,
                price = x.Price,
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
