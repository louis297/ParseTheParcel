using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParseTheParcel.Config;
using ParseTheParcel.DTOs.ParseTheParcelDTOs;
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
        public void ParseTheParcel([FromQuery]ParcelDTO parcel)
        {
            try
            {
                double? price = _service.ParseTheParcel(parcel);
                if (price is double priceValue)
                {
                    _logger.LogInformation(ParseTheParcelEventID.Done, $"The parcel {parcel.Length}x{parcel.Breadth}x{parcel.Height} @ {parcel.Weight / 1000.0} kg costs ${priceValue}");
                }
                else
                {
                    // parcel is too big or too heavy
                    _logger.LogInformation(ParseTheParcelEventID.TooLarge, $"The parcel {parcel.Length}x{parcel.Breadth}x{parcel.Height} @ {parcel.Weight / 1000.0} kg is too large");
                }
            } catch(Exception e){
                _logger.LogInformation(ParseTheParcelEventID.InternalError, e, $"Exception when parsing parcel {parcel.Length}x{parcel.Breadth}x{parcel.Height} @ {parcel.Weight / 1000.0} kg.");
            }
        }
    }
}
