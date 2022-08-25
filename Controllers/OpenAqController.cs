using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using openaq.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using openaq.Models;
using openaq.Services;

namespace openaq.Controllers
{
   

    [ApiController]
    [Route("cityairquality")]
    public class OpenAqController : ControllerBase
    {

        private readonly ILocationService lservice;
        private readonly ILogger<OpenAqController> logger;

        public OpenAqController(ILocationService lservice, ILogger<OpenAqController> logger)
        {
            this.lservice = lservice;
            this.logger = logger;
        }


       

        // GET: All Air Quality by City
        [HttpGet]
        public async Task<Locations> GetCityAirQuality(string city, int page, int limit, int offset, string sort)
        {
            // First the location ID based on the city
            Locations locations = null;
            locations = await lservice.GetLocations(city, page, limit, offset, sort);

            //locations.results[0];
            

            logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}");
            return locations;

        }

    }

}