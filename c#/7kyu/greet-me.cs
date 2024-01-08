// Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

// Example:

// "riley" --> "Hello Riley!"
// "JACK"  --> "Hello Jack!"

public static class Kata
{
  public static string Greet(string name)
  {
    return $"Hello {name.ToUpper()[0] + name.ToLower().Substring(1)}!";
  }
}