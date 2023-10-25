// Your function will accept three arguments:
// The first and second argument should be numbers.
// The third argument should represent a sign indicating the operation to perform on these two numbers.

// If the sign is not a valid sign, throw an ArgumentException.

public class Kata
{
  public static double Calculator(double a, double b, char op)
  {
    switch(op)
    {
      case '+':
        return a+b;
      case '-':
        return a-b;
      case '*':
        return a*b;
      case '/':
        return a/b;
      default:
        throw new System.ArgumentException("lolo");
    }
  }
}