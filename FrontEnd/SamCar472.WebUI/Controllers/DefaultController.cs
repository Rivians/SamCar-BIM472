using Microsoft.AspNetCore.Mvc;

namespace SamCar472.WebUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
