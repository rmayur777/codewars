// Your task is to return a number from a string.

using System;
using System.Linq;
public class Kata
{
  public static int FilterString(string s)
  {
    return int.Parse(new String(s.Where(Char.IsDigit).ToArray()));
  }
}