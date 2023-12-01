// Given a 2D ( nested ) list ( array, vector, .. ) of size m * n, your task is to find the sum of the minimum values in each row.

// For Example:

// [ [ 1, 2, 3, 4, 5 ]        #  minimum value of row is 1
// , [ 5, 6, 7, 8, 9 ]        #  minimum value of row is 5
// , [ 20, 21, 34, 56, 100 ]  #  minimum value of row is 20
// ]

// So the function should return 26 because the sum of the minimums is 1 + 5 + 20 = 26.

using System.Linq;

class Kata
{
  public static int SumOfMinimums(int[,] n)
  {
    return Enumerable.Range(0, n.GetLength(0)) 
                     .Select(x => Enumerable.Range(0, n.GetLength(1)).Select(y => n[x,y]))
                     .Sum(x => x.Min());
  }
}


    // This code appears to define a static method called "SumOfMinimums" in the "Kata" class.
    // The purpose of this method is to calculate and return the sum of minimum values in a given two-dimensional array (matrix).
    // The first line includes the "System.Linq" namespace, which contains several extension methods for querying data.
    // The signature of the static method indicates that it takes a two-dimensional array (n) as input and returns an integer.
    // The next line uses the Enumerable.Range method from the System.Linq namespace.
    // This method generates a sequence of integers within a specified range.
    // In this case, it generates a sequence of integers starting from 0 and ending at n.GetLength(0) - 1.
    // Here, GetLength(0) returns the length of the first dimension (rows) of array 'n'.
    // Then, using the Select method from System.Linq, it iterates through each element x in the generated sequence and performs an operation on it.
    // Within this Select operation, another Enumerable.Range call is made.
    // This one generates a sequence of integers starting from 0 and ending at n.GetLength(1) - 1.
    // Here, GetLength(1) returns the length of second dimension (columns) of array 'n'.
    // This inner Select operation is used to iterate through each element y in this generated inner sequence and perform an operation on it.
    // Inside this inner Select operation, it retrieves a specific element by accessing the matrix 'n' with coordinates [x,y], i.e., row index = x and column index = y.
    // Thus far, we have selected individual elements by traversing the matrix through nested iterations.
    // Finally, outside these Select operations, using the Sum method again from System.Linq, it sums up all the minimum values
    // The code will return the sum of all the minimum values in an array.