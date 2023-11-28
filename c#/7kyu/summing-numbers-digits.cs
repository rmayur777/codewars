// Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.

// For example: (Input --> Output)

// 10 --> 1
// 99 --> 18
// -32 --> 5

// Let's assume that all numbers in the input will be integer values.

using System;
public class Kata
{
  public static int SumDigits(int n)
  {
    n = Math.Abs(n);
    int sum = 0;
    while (n != 0) 
    {
      sum += n % 10;
      n  /= 10;
    }
    return sum;
  }
}