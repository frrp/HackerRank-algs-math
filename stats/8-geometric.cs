using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        string[] input = Console.ReadLine().Split();
        double p = (double)(Convert.ToInt32(input[0]))/(Convert.ToInt32(input[1]));
        int n = Int32.Parse(Console.ReadLine());
        double result = 0;
        
        for (int k=1; k < n+1; k++)
            result = result + Geometric(k,p);
        Console.WriteLine(Math.Round(result,3));
    }
    
    static double Geometric(int n, double p)
        {
        return (Math.Pow(1-p,n-1)*p);
        }
}