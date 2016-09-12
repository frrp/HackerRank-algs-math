using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int N = Int32.Parse(Console.ReadLine());
        string[] inputX = Console.ReadLine().Split();
        string[] inputY = Console.ReadLine().Split();
        double [] valuesX = new double[N];
        double [] valuesY = new double[N];
        double sumX = 0.0;
        double sumY = 0.0;
        for (int z = 0; z < N; z++)
            {
            valuesX[z] = Convert.ToDouble(inputX[z]);
            valuesY[z] = Convert.ToDouble(inputY[z]);
            sumX = sumX + valuesX[z];
            sumY = sumY + valuesY[z];
            }
        double meanX = sumX/(double)N;
        double meanY = sumY/(double)N;
        double SquaredDistSumX = 0.0;
        double SquaredDistSumY = 0.0;
        double covXY = 0.0;
        for (int z = 0; z < N; z++)
            {
            SquaredDistSumX = SquaredDistSumX + Math.Pow((valuesX[z] - meanX),2);
            SquaredDistSumY = SquaredDistSumY + Math.Pow((valuesY[z] - meanY),2);
            covXY = covXY + (valuesX[z] - meanX)*(valuesY[z] - meanY);
            }
        covXY = covXY / (double)N;
        double sigmaX = Math.Sqrt((double)SquaredDistSumX/N);
        double sigmaY = Math.Sqrt((double)SquaredDistSumY/N);
        double rhoXY = covXY / (double)(sigmaX*sigmaY);
        Console.WriteLine(Math.Round(rhoXY,3));
    }
}