using RMS.Application;
using RMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure
{
    public class MenuRepository : IMenuRepository
    {
        public static List<Menu> menuList = new List<Menu>()
        {
            new Menu {Id=1, Name="Curry Soup", Cost=(decimal) 14.5},
            new Menu {Id=2, Name="Teh Tarik", Cost= (decimal) 2.5 },
            new Menu {Id=1, Name="Mee Goreng", Cost=(decimal) 14.5},
            new Menu {Id=2, Name="Teh O", Cost= 1 }
        };

        public List<Menu> GetAllMenus()
        {
            return menuList;
        }
    }
}
