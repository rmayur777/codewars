// An AI has infected a text with a character!!

// This text is now fully mutated to this character.

// If the text or the character are empty, return an empty string.
// There will never be a case when both are empty as nothing is going on!!

// Note: The character is a string of length 1 or an empty string.
// Example

// text before = "abc"
// character   = "z"
// text after  = "zzz"




using System.Linq;

public class Kata
{
  public static string Contamination(string text, string character)
  {
    return character.Any() ? new string(character[0], text.Length) : "";
  }
}

//t0 create a new string with cetain characyers use new string(char, no of times char will appear)