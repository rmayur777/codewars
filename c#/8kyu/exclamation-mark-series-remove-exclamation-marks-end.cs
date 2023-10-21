// Remove all exclamation marks from the end of sentence.
// Examples

// "Hi!"     ---> "Hi"
// "Hi!!!"   ---> "Hi"
// "!Hi"     ---> "!Hi"
// "!Hi!"    ---> "!Hi"
// "Hi! Hi!" ---> "Hi! Hi"
// "Hi"      ---> "Hi"

using System;
public class Kata
{
  public static string Remove(string s)
  {
    return s.TrimEnd('!');
  }
}