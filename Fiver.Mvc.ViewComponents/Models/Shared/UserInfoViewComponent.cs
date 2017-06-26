using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiver.Mvc.ViewComponents.Models.Shared
{
    public class UserInfoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new UserInfoViewModel
            {
                Username = "james@bond.com",
                LastLogin = DateTime.Now.ToString()
            };
            return View("info", model);
        }
    }
}
