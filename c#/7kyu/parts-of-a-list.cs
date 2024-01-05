// Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.

//     Each two non empty parts will be in a pair (or an array for languages without tuples or a structin C - C: see Examples test Cases - )
//     Each part will be in a string
//     Elements of a pair must be in the same order as in the original array.

using System.Linq;

public class PartList
{
  public static string[][] Partlist(string[] arr)
  {
    return arr.Select((s, i) => new[] {string.Join(" ", arr.Take(i)), string.Join(" ", arr.Skip(i))}).Skip(1).ToArray();
  }
}