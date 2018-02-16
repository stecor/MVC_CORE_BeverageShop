using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageAndDrink.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Drink Drink { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
