/*
problem: Given an n by n chessboard, place n queens on the
          board such that no queen is threatened.
*/
using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] queens = nQueenProblem(n);
      
      for (int i = 0; i < queens.Length; i++)
         Console.WriteLine(queens[i]);
      } 


    static int[] nQueenProblem(int n) 
    {
      int[] queens = new int[n];
      addQueen(0, queens, n);
      return queens;
    }
     

    static void addQueen(int x, int[] queens, int n) 
    {
      for (int i = 0; i < n && 0 == queens[n - 1]; i++) 
      {
        if (safeToAdd(x, i, queens)) 
        {
          queens[x] = i;
          addQueen(x + 1, queens, n);
        }
      }
    }
     

    static bool safeToAdd(int x, int y, int[] queens) 
    {
      for (int i = 0; i < x; i++) 
      {
        if (y == queens[i] || (x - y) == (i - queens[i])
                || (x + y) == (i + queens[i]))
          return false;
      }
      return true;
    }
}