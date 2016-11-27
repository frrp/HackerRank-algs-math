using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /*
        all solutions:
        4 9 2 3 5 7 8 1 6
        2 7 6 9 5 1 4 3 8
        6 1 8 7 5 3 2 9 4
        8 3 4 1 5 9 6 7 2
        */
        int[] inp = new int[9];
        //int MagicSum = 15;
        string[] solutions = new string[4];
        solutions[0] = "4 9 2 3 5 7 8 1 6";
        solutions[1] = "2 7 6 9 5 1 4 3 8";
        solutions[2] = "6 1 8 7 5 3 2 9 4";
        solutions[3] = "8 3 4 1 5 9 6 7 2";
        
        int[][] sols = new int[4][9];
        for (int i = 0; i<4; i++)
                sols[i] = Array.ConvertAll(solutions[i].Split(' '),Int32.Parse);
        
        for (int i = 0; i<3; i++){
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j<3; j++)
                inp[3*i+j] = Convert.ToInt32(input[j]);
            }
        
        int temp = 0;
        int min = Int32.MaxValue;
        for (int i = 0; i<4; i++){
            for (int j = 0; j<9; j++){
                temp = Math.Abs(sols[i][j] - inp[j]);
                if (temp < min)
                    min = temp;
            }
        }
        Console.WriteLine(min);
    }
}