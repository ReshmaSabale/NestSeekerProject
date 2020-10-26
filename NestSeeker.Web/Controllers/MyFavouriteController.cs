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
    public class MyFavouriteController : ControllerBase
    {


        private readonly IMyFavouriteService _favouriteService;
        public MyFavouriteController(IMyFavouriteService favouriteService)
        {
            this._favouriteService = favouriteService;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllMyFavourites()
        {
            //UserService service = new UserService();
            return Ok(_favouriteService.GetAllMyFavourites());
        }
        [HttpPost("addfavourites")]
        public IActionResult AddFavourite(MyFavourites myFavourites)
        {
            //UserService service = new UserService();
            return Ok(_favouriteService.AddFavourite(myFavourites));
        }
    }
}
