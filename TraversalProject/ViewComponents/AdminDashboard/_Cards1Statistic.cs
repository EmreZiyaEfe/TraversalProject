using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccess.Concrete;

namespace TraversalProject.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _Cards1Statistic(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _appDbContext.Destinations.Count();
            ViewBag.v2 = _appDbContext.Users.Count();

            return View();
        }
    }
}
