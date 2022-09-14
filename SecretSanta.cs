using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpDiscovery.Quest02
{
  public class SecretSanta_Exercice
  {
    public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
    {
      Dictionary<string, string> dic = new Dictionary<String, String>();
      Random rnd = new Random();
      
      for (int i = 0; i < people.Count; i++)
      {
        string person = people.ElementAt(i);
        string person2 = people.ElementAt(rnd.Next(0, people.Count));

        while (person == person2) person2 = people.ElementAt(rnd.Next(0, people.Count));
        
        if (!dic.ContainsKey(person)){
          dic.Add(person, person2);
        }
      }
      return dic;
    }
  }
}