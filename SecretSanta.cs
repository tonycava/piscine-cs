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
        return dic;
      }
      
      Random rnd = new Random();
      
      for (int i = 0; i < people.Count; i++)
      {
        int indexOfPerson1 = rnd.Next(0, people.Count);
        int indexOfPerson2 = rnd.Next(0, people.Count);
        
        while (indexOfPerson1 == indexOfPerson2) indexOfPerson2 = rnd.Next(0, people.Count);
        
        if (indexOfPerson1 > people.Count || indexOfPerson2 > people.Count) continue;
        
        
        if (dic.ContainsKey(people.ElementAt(indexOfPerson1)) == false)
        {
          
          if (indexOfPerson2 > indexOfPerson1) (indexOfPerson1, indexOfPerson2) = (indexOfPerson2, indexOfPerson1);

          dic.Add(people.ElementAt(indexOfPerson1), people.ElementAt(indexOfPerson2));
            
          if (people.Count == 2) break;
            
          people.Remove(people.ElementAt(indexOfPerson1));
          people.Remove(people.ElementAt(indexOfPerson2));
        }
      }
      dic.Add(people.ElementAt(0), people.ElementAt(1));
      return dic;
    }
  }
}