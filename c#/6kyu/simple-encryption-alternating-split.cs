// Implement a pseudo-encryption algorithm which given a string S and an integer N concatenates all the odd-indexed characters of S with all the even-indexed characters of S, this process should be repeated N times.

// Examples:

// encrypt("012345", 1)  =>  "135024"
// encrypt("012345", 2)  =>  "135024"  ->  "304152"
// encrypt("012345", 3)  =>  "135024"  ->  "304152"  ->  "012345"

// encrypt("01234", 1)  =>  "13024"
// encrypt("01234", 2)  =>  "13024"  ->  "32104"
// encrypt("01234", 3)  =>  "13024"  ->  "32104"  ->  "20314"

// Together with the encryption function, you should also implement a decryption function which reverses the process.

// If the string S is an empty value or the integer N is not positive, return the first argument without changes.

using System.Linq;

public class Kata
{
    public static string Encrypt(string text, int n)
    {
        if (string.IsNullOrWhiteSpace(text) || n <= 0)
        {
            return text;
        }

        while(n != 0)
        {
            text = string.Concat(text.Where((c, i) => i % 2 == 1).Concat(text.Where((c, i) => i % 2 == 0)));

            n--;
        }

        return text;
    }
    
    public static string Decrypt(string text, int n)
    {
        if (string.IsNullOrWhiteSpace(text) || n <= 0)
        {
            return text;
        }

        while(n != 0)
        {
            string leftPart = string.Concat(text.Take(text.Length/2));
            string rightPart = string.Concat(text.Skip(text.Length/2));

            text = string.Concat(Enumerable.Range(0, text.Length).Select(i => i % 2 == 0 ? rightPart[i/2] : leftPart[i/2]));

            n--;
        }

        return text;
    }
}