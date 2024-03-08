// Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.
// Examples

// "312" should return "333122"

using System;
using System.Linq;

public class Digits
{
  public static string Explode(string s)
  {
    return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));
  }
}