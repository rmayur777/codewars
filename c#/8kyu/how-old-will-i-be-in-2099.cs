// Your task is to write a function that takes two parameters: the year of birth and the year to count years in relation to. As Philip is getting more curious every day he may soon want to know how many years it was until he would be born, so your function needs to work with both dates in the future and in the past.

// Provide output in this format: For dates in the future: "You are ... year(s) old." For dates in the past: "You will be born in ... year(s)." If the year of birth equals the year requested return: "You were born this very year!"

// "..." are to be replaced by the number, followed and proceeded by a single space. Mind that you need to account for both "year" and "years", depending on the result.

using System;

public static class AgeDiff 
{
  public static string CalculateAge(int birth, int yearTo) 
  {
    if(birth == yearTo)
      return "You were born this very year!";
    
    int x = yearTo - birth;
    string s = Math.Abs(x) > 1 ? "s" : "";
      
    return x > 0 ? $"You are {x} year{s} old." : $"You will be born in {-x} year{s}.";
  }
}