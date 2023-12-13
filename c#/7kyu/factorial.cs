// Your task is to write function factorial

using System;

namespace Solution
{
  public static class Program
  {
    public static int factorial(int n) => (n == 0) ? 1 : n * factorial(n-1);
  }
}