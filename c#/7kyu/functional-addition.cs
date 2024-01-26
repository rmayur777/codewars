// Create a function add(n)/Add(n) which returns a function that always adds n to any number

using System;

public static class Kata
{
  public static Func<double, double> Add(double n)
  {
    return x => x + n;
  }
}