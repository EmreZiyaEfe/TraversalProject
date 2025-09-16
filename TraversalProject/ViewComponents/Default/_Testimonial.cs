using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;

namespace TraversalProject.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _Testimonial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.GetAll();
            return View(values);
        }
    }
}
