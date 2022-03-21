namespace WeatherAPI.DataProvider
{
  public class DataProviders
  {
    public ILocationProvider GetLocationProvider()
    {
      return new LocationFromFile("DataSource\\location.json");
    }

    public IWeatherProvider GetWeatherProvider()
    {
      return new WeatherFromFile("DataSource\\weather.json");
    }
  }
}
