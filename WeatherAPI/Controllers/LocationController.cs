using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeatherAPI.DataProvider;

namespace WeatherAPI.Controllers
{
  [ApiController]
  [Route("direct")]
  public class LocationController : ControllerBase
  {
    [HttpGet]
    [EnableCors]
    public IEnumerable<Location> Get(string q)
    {
      ILocationProvider locations = new DataProviders().GetLocationProvider();

      Location result = locations.GetLocation(q);

      if (result == null)
      {
        return new List<Location>().ToArray();
      }

      return new List<Location> { result }.ToArray();
    }
  }
}
