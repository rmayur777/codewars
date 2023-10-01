// Build a function that returns an array of integers from n to 1 where n>0.

// Example : n=5 --> [5,4,3,2,1]

using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] reversed = new int[n];
    for(int i=0;i<n;i++){
      reversed[i]=n-i;
    }
    return reversed;
  }
}