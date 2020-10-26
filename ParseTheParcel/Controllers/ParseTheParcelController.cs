using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParseTheParcel.Services.ParseAndParcelServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParseTheParcel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParseTheParcelController : Controller
    {
        private IParseAndParcelService _service;
        public ParseTheParcelController(IParseAndParcelService service)
        {
            _service = service;
        }
    }
}
