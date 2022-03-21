using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace WeatherAPI.DataProvider
{
  public class LocationFromFile : ILocationProvider
  {
    private readonly IEnumerable<Location> _locations;

    public LocationFromFile(string filePath) 
    {
      string json = File.ReadAllText(filePath);

      _locations = JsonSerializer.Deserialize<IEnumerable<Location>> (json);
    }
    public Location GetLocation(string name)
    {
      return _locations.Where(location => location.Name == name).FirstOrDefault();
    }
  }
}
