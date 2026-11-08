using Microsoft.AspNetCore.Mvc;

namespace ProductCatalog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Welcome = "Тауарлар каталогына қош келдіңіз!";
            return View();
        }
    }
}
