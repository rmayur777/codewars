// Find the sum of the odd numbers within an array, after cubing the initial integers. The function should return undefined/None/nil/NULL if any of the values aren't numbers.

using System.Linq;

public class Kata
{
  public static int CubeOdd(int[] arr)
  {
    return arr.Sum(i => i % 2 == 0 ? 0 : i * i * i);
  }
}

using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static int CubeOdd(int[] arr)
  {
    List<int> oddNumbers = new List<int>();
    for(int i =0; i< arr.Length; i++)
      {
       if(arr[i] % 2 != 0) oddNumbers.Add(arr[i]*arr[i]*arr[i]);
    }
    return oddNumbers.Sum();
    
  }
}