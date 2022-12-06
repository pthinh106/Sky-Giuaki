using Microsoft.AspNetCore.Mvc;

namespace Sky.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
