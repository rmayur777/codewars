// Write function parseFloat which takes an input and returns a number or Nothing if conversion is not possible.

public class Kata
{
  public static double? ParseF(object s = null)
  {
    return double.TryParse(s?.ToString(), out var result) ? result : (double?) null;
  }
}