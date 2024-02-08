// Count the number of occurrences of each character and return it as a (list of tuples) in order of appearance. For empty output return (an empty list).

using System;
using System.Linq;
using System.Collections.Generic;
    
public class Kata 
{
  public static List<Tuple<char, int>> OrderedCount(string input) 
  {
       return input
               .GroupBy(x => x)
               .Select(x => Tuple.Create(x.Key, x.Count()))
               .ToList();
  }
}