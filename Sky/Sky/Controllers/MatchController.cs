using Microsoft.AspNetCore.Mvc;

namespace Sky.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
