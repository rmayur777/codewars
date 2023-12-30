// Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the list/array.

using System.Linq;

public static class Kata
{
  public static int[] Take(int[] arr, int n) => arr.Take(n).ToArray();
}