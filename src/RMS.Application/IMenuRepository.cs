using RMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application
{
    // this repository will get the data from direct db, api or any other third party.
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();

    }
}
