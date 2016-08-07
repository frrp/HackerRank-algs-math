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
        	Console.WriteLine("{0} {1}", 2 * Qx - Px, 2 * Qy - Py);
        }
	}
}