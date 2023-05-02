using Microsoft.AspNetCore.Mvc;

namespace ClassRoom.Controllers
{
    public class SchoolsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
