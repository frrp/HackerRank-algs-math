using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    const double e = 2.71828;
    
    static void Main(String[] args) 
    {
        double lambda = Double.Parse(Console.ReadLine());
        int k = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Math.Round(Poisson(k, lambda), 3));
    }
    
    static double Poisson(int k, double lambda)
    {
        return (double)((Math.Pow(lambda,k)*Math.Pow(e, -lambda)) / Fact(k));
    }

    static long Fact(long a)
    {
        if (a <= 1)
        {
            return 1;}
        else
        {
            long c = a * Fact(a - 1);
            return c;
        }
    }
}