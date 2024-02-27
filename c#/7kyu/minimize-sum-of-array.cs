// Given an array of integers , Find the minimum sum which is obtained from summing each Two integers product .

using System.Linq;

class Kata
{
  public static int MinSum(int[] a)
  {
    return a.OrderBy(n => n).Skip(a.Length / 2).Zip(a.OrderByDescending(n => n).Skip(a.Length / 2), (x, y) => x * y).Sum();
  }
}