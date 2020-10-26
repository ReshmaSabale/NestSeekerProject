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
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentService)
        {
            this._documentService = documentService;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllDocuments()
        {
            //UserService service = new UserService();
            return Ok(_documentService.GetAllDocuments());
        }
        [HttpPost("adddocument")]
        public IActionResult AddDocument(Document document)
        {
            //UserService service = new UserService();
            return Ok(_documentService.AddDocument(document));
        }
    }
}
