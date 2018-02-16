using BeverageAndDrink.Data.Models;
using System.Collections.Generic;

namespace BeverageAndDrink.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get;  }

        IEnumerable<Drink> PreferredDrinks { get;  }

        Drink GetDrinkById(int drinkId);
    }
}
