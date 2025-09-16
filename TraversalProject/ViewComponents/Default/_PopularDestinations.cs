using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.EntityFramework;

namespace TraversalProject.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _PopularDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _destinationService.GetAll();
            return View(values); 
        }
    }
}
