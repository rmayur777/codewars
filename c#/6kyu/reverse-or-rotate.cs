// The input is a string str of digits. Cut the string into chunks (a chunk here is a substring of the initial string) of size sz (ignore the last chunk if its size is less than sz).

// If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2, reverse that chunk; otherwise rotate it to the left by one position. Put together these modified chunks and return the result as a string.

// If

//     sz is <= 0 or if str is empty return ""
//     sz is greater (>) than the length of str it is impossible to take a chunk of size sz hence return "".
// s = "123456" gives "234561".

using System;
using System.Linq;

public class Revrot 
{
  public static string RevRot(string strng, int sz)
  {
    return sz == 0
        ? ""
        : string.Concat(Enumerable
            .Range(0, strng.Length / sz)
            .Select(i => strng.Substring(i * sz, sz))
            .Select(s => s.Select(char.GetNumericValue).Sum(d => Math.Pow(d, 3)) % 2 == 0
                ? s.Reverse()
                : s[1..] + s[0])
            .SelectMany(x => x));
  }
}