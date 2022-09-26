using Microsoft.AspNetCore.Mvc;
using RMS.Application;
using RMS.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RMS.API.Controllers
{

  

    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {

        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        // GET: api/<MenuController>
        [HttpGet]
        public ActionResult<List<Menu>> Get()
        {
            var menusFromService = _menuService.GetAllMenus();
            return Ok(menusFromService);
        }

    }
}
