// When provided with a letter, return its position in the alphabet.

// Input :: "a"

// Ouput :: "Position of alphabet: 1"

public class Kata
{
    public static string Position(char alphabet)
    {
        return $"Position of alphabet: {alphabet - 96}";
    }
}