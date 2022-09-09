using System;
using System.Collections.Generic;

namespace CSharpDiscovery.Quest01
{
  public class DoubleArrayForEvenInteger_Exercice
  {
    public static int[] DoubleArrayForEvenInteger(int[] inputTab)
    {
      List<int> list = new List<int>();
      for (int i = 0; i < inputTab.Length; i++)
      {
        if (inputTab[i] % 2 == 1)
        {
          list.Add(inputTab[i] * 2);
        } else
        {
          list.Add(inputTab[i]);
        }
      }
      return list.ToArray();
    }
  }
}