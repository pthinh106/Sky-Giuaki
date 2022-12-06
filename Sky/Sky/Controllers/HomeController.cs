using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sky.Entity;
using Sky.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Sky.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ManageContext _db;
        public HomeController(ILogger<HomeController> logger, ManageContext manageContext)
        {
            _logger = logger;
            _db = manageContext;
        }

        public IActionResult Index()
        {
            return View();
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