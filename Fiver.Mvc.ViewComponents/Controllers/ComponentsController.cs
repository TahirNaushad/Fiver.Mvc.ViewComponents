using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.ViewComponents.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Use /Address or /UserInfo");
        }

        public IActionResult UserInfo()
        {
            // works: this component's view is in Views/Shared
            return ViewComponent("UserInfo");
        }

        public IActionResult Address()
        {
            // doesn't works: this component's view is NOT in Views/<controller>
            return ViewComponent("Address", new { employeeId = 5 });
        }
    }
}
