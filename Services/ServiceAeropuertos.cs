using AeropuertosAPJ.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertosAPJ.Services
{
    public class ServiceAeropuertos
    {
        public async Task<AirportList> GetAirportsListAsync()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            string url = "https://services.odata.org/V4/(S(2esholowikwyef30ogqjzbvf))/TripPinServiceRW/Airports";
            string dataJson = await client.DownloadStringTaskAsync(url);
            AirportList airports = JsonConvert.DeserializeObject<AirportList>(dataJson);
            return airports;
        }
        
    }
}
