// A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.

// Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor words will be given as a string with each word separated by a space. Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.

using System;
using System.Linq;

public class Kata
{
  static string FirstToUpper(string input)
  {
    var s = input.ToCharArray();
    s[0] = Char.ToUpper(s[0]);
    return new String(s);
  }

  public static string TitleCase(string title, string minorWords="")
  {
    if (String.IsNullOrEmpty(title)) return title;
    
    var titleWords = title.Split(' ').Select(w => w.ToLower());
    var minWords = (minorWords ?? "").Split(' ').Select(w => w.ToLower());
    
    return FirstToUpper(String.Join(" ", titleWords.Select(w => minWords.Contains(w) ? w : FirstToUpper(w))));
  }
}