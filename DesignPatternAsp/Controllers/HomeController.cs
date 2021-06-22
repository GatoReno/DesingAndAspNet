using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesignPatternAsp.Models;
using Tools;

namespace DesignPatternAsp.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController(ILogger<HomeController> logger)
        {
             
        }

        public IActionResult Index()
        {
            Log.GetInstance("index.txt").Save("save entro a Index");
            
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance("priv.txt").Save("save entro a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
