using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        string[] input = Console.ReadLine().Split();
        int N = Convert.ToInt32(input[0]);
        int D = Convert.ToInt32(input[1]);
        input = Console.ReadLine().Split();
        int [] values = new int[N];
 
        for (int z = 0; z < N; z++)
        {
                values[z] = Convert.ToInt32(input[z]);
            }
        for (int z = 0; z < D; z++)
        {
            int goal = Int32.Parse(Console.ReadLine());
            int days = 10000000;
            int [] candidate = new int[2];

            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    if (values[j]-values[i] == goal)
                    {
                        if (days > j-i)
                        {
                            days = j-i;
                            candidate[0] = i+1;
                            candidate[1] = j+1;
                        }
                    }
                }
            }
            if (days == 0)
                Console.WriteLine(-1);
            else
            {
                Console.WriteLine("{0} {1}", candidate[0], candidate[1]);
            }
        }
    }
}