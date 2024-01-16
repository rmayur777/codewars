// Complete the function that takes two numbers as input, num and nth and return the nth digit of num (counting from right to left).
// Note

//     If num is negative, ignore its sign and treat it as a positive value
//     If nth is not positive, return -1
//     Keep in mind that 42 = 00042. This means that findDigit(42, 5) would return 0

using System;

public class Kata
{
  public static int FindDigit(int num, int nth)
  {
    return nth <= 0 ? -1 : (int) Math.Abs(num / Math.Pow(10, nth - 1) % 10);
  }
}