using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.Core.Concrete.Entities;

namespace TraversalProject.Controllers
{
    public class DestinationController : Controller
    {

        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.Id = id;
            var result = _destinationService.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
