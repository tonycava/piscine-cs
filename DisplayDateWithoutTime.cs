using System;

namespace CSharpDiscovery.Quest02
{
  public class DisplayDateWithoutTime_Exercice
  {
    public static string DisplayDateWithoutTime(DateTime date)
    {
      int day = date.Day;
      int month = date.Month;
      int years = date.Year;
      return Format(day) + "/" + Format(month) + "/" + years.ToString();
    }


    public static string Format(int toFormat)
    {
    if (toFormat < 9) return "0" + toFormat.ToString();
    return toFormat.ToString();
    }
  }
}