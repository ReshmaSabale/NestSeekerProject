using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NestSeeker.Data.Model;
using NestSeeker.Service.Interface;

namespace NestSeeker.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }

        [HttpGet("GetAllProperties")]
        public IActionResult GetAllRoles()
        {
            //UserService service = new UserService();
            return Ok(_roleService.GetAllRoles());
        }

        [HttpPost("addrole")]
        public IActionResult AddRole(Role role)
        {
            //UserService service = new UserService();
            return Ok(_roleService.AddRole(role));
        }
    }
}
