// Given a mixed array of number and string representations of integers, add up the non-string integers and subtract the total of the string integers.

// Return as a number.

using System.Linq;

public class Kata
{
  public static int DivCon(object[] objArray)
  {
    return objArray.Sum(o => (o is int ? 1 : -1) * int.Parse(o.ToString()));
  }
}