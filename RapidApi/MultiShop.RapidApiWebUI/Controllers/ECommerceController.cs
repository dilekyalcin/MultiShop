using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUI.Models;
using Newtonsoft.Json;

namespace MultiShop.RapidApiWebUI.Controllers
{
    public class ECommerceController : Controller
    {
        public async Task<IActionResult> ECommerceList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-product-search.p.rapidapi.com/search-v2?q=logitech%20mouse&country=us&language=en&page=1&limit=10&sort_by=BEST_MATCH&product_condition=ANY"),
                Headers =
    {
        { "x-rapidapi-key", "13407d7245msh6b62bd45d47f808p1e0745jsne9ba45ee50b0" },
        { "x-rapidapi-host", "real-time-product-search.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ECommerceViewModel.Rootobject>(body);
                return View(values.data.products.ToList());
            }
        }
    }
}
