using MediatR;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Commands.GuideCommands;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly AppDbContext _appDbContext;

        public CreateGuideCommandHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _appDbContext.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Image = request.Image,
                InstagramUrl = "instagram.com",
                XUrl = "x.com"
            });
            await _appDbContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
