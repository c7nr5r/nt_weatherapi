using System.Text.Json.Serialization;

namespace WeatherAPI
{
  public class Location
  {
    [JsonPropertyName("lat")]
    public double Latitude { get; set; }

    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }
  }
}
