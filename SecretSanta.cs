using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpDiscovery.Quest02
{
  public class SecretSanta_Exercice
  {
    public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
    {
      Console.WriteLine(string.Join("==>", people));
      
      Dictionary<string, string> dic = new Dictionary<String, String>();
      
      if (people.Count == 2)
      {
        dic.Add(people.ElementAt(0), people.ElementAt(1));
        dic.Add(people.ElementAt(1), people.ElementAt(0));
        return dic;
      }
      
      Random rnd = new Random();
      
      for (int i = 0; i < people.Count; i++)
      {
        string person = people.ElementAt(i);
        int indexOfPerson = rnd.Next(0, people.Count);

        if (dic.ContainsKey(person) == false)
        {
          dic.Add(person, people.ElementAt(indexOfPerson));
        }
      }
      return dic;
    }
  }
}