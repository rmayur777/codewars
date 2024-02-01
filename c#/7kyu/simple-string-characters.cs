// In this Kata, you will be given a string and your task will be to return a list of ints detailing the count of uppercase letters, lowercase, numbers and special characters, as follows.

// Solve("*'&ABCDabcde12345") = [4,5,5,3]. 
// --the order is: uppercase letters, lowercase, numbers and special characters.

using System.Linq;

public class Solution
{
  public static int [] solve(string s)
  {
    return new[]
    {
        s.Count(char.IsUpper),
        s.Count(char.IsLower),
        s.Count(char.IsDigit),
        s.Count(x => !char.IsLetterOrDigit(x))
    };
  }
}