using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LAB_15._1_ConsumingAPI.Models;

namespace LAB_15._1_ConsumingAPI.Controllers
{
    public class DeckOfCardsController : Controller
    {
        private readonly ILogger<DeckOfCardsController> _logger;

        public DeckOfCardsController(ILogger<DeckOfCardsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Deck()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");

            var response = await client.GetAsync("api/deck/new/draw/?count=5");

            var deck = await response.Content.ReadAsAsync<Deck>();

            ViewData["DeckId"] = deck.deck_id;

            return View(deck);
        }
    }
}