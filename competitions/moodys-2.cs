using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(input[0]);
        int k = Convert.ToInt32(input[1]);
        
        double[] P = new double[n];
        double[] X = new double[n];
        double[] Y = new double[n];
        double[] res = new double[n];
        string[] p = Console.ReadLine().Split(' ');
        string[] x = Console.ReadLine().Split(' ');
        string[] y = Console.ReadLine().Split(' ');
        decimal result = 0.00M;
        for (int i = 0; i < n; i++)
        {
            P[i] = Convert.ToDouble(p[i]);
            X[i] = Convert.ToDouble(x[i]);
            Y[i] = Convert.ToDouble(y[i]);
            res[i] = P[i]*X[i]-(1-P[i])*Y[i];
        }
        Array.Sort(res);
        for (int j = n-1; j >= n-k; j--)
            if (res[j]>0)
                result = result + (decimal)res[j];
        Console.WriteLine(Math.Round(result,2).ToString());
    }
}