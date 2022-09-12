using System;
using System.Globalization;

namespace CSharpDiscovery.Quest02
{
  public class FromStringToDateTime_Exercice
  {
    public static DateTime FromStringToDateTime(string dateStr)
    {
      var cultureInfo = new CultureInfo("de-DE");
      return DateTime.Parse(dateStr, cultureInfo);
    }
  }
}