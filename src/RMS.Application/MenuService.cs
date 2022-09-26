using RMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application
{
    public class MenuService : IMenuService
    {
        //CONTRUCTOR DEPENDENCY INJECTION
        private readonly IMenuRepository _menuRepository;
        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public List<Menu> GetAllMenus()
        {
           var menus = _menuRepository.GetAllMenus();
            return menus;
        }
    }
}
