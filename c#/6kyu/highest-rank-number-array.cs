// Complete the method which returns the number which is most frequent in the given input array. If there is a tie for most frequent number, return the largest number among them.

// Note: no empty arrays will be given.
// Examples

// [12, 10, 8, 12, 7, 6, 4, 10, 12]              -->  12
// [12, 10, 8, 12, 7, 6, 4, 10, 12, 10]          -->  12
// [12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10]  -->   3


using System.Linq;
using System;

public class Kata
{
    public static int HighestRank(int[] arr)
    {
        return arr
          .GroupBy(i => i)
          .OrderByDescending(gr => gr.Count())
          .ThenByDescending(gr => gr.Key)
          .Select(gr => gr.Key)
          .First();
    }
}