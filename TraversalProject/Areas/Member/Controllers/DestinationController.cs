using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;

namespace TraversalProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]

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

        public IActionResult GetCitiesSearchByName(string searchCity)
        {
            ViewData["CurrentFilter"] = searchCity;
            var values = from x in _destinationService.GetAll() select x;
            if (!string.IsNullOrEmpty(searchCity))
            {
                values = values.Where(c => c.City.ToLower().Contains(searchCity.ToLower()));
            }
            return View(values.ToList());
        }
    }
}
