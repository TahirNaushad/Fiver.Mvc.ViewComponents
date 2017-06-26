using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiver.Mvc.ViewComponents.Models.Home
{
    public interface IAddressFormatter
    {
        string Format(string line1, string line2, string line3);
    }

    public class AddressFormatter : IAddressFormatter
    {
        public string Format(string line1, string line2, string line3)
        {
            return $"{line1}, {line2}, {line3}";
        }
    }
}
