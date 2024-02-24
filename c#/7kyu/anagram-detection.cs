// Complete the function to return true if the two arguments given are anagrams of each other; return false otherwise.
// Examples

//     "foefet" is an anagram of "toffee"

//     "Buckethead" is an anagram of "DeathCubeK"

using System;
using System.Linq;

public class Kata
{
  public static bool IsAnagram(string test, string original)
  {
    return SortLower(test) == SortLower(original);
  }
  
  public static string SortLower(string str)
  {
    return String.Concat(str.ToLower().OrderBy(c => c));
  }
}