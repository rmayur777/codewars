// Remove n exclamation marks in the sentence from left to right. n is positive integer.

using System.Linq;
public class Kata
{
  public static string Remove(string s, int n)
  {
    return string.Concat(s.Where(c => c == '!' ? n-- <= 0 : true));
  }
}

using System.Linq;
using System.Text;

public class Kata
{
    public static string Remove(string s, int n)
    {
        var builder = new StringBuilder();
        foreach (var c in s)
        {
            if (c == '!' && n > 0)
                n--;
            else
                builder.Append(c);
        }

        return builder.ToString();
    }
}