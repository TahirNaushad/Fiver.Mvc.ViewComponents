using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiver.Mvc.ViewComponents.Models.Home
{
    [ViewComponent(Name = "Address")]
    public class AddressComponent : ViewComponent
    {
        private readonly IAddressFormatter formatter;

        public AddressComponent(IAddressFormatter formatter)
        {
            this.formatter = formatter;
        }

        public async Task<IViewComponentResult> InvokeAsync(int employeeId)
        {
            var model = new AddressViewModel
            {
                EmployeeId = employeeId,
                Line1 = "Secret Location",
                Line2 = "London",
                Line3 = "UK"
            };
            model.FormattedValue = this.formatter.Format(model.Line1, model.Line2, model.Line3);
            return View(model);
        }
    }
}
