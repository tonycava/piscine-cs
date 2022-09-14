using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
  class Program
  {
    static void Main(string[] str)
    {
      var poi = new PointOfInterest();
      Console.WriteLine(poi.Latitude);
      Console.WriteLine(poi.Longitude);
      Console.WriteLine(poi.Name);

      Console.WriteLine(PointOfInterest.GoogleMapsUrlTemplate);
    }
  }
  public class PointOfInterest
  {
    public double Latitude = 0;   
    public double Longitude  = 0;   
    public string Name = "";

    public static string GoogleMapsUrlTemplate()
    {
      return "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
    }
    
  }
}