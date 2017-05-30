using System;
using System.Collections.Generic;

namespace AnagramProject.Objects
{
  public class Anagram
  {
    private static List<string> _matches = new List<string>{};

    public string CheckAnagram(string test, string word)
    {
      char[] firstArray = test.ToCharArray();
      Array.Sort(firstArray);
      char[] secondArray = word.ToCharArray();
      Array.Sort(secondArray);
      Console.WriteLine(firstArray);
      Console.WriteLine(secondArray);
      if (firstArray.Length == secondArray.Length)
      {
        Console.WriteLine("Length's Match");
        Console.WriteLine(firstArray.Length);
        foreach (char letter in firstArray)
        {
          foreach (char character in secondArray)
          {
            if (letter == character)
            {
              return word;
            }
          }
        }
        return "true";
      }
      else
      {
        return "false";
      }
    }
    public static void DeleteAll()
    {
      _matches.Clear();
    }
  }
}
