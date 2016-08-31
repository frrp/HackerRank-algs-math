using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int mean = 20;
        int std = 2;
        double q1 = 19.5;
        int q2A = 20;
        int q2B = 22;
        
        Console.WriteLine(Math.Round(FNormal(mean, std, q1), 3));
        Console.WriteLine(Math.Round(FNormal(mean, std, q2B) - FNormal(mean, std, q2A), 3));
    }   
    
    // standard normal distribution:
    static double StdNormal(double x)
    {
        return (double)(Math.Pow(Math.E,-(x*x/2)) / Math.Sqrt(2*Math.PI));
    }

    // every normal distribution can be represented as standard normal distribution: 
    static double Normal(double mean, double sigma, double x)
    {
        return (double)(StdNormal((x-mean)/sigma) / sigma);
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