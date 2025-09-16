using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.CQRS.Handlers.DestinationHandlers;
using TraversalProject.CQRS.Queries.DestinationQueries;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _handler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler handler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler)
        {
            _handler = handler;
            _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetDestination(int id) 
        {
            var values = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }
    }
}
