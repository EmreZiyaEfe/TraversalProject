using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.Core.Concrete.Entities;

namespace TraversalProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {

        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetAll();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.Id = id;
            ViewBag.destId = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userId = value.Id;
            var result = _destinationService.TGetDestinationWithGuide(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
