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
    public class DirectionController : ControllerBase
    {
        private readonly IDirectionService _directionService;
        public DirectionController(IDirectionService directionService)
        {
            this._directionService = directionService;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllDirection()
        {
            //UserService service = new UserService();
            return Ok(_directionService.GetAllDirection());
        }
        [HttpPost("adddirection")]
        public IActionResult AddDirection(Direction direction)
        {
            //UserService service = new UserService();
            return Ok(_directionService.AddDirection(direction));
        }
    }
}
