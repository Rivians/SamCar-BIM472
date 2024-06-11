using Microsoft.AspNetCore.Mvc;

namespace SamCar472.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
