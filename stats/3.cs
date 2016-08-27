using System;
using System.Collections.Generic;
using System.IO;

static class Solution 
{
    static void Main(String[] args) 
    {
        int N = Int32.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        string[] input2 = Console.ReadLine().Split();
        int [] X = new int[N];
        int [] F = new int[N];
        int S = 0;
        for (int z = 0; z < N; z++)
            {
            X[z] = Convert.ToInt32(input[z]);
            F[z] = Convert.ToInt32(input2[z]);
            S = S + F[z];
            }
        int [] values = new int[S];
        int x = 0;
        int count = 0;
        foreach (int f in F)
            {
            for (int i = 0; i < f; i++)
                {
                values[x] = X[count];
                x++;    
                }
            count++;
            }
        Array.Sort(values);
        float result = Median(values.SubArray(((int)S/2)+1, (int)S/2)) - Median(values.SubArray(0, (int)S/2));
        Console.WriteLine(result);
    }
    
    static T[] SubArray<T>(this T[] data, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }
    
    public static float Median (int[] values)
    {
        int N = values.Length;
        if (N % 2 == 0)
            return (float)(values[N/2-1]+values[N/2])/2;
        else
            return (float)values[(int)N/2];
    }
}
