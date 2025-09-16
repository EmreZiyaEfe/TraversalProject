using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.Core.Concrete.Entities;

namespace TraversalProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = _reservationService.GetListWithReservationByAccepted(values.Id);
            return View(result);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = _reservationService.GetListWithReservationByPrevious(values.Id);
            return View(result);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = _reservationService.GetListWithReservationByWaitApproval(values.Id);
            return View(result);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.Id.ToString(),
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation model)
        {
            model.AppUserId = 5;
            model.Status = "Awaiting Approval";
            _reservationService.Add(model);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
