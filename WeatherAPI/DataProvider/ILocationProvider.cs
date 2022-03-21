namespace WeatherAPI.DataProvider
{
  public interface ILocationProvider
  {
    public Location GetLocation(string name);
  }
}
