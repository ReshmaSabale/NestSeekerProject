using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NestSeeker.Service.Interface;

namespace NestSeeker.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            this._propertyService = propertyService;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllUsers()
        {
            //UserService service = new UserService();
            return Ok(_propertyService.GetAllUser());
        }
        [HttpPost("addproperty")]
        public IActionResult AddProperty(Property property)
        {
            //UserService service = new UserService();
            return Ok(_propertyService.AddProperty(property));
        }
       // [HttpPut("updateproperty")]
        /*  public IActionResult UpdateProperty(Property property)
          {
              //UserService service = new UserService();
              return Ok(_propertyService.UpdateProperty(property));
          }
          [HttpPut("deleteproperty/{propertyId}")]
          public IActionResult DeleteProperty(int propertyId)
          {
              //UserService service = new UserService();
              return Ok(_propertyService.DeleteProperty(propertyId));
          }*/

    }

}
