using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        int N = 100;
        double mean = 500;
        double std = 80;
        double distPercent = 0.95;
        double sampleStd = std / (double)Math.Sqrt(N);
        double zScore = 1.96;
        double A = mean - zScore * sampleStd;
        double B = mean + zScore * sampleStd;
        Console.WriteLine(Math.Round(A, 2));
        Console.WriteLine(Math.Round(B, 2));
    }   
}