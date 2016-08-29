using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        string[] input = Console.ReadLine().Split();
        double p = (double)(Convert.ToInt32(input[0]))/100;
        int n = Convert.ToInt32(input[1]);
        double max2 = 0;
        double min2 = 0;
        
        for (int k=2; k<n+1; k++)
            min2 = min2 + (fun(n)/(fun(k)*fun(n-k))) * Math.Pow(p,k) * Math.Pow(1-p,n-k);
        for (int k=0; k<3; k++)
            max2 = max2 + (fun(n)/(fun(k)*fun(n-k))) * Math.Pow(p,k) * Math.Pow(1-p,n-k);
        
        Console.WriteLine(Math.Round(max2,3));
        Console.WriteLine(Math.Round(min2,3));
    }
    
    static long fun(long a)
        {
            if (a <= 1)
            {
                return 1;}
            else
            {
                long c = a * fun(a - 1);
                return c;
            }
        }
}