using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WorthIt.Models.ViewModels;
using WorthIt.Data;
using WorthIt.Models;
using Microsoft.AspNetCore.Http;
using WorthIt.Utility;

namespace WorthIt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Products = _db.Product.Include(u => u.Category),
                Categories = _db.Category
            };
            return View(homeVM);
        }


        public IActionResult Details(int id)
        {
            List<Chart> chartList = new List<Chart>();
            if (HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart) != null
                && HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart).Count() > 0)
            {
                chartList = HttpContext.Session.Get<List<Chart>>(WC.SessionChart);
            }


            DetailsVM DetailsVM = new DetailsVM()
            {
                Product = _db.Product.Include(u => u.Category)
                .Where(u => u.Id == id).FirstOrDefault(),
                ExistsInChart = false
            };

            foreach (var item in chartList)
            {
                if (item.ProductId == id)
                {
                    DetailsVM.ExistsInChart = true;
                }
            }

            return View(DetailsVM);
        }

        [HttpPost,ActionNameAttribute("Details")]
        public IActionResult DetailsPost(int id)
        {
            List<Chart> chartList = new List<Chart>();
            if (HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart) != null
                && HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart).Count() > 0)
            {
                chartList = HttpContext.Session.Get<List<Chart>>(WC.SessionChart);
            }
            chartList.Add(new Chart { ProductId = id });
            HttpContext.Session.Set(WC.SessionChart,chartList);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveFromChart(int id)
        {
            List<Chart> chartList = new List<Chart>();
            if (HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart) != null
                && HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart).Count() > 0)
            {
                chartList = HttpContext.Session.Get<List<Chart>>(WC.SessionChart);
            }
            var itemToRemove = chartList.SingleOrDefault(r => r.ProductId == id);
            if (itemToRemove != null)
            {
                chartList.Remove(itemToRemove);
            }

            HttpContext.Session.Set(WC.SessionChart, chartList);
            return RedirectToAction(nameof(Index));
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
