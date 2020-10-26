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
    public class PropertyTypeController : ControllerBase
    {
        private readonly IPropertyTypeService _propertytypeService;
        public PropertyTypeController(IPropertyTypeService propertytypeService)
        {
            this._propertytypeService = propertytypeService;
        }
        [HttpGet("GetAllPropertytypes")]
        public IActionResult GetAllPropertytype()
        {
            //UserService service = new UserService();
            return Ok(_propertytypeService.GetAllPropertyType());
        }
        [HttpPost("addpropertytype")]
        public IActionResult AddProperty(PropertyType propertytype)
        {
            //UserService service = new UserService();
            return Ok(_propertytypeService.AddProperty(propertytype));
        }
    }
}
