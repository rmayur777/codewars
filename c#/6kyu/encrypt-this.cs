
//     Your message is a string containing space separated words.
//     You need to encrypt each word in the message using the following rules:
//         The first letter must be converted to its ASCII code.
//         The second letter must be switched with the last letter
//     Keepin' it simple: There are no special characters in the input.

// Examples:

// Kata.EncryptThis("Hello") == "72olle"
// Kata.EncryptThis("good") == "103doo"
// Kata.EncryptThis("hello world") == "104olle 119drlo"

using System.Linq;

namespace EncryptThis
{
    public class Kata
    {
        public static string EncryptThis(string s)
          => string.Join(" ", s.Split(' ').Select(Encrypt));
        
        private static string Encrypt(string s)
        {
          if(string.IsNullOrEmpty(s)) return "";
          else if(s.Length == 1) return $"{(int)s[0]}";
          else if(s.Length == 2) return $"{(int)s[0]}{s[1]}";
          return $"{(int)s[0]}{s.Last()}{s.Substring(2, s.Length-3)}{s[1]}";
        }
    }
}