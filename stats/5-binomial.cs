using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        double p = (double)1.09/(1.09+1.0);
        int n = 6;
        double binomial = 0;
        
        for (int k=3; k<7; k++)
            binomial = binomial + (fun(n)/(fun(k)*fun(n-k))) * Math.Pow(p,k) * Math.Pow(1-p,n-k);
        
        Console.WriteLine(Math.Round(binomial,3));
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