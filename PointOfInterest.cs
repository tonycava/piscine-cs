using System;

namespace CSharpDiscovery.Quest03
{

  public class PointOfInterest
  {
    public double Latitude { get; set; } = 0;   
    public double Longitude { get; set; } = 0;   
    public string Name { get; set; } = "";

    public PointOfInterest()
    {
      Name = "Bordeaux Ynov Campus";
      Latitude = 44.854186;
      Longitude = -0.5663056;
    }
    
    public PointOfInterest(string name, double latitude, double longitude)
    {
      Name = name;
      Latitude = latitude;
      Longitude = longitude;
    }

    // https://www.google.com/maps/place/Bordeaux+Ynov+Campus/@44.854186,-0.5663056,15z/
    // https://www.google.com/maps/place/Bordeaux+Ynov+Campus@44.854186/@-0.5663056,15z/
    
    public string GetGoogleMapsUrl()
    {
      return $"https://www.google.com/maps/place/{Name.Replace(' ', '+')}/@{Latitude},{Longitude},15z/";
    }
    
    
  }
  
  class Program
  {
    static void Main(string[] str)
    {
      var DefaultPoint = new PointOfInterest();
      Console.WriteLine(DefaultPoint.GetGoogleMapsUrl());

      var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
      Console.WriteLine(ParisCampus.GetGoogleMapsUrl());
    }
  }
}