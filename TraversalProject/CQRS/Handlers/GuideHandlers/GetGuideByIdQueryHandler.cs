using MediatR;
using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Queries.GuideQueries;
using TraversalProject.CQRS.Results.GuideResult;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly AppDbContext _appDbContext;

        public GetGuideByIdQueryHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _appDbContext.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                Id = values.Id,
                Description = values.Description,
                Name = values.Name,
            };
           
        }
    }
}
