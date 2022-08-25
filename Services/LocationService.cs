using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace openaq.Services
{
    public class LocationService : ILocationService
    {
        static HttpClient client = new HttpClient();

        private readonly ILogger<LocationService> logger;
        
        public LocationService(ILogger<LocationService> logger)
        {
            this.logger = logger;
        }

        public async Task<Locations> GetLocations(string city, int page, int limit, int offset, string sor)
        {
            logger.LogInformation("Get City Air Quality API...");

            string sort = "desc"; //default sort
            if(page == 0)
            {
                page = 1; //default
            }
            if(limit == 0)
            {
                limit = 100; //default
            }
           
            
            if(string.IsNullOrEmpty(sor))
            {
                sort = sor;    
            }
                        logger.LogInformation("/v2/locations?city=" + city + "&page=" + page + "&limit=" + limit + "&offset=" + offset + "&sort=" + sort);
            var streamTask = client.GetStreamAsync("https://api.openaq.org/v2/locations?city=" + city + "&page=" + page + "&limit=" + limit + "&offset=" + offset + "&sort=" + sort);
            Locations locations = await JsonSerializer.DeserializeAsync<Locations>(await streamTask);

            return locations;
        }

    }
}
