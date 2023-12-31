// Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.

// You need to consider the following ratings:

//     Terrible: tip 0%
//     Poor: tip 5%
//     Good: tip 10%
//     Great: tip 15%
//     Excellent: tip 20%

// The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:

//     "Rating not recognised" in Javascript, Python and Ruby...
//     ...or null in Java
//     ...or -1 in C#

// Because you're a nice person, you always round up the tip, regardless of the service.

using System;
public class Kata
{
  public static int CalculateTip(double amount, string rating) =>
    rating.ToLower() switch
    {
       "terrible" => 0,
        "poor" => (int)Math.Ceiling(amount * 0.05),
        "good" => (int)Math.Ceiling(amount * 0.1),
        "great" => (int)Math.Ceiling(amount * 0.15),
        "excellent" => (int)Math.Ceiling(amount * 0.2),
        _ => -1,
        };
}

using System.Collections.Generic;
using System;

public class Kata
{
  private static Dictionary<string, double> tip = new Dictionary<string, double>() {
        {"terrible" , 0} ,
        {"poor", 0.05} ,
        {"good", 0.1}, 
        {"great", 0.15}, 
        {"excellent", 0.2}
      };
      
  public static int CalculateTip(double amount, string rating)   
      => tip.ContainsKey(rating.ToLower()) ? (int)Math.Ceiling(tip[rating.ToLower()] *  amount) : -1;
}