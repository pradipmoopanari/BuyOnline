using Microsoft.AspNetCore.Mvc;

namespace BuyOnline.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
