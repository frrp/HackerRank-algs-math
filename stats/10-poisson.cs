using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args) 
    {
        string[] input = Console.ReadLine().Split();
        double lambdaA, lambdaB;
        Double.TryParse(input[0], out lambdaA);
        Double.TryParse(input[1], out lambdaB);
        // Poisson: var(X) = lambda = E(X) 
        // => E(X^2) = lambda + lambda^2
        Console.WriteLine(Math.Round(160.0 + 40.0 * (lambdaA + Math.Pow(lambdaA, 2)), 3));
        Console.WriteLine(Math.Round(128.0 + 40.0 * (lambdaB + Math.Pow(lambdaB, 2)), 3));
    }   
}