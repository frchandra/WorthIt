using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorthIt.Data;
using WorthIt.Models;
using WorthIt.Utility;

namespace WorthIt.Controllers
{
    [Authorize]
    public class ChartController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ChartController(ApplicationDbContext db)
        {
            _db = db;
        }

        //HomeVM homeVM = new HomeVM()
        //{
        //    Products = _db.Product.Include(u => u.Category),
        //    Categories = _db.Category
        //};
        //    return View(homeVM);

        public IActionResult Index()
        {
            List<Chart> chartList = new List<Chart>();
            if(HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart)!=null && HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart).Count() > 0)
            {
                chartList = HttpContext.Session.Get<List<Chart>>(WC.SessionChart);
            }
            List<int> prodInChart = chartList.Select(i => i.ProductId).ToList();
            IEnumerable<Product> prodList = _db.Product.Where(u => prodInChart.Contains(u.Id)).Include(u => u.Category);
            return View(prodList);
        }

        public IActionResult Remove(int id)
        {
            List<Chart> chartList = new List<Chart>();
            if (HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart) != null && HttpContext.Session.Get<IEnumerable<Chart>>(WC.SessionChart).Count() > 0)
            {
                chartList = HttpContext.Session.Get<List<Chart>>(WC.SessionChart);
            }

            chartList.Remove(chartList.FirstOrDefault(u => u.ProductId == id));
            HttpContext.Session.Set(WC.SessionChart, chartList);
            return RedirectToAction(nameof(Index));
        }
    }
}
