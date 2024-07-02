using Microsoft.AspNetCore.Mvc;

namespace Alumni.Web.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
