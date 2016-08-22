using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int N = Int32.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int [] values = new int[N];
        string[] input2 = Console.ReadLine().Split();
        int [] weights = new int[N];
        double nom = 0;
        double denom = 0;
        
        for (int z = 0; z < N; z++)
            {
                values[z] = Convert.ToInt32(input[z]);
                weights[z] = Convert.ToInt32(input2[z]);
                nom = nom + weights[z];
                denom = denom + weights[z] * values[z];
            }
        double mean = denom/(double)nom;
        Console.WriteLine(mean.ToString("0.0"));
    }
}