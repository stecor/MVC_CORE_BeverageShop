using BeverageAndDrink.Data.Models;
using System.Collections.Generic;

namespace BeverageAndDrink.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }

        public string CurrentCategory { get; set; }
    }
}
