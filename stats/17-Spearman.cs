using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args) 
    {
        int N = Int32.Parse(Console.ReadLine());
        string[] inputX = Console.ReadLine().Split();
        string[] inputY = Console.ReadLine().Split();
        double [] valuesX = new double[N];
        double [] valuesY = new double[N];
        for (int z = 0; z < N; z++)
            {
            valuesX[z] = Convert.ToDouble(inputX[z]);
            valuesY[z] = Convert.ToDouble(inputY[z]);
            }
        var sortedX = valuesX.OrderBy(d => d).ToArray();
        var sortedY = valuesY.OrderBy(d => d).ToArray();
        int indX;
        int indY;
        double D = 0.0;
        for (int z = 0; z < N; z++)
            {
            indX = Array.IndexOf(sortedX, valuesX[z]) + 1;
            indY = Array.IndexOf(sortedY, valuesY[z]) + 1;
            D = D + Math.Pow(indX-indY,2); 
            }
        double rXY = 1 - (6*D)/(double)(N*(N*N-1));
        Console.WriteLine(Math.Round(rXY,3));
    }
}