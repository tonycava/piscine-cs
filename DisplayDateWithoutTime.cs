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

      if (years.ToString().Length == 4) return Format(day) + "/" + Format(month) + "/" + years.ToString();
      if (years.ToString().Length == 3) return Format(day) + "/" + Format(month) + "/" + "0" + years.ToString();
      if (years.ToString().Length == 2) return Format(day) + "/" + Format(month) + "/" + "00" + years.ToString();
      return Format(day) + "/" + Format(month) + "/" + "000" + years.ToString();
    }


    public static string Format(int toFormat)
    {
    if (toFormat < 9) return "0" + toFormat.ToString();
    return toFormat.ToString();
    }
  }
}