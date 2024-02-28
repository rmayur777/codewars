// This kata is designed to test your ability to extend the functionality of built-in classes. In this case, we want you to extend the built-in Array class with the following methods: square(), cube(), average(), sum(), even() and odd().

// Explanation:

//     square() must return a copy of the array, containing all values squared
//     cube() must return a copy of the array, containing all values cubed
//     average() must return the average of all array values; on an empty array must return NaN (note: the empty array is not tested in Ruby!)
//     sum() must return the sum of all array values
//     even() must return an array of all even numbers
//     odd() must return an array of all odd numbers

using System;
using System.Linq;

static class Extensions {
  public static int[] Square(this int[] arr) => arr.Select(x => x * x).ToArray();
  public static int[] Cube(this int[] arr) => arr.Select(x => x * x * x).ToArray();
  public static double Average(this int[] arr) => arr.Length == 0 ? Double.NaN : Math.Truncate(arr.Average(x => x));
  public static int Sum(this int[] arr) => arr.Sum(x => x);
  public static int[] Even(this int[] arr) => arr.Where(x => x % 2 == 0).ToArray();
  public static int[] Odd(this int[] arr) => arr.Where(x => x % 2 != 0).ToArray();
}