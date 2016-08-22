using System;
using System.Collections.Generic;
using System.IO;

static class Solution 
{
    static void Main(String[] args) 
    {
        int N = Int32.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int [] values = new int[N];
        for (int z = 0; z < N; z++)
                values[z] = Convert.ToInt32(input[z]);
        Array.Sort(values);
 
        Console.WriteLine(Median(values.SubArray(0, (int)N/2)));
        Console.WriteLine(Median(values));
        Console.WriteLine(Median(values.SubArray(((int)N/2)+1, (int)N/2)));
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
/* python
input()
X = sorted(map(int,raw_input().split())) 
L,U = X[:len(X)/2],X[int(round(len(X)/2.0)):] 

med = lambda a: (a[(len(a)-1)/2]+a[int(round((len(a)-1)/2.0))])/2 

for i in [L,X,U]:
    print med(i)

*/
