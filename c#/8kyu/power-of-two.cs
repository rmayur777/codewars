// Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n ( inclusive ).
// Examples

// n = 0  ==> [1]        # [2^0]
// n = 1  ==> [1, 2]     # [2^0, 2^1]
// n = 2  ==> [1, 2, 4]  # [2^0, 2^1, 2^2]

using System.Numerics;
using System.Linq;

public class Kata
{
  public static BigInteger[] PowersOfTwo(int n)
  {
    return (from x in Enumerable.Range(0, n+1) select BigInteger.Pow(2, x)).ToArray();
  }
}