//Complete the function that calculates the area of the red square, when the length of the circular arc A is given as the input. Return the result rounded to two decimals.

using System;
public class Kata
{
  public static double SquareArea(double A)
  {
    return Math.Round(Math.Pow(4*A/(2*Math.PI),2),2);
  }
}