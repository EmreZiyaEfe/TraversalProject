using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccess.Concrete;

namespace TraversalProject.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        private readonly AppDbContext _context;

        public _Statistics(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.v1 = _context.Destinations.Count();
            ViewBag.v2 = _context.Guides.Count();
            ViewBag.v3 = "276";
            return View();
        }
    }
}
