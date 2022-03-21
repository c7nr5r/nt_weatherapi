using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace WeatherAPI.DataProvider
{
  public class WeatherFromFile : IWeatherProvider
  {
    private readonly IEnumerable<Weather> _weathers;

    public WeatherFromFile(string filePath) 
    {
      string json = File.ReadAllText(filePath);

      _weathers = JsonSerializer.Deserialize<IEnumerable<Weather>>(json);
    }
    public Weather GetWeather(double longitude, double latitude)
    {
      return _weathers.Where(weather => weather.Coordinates.Longitude == longitude && weather.Coordinates.Latitude == latitude).FirstOrDefault();
    }
  }
}
