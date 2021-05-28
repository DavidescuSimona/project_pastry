using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PASTRY.Models;
using PASTRYInfrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataRepository _dataRepository;

        public HomeController(ILogger<HomeController> logger, IDataRepository dataRepository)
        {
            _logger = logger;
            _dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            var data = _dataRepository.Query<Cake>().Take(10).ToArray();
            return View(data.Select(x => new Cake
            {
                Name = x.Name,
                Id = x.Id,
                IdImage = x.IdImage,
                Price = x.Price,
                Weight = x.Weight
            }));
            // return View();
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
