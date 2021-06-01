using CardDemoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CardDemoAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com/");
            var response = await client.GetAsync("/api/deck/new/shuffle/?deck_count=1");
            //string result = await response.Content.ReadAsStringAsync();
            //ViewBag.myResult = result;

            Deck cards = await response.Content.ReadAsAsync<Deck>();

            response = await client.GetAsync($"/api/deck/{cards.deck_id}/draw/?count=5");

            CardSet cset = await response.Content.ReadAsAsync<CardSet>();
            return View(cset);
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
