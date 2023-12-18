// Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

// Examples input/output:

// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false

using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    string inputN = input.ToLower();
    int xCounter = 0;
    int oCounter = 0;
    for(int i = 0; i<inputN.Length; i++){
      if (inputN[i] == 'x') xCounter++;
      else if ( inputN[i] == 'o') oCounter++;
    }
 return xCounter == oCounter;
  }
}

using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
      var forDuplicationAvoid = input.ToUpperInvariant();
      return forDuplicationAvoid.Count(x => x == 'O') == forDuplicationAvoid.Count(x => x == 'X');
  }
}