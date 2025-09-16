using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Concrete;

namespace TraversalProject.ViewComponents.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
