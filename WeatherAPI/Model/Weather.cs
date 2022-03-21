using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherAPI
{
  public class Weather
  {
    [JsonPropertyName("coord")]
    public LocationValues Coordinates {get;set;}

    [JsonPropertyName("main")]
    public EnvironmentValues Environment { get; set; }

    [JsonPropertyName("wind")]
    public WindValues Wind { get; set; }

    [JsonPropertyName("weather")]
    public List<WeatherValues> WeatherInformation { get; set; }
  }

  public class LocationValues 
  {
    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

    [JsonPropertyName("lat")]
    public double Latitude { get; set; }
  }

  public class EnvironmentValues
  {
    [JsonPropertyName("temp")]
    public float Temperature { get; set; }

    [JsonPropertyName("pressure")]
    public float Pressure { get; set; }

    [JsonPropertyName("humidity")]
    public float Humidity { get; set; }

    [JsonPropertyName("temp_min")]
    public float MinimalTemperature { get; set; }

    [JsonPropertyName("temp_max")]
    public float MaximalTemperature { get; set; }
  }

  public class WindValues
  {
    [JsonPropertyName("speed")]
    public float Windspeed { get; set; }

    [JsonPropertyName("deg")]
    public float Direction { get; set; }
  }

  public class WeatherValues
  {
    [JsonPropertyName("description")]
    public string Description { get; set; }
  }
}
