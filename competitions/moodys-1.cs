using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args) 
    {
            int N = Int32.Parse(Console.ReadLine());
            int max = 0;
            int min;
            int sum;
            int[] profits = new int[3];
            for (int i = 0; i < N; i++)
            {
                sum = 0;
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                    profits[j] = Convert.ToInt32(input[j]);
                min = profits.Min();
                for (int j = 0; j < 3; j++)
                    {
                    if (profits[j] > min)
                        sum = sum + profits[j];
                    }
                if (sum > max)
                    max = sum;
            }
        Console.WriteLine(max);
    }
}