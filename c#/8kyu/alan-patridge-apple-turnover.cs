// Your job is simple, if x squared is more than 1000, return It's hotter than the sun!!, else, return Help yourself to a honeycomb Yorkie for the glovebox.

using System;

public class Kata
{
  public static string Apple(object n)
  {
    return Convert.ToDouble(n) * Convert.ToDouble(n) > 1000 ? "It's hotter than the sun!!" :
                                                          "Help yourself to a honeycomb Yorkie for the glovebox.";
  }
}