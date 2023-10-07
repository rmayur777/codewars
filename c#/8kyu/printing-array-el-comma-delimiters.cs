// Input: Array of elements

// ["h","o","l","a"]

// Output: String with comma delimited elements of the array in th same order.

// "h,o,l,a"

using System;
using System.Linq;

public class Kata
{
  public static string PrintArray(object[] array)
  {
    return string.Join(",", array.Select(a => a.GetType().IsArray ? string.Join(",", (object[])a) : a));
  }
}