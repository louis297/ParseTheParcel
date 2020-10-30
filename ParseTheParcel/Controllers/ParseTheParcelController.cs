using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParseTheParcel.Config;
using ParseTheParcel.DTOs.ParseTheParcelDTOs;
using ParseTheParcel.ResponseModels.ParseTheParcelResponseModels;
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
        private readonly IParseTheParcelService _service;
        private readonly ILogger<ParseTheParcelController> _logger;
        public ParseTheParcelController(IParseTheParcelService service, ILogger<ParseTheParcelController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Route("parsetheparcel")]
        public ParseTheParcelResponseModel ParseTheParcel([FromQuery]ParcelDTO parcel)
        {
            try
            {
                double? price = _service.ParseTheParcel(parcel);
                if (price is double priceValue)
                {
                    _logger.LogInformation(ParseTheParcelEventID.Done, $"The parcel {parcel.Length}x{parcel.Breadth}x{parcel.Height} @ {parcel.Weight / 1000.0} kg costs ${priceValue}");
                    return new ParseTheParcelResponseModel
                    {
                        isSuccess = true,
                        Message = "",
                        Price = priceValue
                    };
                }
                else
                {
                    // parcel is too big or too heavy
                    _logger.LogInformation(ParseTheParcelEventID.TooLarge, $"The parcel {parcel.Length}x{parcel.Breadth}x{parcel.Height} @ {parcel.Weight / 1000.0} kg is too large");
                    return new ParseTheParcelResponseModel
                    {
                        isSuccess = false,
                        Message = "The parcel is either too large or too heavy",
                        Price = 0
                    };
                }
            } catch(Exception e){
                _logger.LogInformation(ParseTheParcelEventID.InternalError, e, $"Exception when parsing parcel {parcel.Length}x{parcel.Breadth}x{parcel.Height} @ {parcel.Weight / 1000.0} kg.");
                throw e;
            }
        }

        [HttpGet]
        [Route("reloadrules")]
        // TODO: add auth control to reload rules function
        public IActionResult ReloadRules()
        {
            _service.ReloadRules();
            return Ok("Reload rules successfully");
        }
    }
}
