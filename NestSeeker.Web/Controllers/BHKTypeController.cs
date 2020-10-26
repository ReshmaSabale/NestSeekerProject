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
    public class BHKTypeController : ControllerBase
    {
        private readonly IBHKTypeService _bhktypeService;
        public BHKTypeController(IBHKTypeService bhktypeService)
        {
            this._bhktypeService = bhktypeService;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllBHKTypes()
        {
            //UserService service = new UserService();
            return Ok(_bhktypeService.GetAllBHKTypes());
        }
        [HttpPost("addbhktype")]
        public IActionResult AddBHKType(BHKType bhktype)
        {
            //UserService service = new UserService();
            return Ok(_bhktypeService.AddBHKType(bhktype));
        }

    }
}
