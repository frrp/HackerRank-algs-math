using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static int _MAX = 6; // size of matrix
    static int _OFFSET = 2; // hourglass width
    static int[][] matrix = new int[_MAX][_MAX];
    static int maxHourglass = -63; // initialize to lowest possible sum (-9 x 7)
    
    /** Given a starting index for an hourglass, sets maxHourglass
    *   @param i row 
    *   @param j column 
    **/
    static void hourglass(int i, int j)
    {
        int tmp = 0; // current hourglass sum
        
        // sum top 3 and bottom 3 elements
        for(int k = j; k <= j + _OFFSET; k++)
        {
            tmp += matrix[i][k]; 
            tmp += matrix[i + _OFFSET][k]; 
        }
        // sum middle element
        tmp += matrix[i + 1][j + 1]; 
        
        if(maxHourglass < tmp)
            maxHourglass = tmp;
    }

   static void Main(String[] args) 
   {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++)
        {
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        // find maximum hourglass
        for(int i=0; i < _MAX - _OFFSET; i++)
            for(int j=0; j < _MAX - _OFFSET; j++)
                hourglass(i, j);
            
        Console.WriteLine(maxHourglass);
    }
}

