using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Core.Concrete.Entities;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetAll();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var result = _appUserService.GetById(id);
            _appUserService.Delete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _appUserService.GetById(id);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult Update(AppUser appUser)
        {
            _appUserService.Update(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult UserComment(int id)
        {
            _appUserService.GetAll();
            return RedirectToAction("Index");
        }

        public IActionResult UserReservation(int id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
