using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.ValidationRules;
using Traversal.Core.Concrete.Entities;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;
        private readonly GuideValidator _guideValidator;

        public GuideController(IGuideService guideService, GuideValidator guideValidator)
        {
            _guideService = guideService;
            _guideValidator = guideValidator;
        }

        public IActionResult Index()
        {
            var values = _guideService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Guide guide)
        {
            ValidationResult result = _guideValidator.Validate(guide);
            if (result.IsValid)
            {
                _guideService.Add(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = _guideService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Edit(Guide guide)
        {
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _guideService.GetById(id);
            _guideService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
