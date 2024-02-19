// If the winner is George Saint Pierre he will obviously say:

//     "I am not impressed by your performance."

// If the winner is Conor McGregor he will most undoubtedly say:

//     "I'd like to take this chance to apologize.. To absolutely NOBODY!"

// Good Luck! 

using System;

public static class Kata
{
  public static string Quote(string fighter)
  {
    return fighter.ToLower() == "conor mcgregor" ? @"I'd like to take this chance to apologize.. To absolutely NOBODY!" : @"I am not impressed by your performance.";
  }
}