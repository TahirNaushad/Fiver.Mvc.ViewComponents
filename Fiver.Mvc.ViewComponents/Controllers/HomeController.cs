using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.ViewComponents.Models.Home;

namespace Fiver.Mvc.ViewComponents.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new EmployeeViewModel
            {
                Id = 1,
                Firstname = "James",
                Surname = "Bond"
            };
            return View(model);
        }
    }
}
