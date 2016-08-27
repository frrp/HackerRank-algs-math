using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        int N = Int32.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int [] values = new int[N];
        int s = 0;
        for (int z = 0; z < N; z++)
            {
            values[z] = Convert.ToInt32(input[z]);
            s = s + values[z];
            }
        
        double mean = (double)(s / (double)N);
        double SquaredDistSum = 0.0;
        for (int z = 0; z < N; z++)
            SquaredDistSum = SquaredDistSum + Math.Pow((values[z] - mean),2);
            
        double sigma = Math.Sqrt((double)SquaredDistSum/N);
        Console.WriteLine(Math.Round(sigma,1));
    }
}