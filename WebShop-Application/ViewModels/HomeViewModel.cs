using System.Collections.Generic;
using WebShop_Application.Models;

namespace WebShop_Application.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }

    }
}
