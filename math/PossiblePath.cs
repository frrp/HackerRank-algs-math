using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
    	int T = Int32.Parse(Console.ReadLine());
    	for (int z = 0; z < T; z++)
            {
    		string[] input = Console.ReadLine().Split();
        	int Px = Convert.ToInt32(input[0]);
        	int Py = Convert.ToInt32(input[1]);
        	int Qx = Convert.ToInt32(input[2]);
        	int Qy = Convert.ToInt32(input[3]);
            if (GCD(Math.Abs(Px), Math.Abs(Py)) == GCD(Math.Abs(Qx), Math.Abs(Qy)))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            }
	}

    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
