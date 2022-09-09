using System;

namespace CSharpDiscovery.Quest01
{
  public class SpellItBackwards_Exercice
  {
    public static string SpellItBackward(string str)
    {
      char[] chars = str.ToCharArray();
      Array.Reverse(chars);
      return new string(chars);
    }
  }
}