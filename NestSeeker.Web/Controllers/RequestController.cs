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
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _requestService;
        public RequestController(IRequestService requestService)
        {
            this._requestService = requestService;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllRequests()
        {
            //UserService service = new UserService();
            return Ok(_requestService.GetAllRequests());
        }
        [HttpPost("addrequest")]
        public IActionResult AddRequest(Requests requests)
        {
            //UserService service = new UserService();
            return Ok(_requestService.AddRequest(requests));
        }
    }
}
