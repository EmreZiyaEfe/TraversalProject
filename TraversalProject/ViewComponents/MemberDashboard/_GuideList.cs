using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;

namespace TraversalProject.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideList(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.GetAll();
            return View(values);
        }
    }
}
