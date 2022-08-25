using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using openaq.Models;

namespace openaq.Services
{
    public interface ILocationService
    {
        Task<Locations> GetLocations(string city, int page, int limit, int offset, string sort);
       
    }
}
