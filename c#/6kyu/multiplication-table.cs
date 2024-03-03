// Your task, is to create N×N multiplication table, of size provided in parameter.

// For example, when given size is 3:

// 1 2 3
// 2 4 6
// 3 6 9

// For the given example, the return value should be:

// [[1,2,3],[2,4,6],[3,6,9]]

using System;

namespace Solution
{
  class Solution
  {
    public static int[,] MultiplicationTable(int size)
    {
      int[,] multiTable = new int[size,size];
      for (int i = 0 ; i < size  ; i++)
        for(int j = 0 ; j < size  ; j++)
          multiTable[i , j] = (i+1) * (j+1);
      return multiTable;
    }
  }
}