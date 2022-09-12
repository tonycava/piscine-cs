using System;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
  public class FindLastIndex_Exercice
  {
    public static int? FindLastIndex(int[] tab, int a)
    {
      var find = Array.LastIndexOf(tab, a);
      return find == -1 ? null : find;
    }
  }
}