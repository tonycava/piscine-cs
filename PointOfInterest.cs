using System;

namespace CSharpDiscovery.Quest03
{
  public class PointOfInterest
  {
    public double Latitude = 0;   
    public double Longitude  = 0;   
    public string Name = "";

    public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

  }
}