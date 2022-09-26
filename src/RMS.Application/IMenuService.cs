using RMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application
{
    // THIS IS A USE CASE. THAT AS TO TAKE PLACE IN THIS SERVICE.
    public interface IMenuService
    {
        List<Menu> GetAllMenus();
    }
}
