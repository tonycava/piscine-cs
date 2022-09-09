using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
  public class NextTrafficLightColor_Exercice
  {
    public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
    {
      if (currentColor == TrafficLightColor.Red) return TrafficLightColor.None;
      
      return (TrafficLightColor) ((int) (currentColor) + 1);
    }
  }
}