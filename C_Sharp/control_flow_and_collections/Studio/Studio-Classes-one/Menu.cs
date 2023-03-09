using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio_Classes_one;
namespace Studio_Classes_one
{
   


    public class Menu
    {
        public List<MenuItems> Items { get; set; }
        DateTime aDate = DateTime.Now;

        public Menu(List<MenuItems> items)
        {
            Items = items;

        }
    }












}
