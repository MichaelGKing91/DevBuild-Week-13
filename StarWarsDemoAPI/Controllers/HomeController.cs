using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarWarsDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsDemoAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> People()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://swapi.dev");
            var response = await client.GetAsync("/api/people/1/");
            People peep = await response.Content.ReadAsAsync<People>();

            return View(peep);
        }

        public async Task<IActionResult> Films(string id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://swapi.dev");
            var response = await client.GetAsync($"/api/films/{id}/");
            Films film = await response.Content.ReadAsAsync<Films>();

            return View(film);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
