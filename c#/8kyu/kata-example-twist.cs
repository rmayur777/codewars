// This is an easy twist to the example kata (provided by Codewars when learning how to create your own kata).

// Add the value "codewars" to the array websites 1,000 times.


using System;

public static class Kata 
{
  public static string[] Websites = new string[1000];
  static Kata()
  {
    for(int i = 0; i < 1000; i++)
      Websites[i] = "codewars";
  }
}