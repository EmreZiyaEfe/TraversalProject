using MediatR;
using Microsoft.EntityFrameworkCore;
using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Queries.GuideQueries;
using TraversalProject.CQRS.Results.GuideResult;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery,List<GetAllGuideQeryResult>>
    {
        private readonly AppDbContext _appDbContext;

        public GetAllGuideQueryHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<GetAllGuideQeryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.Guides.Select(x =>  new GetAllGuideQeryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Image = x.Image
            }).AsNoTracking().ToListAsync();
        }
    }
}
