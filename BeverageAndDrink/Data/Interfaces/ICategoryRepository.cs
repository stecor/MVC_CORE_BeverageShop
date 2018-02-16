using BeverageAndDrink.Data.Models;
using System.Collections.Generic;

namespace BeverageAndDrink.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;}
    }
}
