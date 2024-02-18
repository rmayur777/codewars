// Simple, given a string of words, return the length of the shortest word(s).

// String will never be empty and you do not need to account for different data types.

public class Kata
{
  public static int FindShort(string s)
  {
    string[] word = s.Split(' ');
    int sw = int.MaxValue;
    foreach(string w in word)
    {
      if(w.Length < sw)
      {
        sw = w.Length;
      }
    }
    return sw;
  }
}