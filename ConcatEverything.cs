using System;

namespace CSharpDiscovery.Quest01
{
  public class ConcatEverything_Exercice
  {
    public static string ConcatEverything(params string[] str)
    {
      return String.Concat(str);
    }
  }
}