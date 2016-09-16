using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int N = 5;
        int X = 80;
        int [] valuesX = new int[N];
        int [] valuesY = new int[N];
        int sumX = 0;
        int sumY = 0;
        int squaredXSum = 0;
        int XYSum = 0;
        string[] input = new string[2];
        for (int z = 0; z < N; z++)
            {
            input = Console.ReadLine().Split();
            valuesX[z] = Convert.ToInt32(input[0]);
            valuesY[z] = Convert.ToInt32(input[1]);
            sumX = sumX + valuesX[z];
            sumY = sumY + valuesY[z];
            squaredXSum = squaredXSum + valuesX[z]*valuesX[z];
            XYSum = XYSum + valuesX[z]*valuesY[z];
            }
        double meanX = sumX/(double)N;
        double meanY = sumY/(double)N;
        double b = (N*XYSum - sumX*sumY)/(double)(N*squaredXSum - sumX*sumX);
        double a = meanY - b*meanX;
        Console.WriteLine(Math.Round(a+b*X,3));
    }
}