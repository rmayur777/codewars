//  Find the sum of all multiples of n below m
// Keep in Mind

//     n and m are natural numbers (positive integers)
//     m is excluded from the multiples

// Examples

// Kata.SumMul(2, 9)   => 2 + 4 + 6 + 8 = 20
// Kata.SumMul(3, 13)  => 3 + 6 + 9 + 12 = 30
// Kata.SumMul(4, 123) => 4 + 8 + 12 + ... = 1860
// Kata.SumMul(4, 1)   // throws ArgumentException
// Kata.SumMul(0, 20)  // throws ArgumentException

using System;
public class Kata
{
  public static int SumMul(int n, int m)
  {
    if(m<=n||n<=0){
      throw new ArgumentException();
    }
    var result = 0;
    for(int i=n;i<m;i+=n){
      result+=i;
    }
    return result;
  }
}