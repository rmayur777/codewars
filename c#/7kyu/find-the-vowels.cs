// We want to know the index of the vowels in a given word, for example, there are two vowels in the word super (the second and fourth letters).

// So given a string "super", we should return a list of [2, 4].

// Some examples:
// Mmmm  => []
// Super => [2,4]
// Apple => [1,5]
// YoMama -> [1,2,4,6]

// NOTES

//     Vowels in this context refers to: a e i o u y (including upper case)
//     This is indexed from [1..n] (not zero indexed!)

using System.Linq;

public class Kata
{
  public static int[] VowelIndices(string word)
  {
    return word.Select((x, i) => ++i).Where(x => "aoueiyAEIOUY".Contains(word[x - 1])).ToArray();
  }
}


/*This code is a C# implementation of a function called `VowelIndices`. This function takes a string `word` as input and returns an array of integers representing the indices of the vowels in the word.

The implementation uses the LINQ library in C# to achieve this functionality. The LINQ library provides a set of extension methods that allow for querying and manipulating data in a concise and expressive way.

Let's break down the code step by step:

1. `word.Select((x, i) => ++i)`: This part of the code uses the `Select` method from LINQ to iterate over each character `x` in the `word` string along with its index `i`. The `++i` increments the index by 1, so that the indices start from 1 instead of 0. This is done because the problem statement asks for the indices to be 1-based.

2. `.Where(x => "aoueiyAEIOUY".Contains(word[x - 1]))`: This part of the code uses the `Where` method from LINQ to filter the characters based on a condition. The condition checks if the character at index `x - 1` (remember that the indices were incremented by 1 in the previous step) is a vowel. The vowels are defined as the characters in the string `"aoueiyAEIOUY"`.

3. `.ToArray()`: This part of the code converts the filtered characters into an array of integers.

4. Finally, the resulting array of indices is returned as the output of the function.

In summary, this code uses LINQ to iterate over each character in the input word, filter out the vowels, and return an array of the indices of those vowels.*/