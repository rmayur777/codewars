// Given a string and an array of integers representing indices, capitalize all letters at the given indices.

// For example:

//     capitalize("abcdef",[1,2,5]) = "aBCdeF"
//     capitalize("abcdef",[1,2,5,100]) = "aBCdeF". There is no index 100.

// The input will be a lowercase string with no spaces and an array of digits.

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static string Capitalize(string s, List<int> idxs)
  => string.Concat(s.Select((c,i)=> idxs.Contains(i) ? char.ToUpper(c) : c));
}