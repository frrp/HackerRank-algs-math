using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int mean = 70;
        int std = 10;
        int q1 = 80;
        int q23 = 60;
        
        Console.WriteLine(Math.Round(100*(1 - FNormal(mean, std, q1)), 2));
        Console.WriteLine(Math.Round(100*(1 - FNormal(mean, std, q23)), 2));
        Console.WriteLine(Math.Round(100*FNormal(mean, std, q23), 2));
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