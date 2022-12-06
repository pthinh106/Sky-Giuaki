using Microsoft.AspNetCore.Mvc;

namespace Sky.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
