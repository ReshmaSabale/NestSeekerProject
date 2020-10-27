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
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _statusService;
        public StatusController(IStatusService statusService)
        {
            this._statusService = statusService;
        }

        [HttpGet("GetAllProperties")]
        public IActionResult GetAllStatus()
        {
            //UserService service = new UserService();
            return Ok(_statusService.GetAllStatus());
        }

        [HttpPost("addstatus")]
        public IActionResult AddStatus(Status status)
        {
            //UserService service = new UserService();
            return Ok(_statusService.AddStatus(status));
        }

    }
}
