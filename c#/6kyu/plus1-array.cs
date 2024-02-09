// Given an array of integers of any length, return an array that has 1 added to the value represented by the array.

//     the array can't be empty
//     only non-negative, single digit integers are allowed

// Return nil (or your language's equivalent) for invalid inputs.
// Examples

// Valid arrays

// [4, 3, 2, 5] would return [4, 3, 2, 6]
// [1, 2, 3, 9] would return [1, 2, 4, 0]
// [9, 9, 9, 9] would return [1, 0, 0, 0, 0]
// [0, 1, 3, 7] would return [0, 1, 3, 8]

// Invalid arrays

// [1, -9] is invalid because -9 is not a non-negative integer

// [1, 2, 33] is invalid because 33 is not a single-digit integer

using System.Linq;

namespace Kata
{
  public static class Kata
  {
    public static int[] UpArray(int[] num)
    {
      if (num.Length == 0 || num.Any(a => a < 0 || a > 9))
        return null;
        
      for (var i = num.Length - 1; i >= 0; i--)
      {
        if (num[i] == 9)
        {
          num[i] = 0;
        }
        else
        {
          num[i]++;
          return num;
        }
      }
      return new []{ 1 }.Concat(num).ToArray(); 
    }
  }
}