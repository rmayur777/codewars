// You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters. Trailing spaces should be removed, and every line must be terminated with a newline character (\n).

// Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.
// Examples

// A size 3 diamond:

//  *
// ***
//  *

// ...which would appear as a string of " *\n***\n *\n"

using System;
using System.Text;

public class Diamond
{
	public static string print(int n)
  {
      if (n%2 == 0 || n<0)
      {
          return null;
      }

      int middle = n/2;
      StringBuilder sb = new StringBuilder();
      for (int index = 0; index < n; index++)
      {
          sb.Append(' ', Math.Abs(middle - index));
          sb.Append('*', n - Math.Abs(middle - index) * 2);
          sb.Append("\n");
      }

      return sb.ToString();
  }
}