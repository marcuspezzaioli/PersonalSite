using Microsoft.AspNetCore.Mvc;

namespace marcuspezzaioli.Controllers
{
	public class AboutMeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
