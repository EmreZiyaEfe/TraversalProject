using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalProject.Areas.Admin.Models;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&adults_number=2&page_number=0&children_number=2&include_adjacency=true&children_ages=5%2C0&locale=en-gb&dest_type=city&filter_by_currency=AED&dest_id=-1456928&order_by=popularity&units=metric&checkout_date=2025-10-15&room_number=1&checkin_date=2025-10-14"),
                Headers =
    {
        { "x-rapidapi-key", "4462489fa5mshee4fd43da4b0129p1bd5fajsn5e5dd007db4b" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingHotelSearchVm>(body);
                return View(values.result);
            }
        }

        public async Task<IActionResult> GetCityDestId()
        { 
            return View();
        }

            [HttpPost]
        public async Task<IActionResult> GetCityDestId(string city)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={city}"),
                Headers =
    {
        { "x-rapidapi-key", "4462489fa5mshee4fd43da4b0129p1bd5fajsn5e5dd007db4b" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }

    }
}
