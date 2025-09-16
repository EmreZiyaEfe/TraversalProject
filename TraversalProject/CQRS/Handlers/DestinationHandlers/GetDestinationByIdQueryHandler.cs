using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Queries.DestinationQueries;
using TraversalProject.CQRS.Results.DestinationResults;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly AppDbContext _appDbContext;

        public GetDestinationByIdQueryHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _appDbContext.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                Id = values.Id,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price,
            };
        }
    }
}
