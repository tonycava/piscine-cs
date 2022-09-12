using System;
using System.Collections.Generic;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      var people = new HashSet<string> { "Arnaud", "Marie", "Alexandre", "Audrey", "Adrien", "Mathilde", "Théophile", "Hanako" };
      var people2 = new HashSet<string> { "Arnaud", "Marie" };

      var draw = SecretSanta_Exercice.SecretSantaDraw(people);
      var draw2 = SecretSanta_Exercice.SecretSantaDraw(people2);

      Console.WriteLine(draw.Count);
      foreach (KeyValuePair<string, string> pair in draw) {
        Console.WriteLine("{0} is offering to {1}", pair.Key, pair.Value);
      }

      Console.WriteLine("=====================");

      Console.WriteLine(draw2.Count);
      foreach (KeyValuePair<string, string> pair in draw2) {
        Console.WriteLine("{0} is offering to {1}", pair.Key, pair.Value);
      }
    }
  }
}