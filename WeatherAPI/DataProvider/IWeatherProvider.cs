namespace WeatherAPI.DataProvider
{
  public interface IWeatherProvider
  {
    public Weather GetWeather(double lon, double lat);
  }
}
