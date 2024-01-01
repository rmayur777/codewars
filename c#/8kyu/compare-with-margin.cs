// Create a function close_compare that accepts 3 parameters: a, b, and an optional margin. The function should return whether a is lower than, close to, or higher than b.

// Please note the following:

//     When a is close to b, return 0.
//         For this challenge, a is considered "close to" b if margin is greater than or equal to the absolute distance between a and b.

// Otherwise...

//     When a is less than b, return -1.

//     When a is greater than b, return 1.

// If margin is not given, treat it as if it were zero.

// Assume: margin >= 0

using System;
public class Kata
{
  public static int CloseCompare(double a, double b, double margin = 0)
  {
    double diff = Math.Abs(a-b);
    if(margin >= diff){
      return 0;
    }else if ( a < b){
      return -1;
    }else{
      return 1;
    }
  }
}