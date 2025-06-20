using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UsersApp.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace UsersApp.Controllers
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
            var selectedDb = HttpContext.Session.GetString("SelectedDatabase");
            ViewBag.SelectedDb = selectedDb;
            return View();
        }

        public IActionResult Privacy()
        {
            var selectedDb = HttpContext.Session.GetString("SelectedDatabase");
            ViewBag.SelectedDb = selectedDb;
            return View();
        }

        public IActionResult Hrmodule()
        {
            var selectedDb = HttpContext.Session.GetString("SelectedDatabase");
            ViewBag.SelectedDb = selectedDb;
            return View();
        }


        // NEW: Handles database selection from dropdown
        public IActionResult SwitchDatabase(string db)
        {
            if (!string.IsNullOrEmpty(db))
            {
                HttpContext.Session.SetString("SelectedDatabase", db);
            }

            // Redirect to wherever you want (Index, Hrmodule, etc.)
            return RedirectToAction("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
