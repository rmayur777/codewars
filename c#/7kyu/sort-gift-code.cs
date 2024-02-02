// Write a function called sortGiftCode/sort_gift_code/SortGiftCode that accepts a string containing up to 26 unique alphabetical characters, and returns a string containing the same characters in alphabetical order.
// Examples (Input -- => Output):

// "abcdef"                      -- => "abcdef"
// "pqksuvy"                     -- => "kpqsuvy"
// "zyxwvutsrqponmlkjihgfedcba"  -- => "abcdefghijklmnopqrstuvwxyz"

using System.Linq;
public class Kata
{
    public static string SortGiftCode(string code)
    {
        return string.Join("", code.OrderBy(v => v));
    }
}