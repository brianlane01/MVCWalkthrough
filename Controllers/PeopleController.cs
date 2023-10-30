using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SwapiMVC.Controllers
{
    // [Route("[controller]")]
    public class PeopleController : Controller
    {
        // private readonly ILogger<PeopleController> _logger;
        private readonly HttpClient _httpClient;
        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            httpClientFactory.CreateClient("swapi");
        }

        public IActionResult Index()
        {
            return View();
        }

    //     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //     public IActionResult Error()
    //     {
    //         return View("Error!");
    //     }
    }
}