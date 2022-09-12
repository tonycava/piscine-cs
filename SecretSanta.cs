using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharpDiscovery.Quest02 {
  public class SecretSanta_Exercice {
    public static Dictionary<string, string> SecretSantaDraw(HashSet<string> people) {
      Random rdm = new Random();
      Dictionary<string, string> result = new();
      int counter = 0;
      var shuffled = people.ToArray().OrderBy(s => rdm.Next()).ToArray();
      foreach (string s in people) {
        while (s == shuffled[0]) {
          shuffled = shuffled.ToArray().OrderBy(s => rdm.Next()).ToArray();
        }
        result[s] = shuffled[0];
        shuffled = shuffled.Where(it => it != shuffled[0]).ToArray();
        counter++;
      }
      return result;
    }
  }
}