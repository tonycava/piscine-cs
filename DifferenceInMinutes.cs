﻿using System;

namespace CSharpDiscovery.Quest02
{
  public class DifferenceInMinutes_Exercice
  {
    public static double DifferenceInMinutes(DateTime start, DateTime end)
    {
      var ts = end - start;
      return ts.TotalMinutes;
    }
  }
}