// Given a string s, write a method (function) that will return true if its a valid single integer or floating number or false if its not.

using System;

public class CodeWars
{
  public static bool IsDigit(string s) => double.TryParse(s, out var _);
}