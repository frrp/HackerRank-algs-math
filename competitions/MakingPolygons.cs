using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int Bound = a.Sum()/2;
        int Counter = 0;
        
        for (int i=0; i<n; i++)
            {
            if (a[i] >= Bound)
                {
                int cuts = a[i] / Bound; 
                Counter = Counter + cuts;
                }
            }
        Console.WriteLine(Counter);
        }
}
