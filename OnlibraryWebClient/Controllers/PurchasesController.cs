using Microsoft.AspNetCore.Mvc;
using OnlibraryDataAccess;
using OnlibraryDataAccess.BaseClasses;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnlibraryWebClient.Areas.Identity.Data;
using System.Security.Claims;
using System.Text.Json;

namespace OnlibraryWebClient.Controllers
{

    public class PurchasesController : Controller
    {
        private readonly HttpClient _client;
        public PurchasesController(HttpClient client)
        {
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> Index(int bookId)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var order = new Order()
            {
                UserId = id,
                BookId = bookId,
                BookLanguageId = 1
            };
            var json = System.Text.Json.JsonSerializer.Serialize(order);
            var stringJson = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(new Uri($"Orders", UriKind.Relative), stringJson);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return View((object)content);
            }

            throw new HttpRequestException(await response.Content.ReadAsStringAsync());

        }

        [HttpGet]
        public async Task<IActionResult> MyOrders() 
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            HttpResponseMessage response = await _client.GetAsync(new Uri($"Orders/{id}", UriKind.Relative));
            var content = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var orders = System.Text.Json.JsonSerializer.Deserialize<List<OrderBase>>(content, options);

            return View(orders);
        }
    }
}
