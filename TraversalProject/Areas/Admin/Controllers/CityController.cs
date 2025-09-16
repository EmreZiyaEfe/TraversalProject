using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using Traversal.Business.Abstract;
using Traversal.Core.Concrete.Entities;
using TraversalProject.Models;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetAll());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.Add(destination);
            var result = JsonConvert.SerializeObject(destination);
            return Json(result);
        }

        public IActionResult GetById(int id)
        {
            var result = _destinationService.GetById(id);
            if (result == null)
            {
                return Json(new { success = false, message = "City not found." });
            }
            return Json(new { success = true, data = result });
        }

        public IActionResult DeleteCity(int id)
        {
            var result = _destinationService.GetById(id);
            _destinationService.Delete(result);
            return NoContent();
        }

        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
            try
            {

                var result = _destinationService.GetById(destination.Id);
                if (result == null)
                {
                    return Json(new { success = false, message = "City not found" });
                }
                if (!string.IsNullOrEmpty(destination.City))
                    result.City = destination.City;

                if (!string.IsNullOrEmpty(destination.DayNight))
                    result.DayNight = destination.DayNight;

                //if (destination.Price > 0)
                //    result.Price = destination.Price;

                if (!string.IsNullOrEmpty(destination.Description))
                    result.Description = destination.Description;

                _destinationService.Update(result);
                var v = JsonConvert.SerializeObject(destination);
                return Json(v);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        //public static List<CityClass> cities = new List<CityClass>
        //{
        //    new CityClass()
        //    {
        //        Id = 1,
        //        Name = "Skopje",
        //        Country = "Macedonia",
        //    },
        //    new CityClass()
        //    {
        //        Id = 2,
        //        Name = "Rome",
        //        Country = "Italy",
        //    },
        //    new CityClass()
        //    {
        //        Id = 3,
        //        Name = "London",
        //        Country = "England",
        //    }
        //};
    }
}
