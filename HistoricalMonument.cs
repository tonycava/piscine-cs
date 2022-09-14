namespace CSharpDiscovery.Quest03
{
  public class HistoricalMonument : PointOfInterest
  {
    public int BuildYear { get; set; } = 0;
    
    public HistoricalMonument() {}
    public HistoricalMonument(string name, double latitude, double longitude, int buildyear)
    {
      Name = name;
      Latitude = latitude;
      Longitude = longitude;
      BuildYear = buildyear;
    }
    
    public override string ToString()
    {
      return $"{Name} is a historical monument built in {BuildYear}";
    }
  }
}

