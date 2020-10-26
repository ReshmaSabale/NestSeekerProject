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
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionTypeService _transactiontypeService;
        public TransactionController(ITransactionTypeService transactiontypeService)
        {
            this._transactiontypeService = transactiontypeService;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllTransactionType()
        {
            //UserService service = new UserService();
            return Ok(_transactiontypeService.GetAlltransactiontypes());
        }
        [HttpPost("addtransactiontype")]
        public IActionResult AddITransactionTypeService(TransactionType transactionType)
        {
            //UserService service = new UserService();
            return Ok(_transactiontypeService.AddTransactionType(transactionType));
        }
    }
}
