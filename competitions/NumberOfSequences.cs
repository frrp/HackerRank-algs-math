using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] seq = Array.ConvertAll(a_temp,Int32.Parse);
        int Counter = 0;
        int candidate;
        for (int i = 0; i < n; i++)
            {
            if (seq[i] == -1)
                {
                for (int j=0; j<i; j++)
                    candidate = j;
            }
        }
        Console.WriteLine(Counter);
    }
}