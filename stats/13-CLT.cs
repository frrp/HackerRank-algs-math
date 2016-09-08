using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        int mean = 205;
        int std = 15;
        int target = 9800;
        int N = 49;
        int sumMean = N * mean;
        double sumStd = std * Math.Sqrt(N);
        
        Console.WriteLine(Math.Round(100*(FNormal(sumMean, sumStd, target)), 4));
    }   
        
    // the cumulative distribution function for a function with normal distribution is: 
    static double FNormal(double mean, double sigma, double x)
    {
        return (0.5 + 0.5 * Erf( (x-mean) / (sigma * Math.Sqrt(2)) ) );
    }
 
    // error function approximated by Taylor series to O(x^6): 
    static double Erf(double x)
    {
        return (double)(2/Math.Sqrt(Math.PI)) * (x - Math.Pow(x,3)/3 + Math.Pow(x,5)/10);
    }
}