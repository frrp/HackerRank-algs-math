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
        //Console.WriteLine(Math.Round(p,3));
        Console.WriteLine(Math.Round(Geometric(n,p),3));
    }
    
    static double Geometric(int n, double p)
        {
        return (Math.Pow(1-p,n-1)*p);
        }
}