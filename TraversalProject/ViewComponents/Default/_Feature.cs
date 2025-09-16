using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;

namespace TraversalProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
       private readonly IFeatureService _featureService;

        public _Feature(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.GetAll();
            return View(values);
        }
    }
}
