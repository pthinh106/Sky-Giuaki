using Microsoft.AspNetCore.Mvc;

namespace Sky.Controllers
{
    public class StadiumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
