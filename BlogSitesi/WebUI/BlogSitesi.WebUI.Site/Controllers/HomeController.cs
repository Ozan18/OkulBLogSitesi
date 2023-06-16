using Microsoft.AspNetCore.Mvc;

namespace BlogSitesi.WebUI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
