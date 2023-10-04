// Task

// Given a list of unique numbers sorted in ascending order, return a new list so that the values increment by 1 for each index from the minimum value up to the maximum value (both included).
// Example

// Input:  1,3,5,6,7,8 Output: 1,2,3,4,5,6,7,8

using System.Collections.Generic;
using System.Linq;

public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
  {
    return Enumerable.Range(numbers.First(), numbers.Last() - numbers.First() + 1).ToList();
  }
}