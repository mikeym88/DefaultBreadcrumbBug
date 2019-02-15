using DefaultBreadcrumbBug.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SmartBreadcrumbs;

namespace DefaultBreadcrumbBug.Controllers
{
    public class HomeController : Controller
    {
        [DefaultBreadcrumb("ViewData.Title")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("ViewData.Title", CacheTitle = true)]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Breadcrumb("ViewData.Title", CacheTitle = true)]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Breadcrumb("ViewData.Title", CacheTitle = true)]
        public IActionResult Privacy()
        {
            return View();
        }

        [Breadcrumb("ViewData.Title", CacheTitle = true)]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
