// Given a sequence of numbers, find the largest pair sum in the sequence.

// For example

// [10, 14, 2, 23, 19] -->  42 (= 23 + 19)
// [99, 2, 2, 23, 19]  --> 122 (= 99 + 23)

using System.Linq;
public class Kata
{
  public static int LargestPairSum(int[] numbers)
     => numbers.OrderByDescending(x=>x).Take(2).Sum();
}

using System;
using System.Linq;
public class Kata
{
  public static int LargestPairSum(int[] numbers)
  {
    
    int largest = int.MinValue;
    int second = int.MinValue;
    foreach (int i in numbers)
    {
     if (i > largest)
     {
      second = largest;
        largest = i;
        }
      else if (i > second)
        second = i;
        }
    return largest + second;
    }
}