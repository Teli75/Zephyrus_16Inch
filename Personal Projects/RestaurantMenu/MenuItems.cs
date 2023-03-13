using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItems
    {
        public class MenuItems
        {
            public double Price { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public bool IsNew { get; set; }
            public bool IsSpicy { get; set; }
        }
    }

    public MenuItems(double price, string description, string category, bool isNew, bool isSpicy)
    {
        Price = price;
        Description = description;
        Category = category;
        IsNew = isNew;
        IsSpicy = isSpicy;
    }
}
