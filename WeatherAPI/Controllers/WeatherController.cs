using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using WeatherAPI.DataProvider;

namespace WeatherAPI.Controllers
{
  [ApiController]
  [Route("weather")]
  public class WeatherController : ControllerBase
  {
    [HttpGet]
    [EnableCors]
    public Weather Get(string lon, string lat)
    {
      IWeatherProvider weathers = new DataProviders().GetWeatherProvider();

      NumberFormatInfo treatDotAsDecimalSeparator = new NumberFormatInfo { NumberDecimalSeparator = "." };
      return weathers.GetWeather(Convert.ToDouble(lon, treatDotAsDecimalSeparator), Convert.ToDouble(lat, treatDotAsDecimalSeparator));
    }
  }
}
