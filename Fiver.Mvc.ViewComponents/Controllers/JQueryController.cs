using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.ViewComponents.Controllers
{
    public class JQueryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
