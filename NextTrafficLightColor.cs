﻿using CSharpDiscovery.Models;
using System;


namespace CSharpDiscovery.Quest01
{
  public class NextTrafficLightColor_Exercice
  {
    public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
    {
      if (currentColor == TrafficLightColor.None) return TrafficLightColor.None;
      if (currentColor == TrafficLightColor.Red) return TrafficLightColor.Green;
      return (TrafficLightColor) ((int) (currentColor) + 1);
    }
  }
}