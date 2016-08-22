using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args) 
    {
        int N = Int32.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int [] values = new int[N];
        int sum = 0;
        for (int z = 0; z < N; z++)
            {
                values[z] = Convert.ToInt32(input[z]);
                sum = sum + values[z];
            }
        Array.Sort(values);
        
        float mean = (float)sum / N;
        
        float median;
        if (N % 2 == 0)
            median = (float)(values[N/2-1]+values[N/2])/2;
        else
            median = (float)values[(int)N/2];
        
        int mode = 4978;
        /*
        var NumsOccr = from num in values 
            group num by num into g 
            select new { number = g.Key, Occur = g.Count() }; 

         foreach (var item in NumsOccr) 
         { 
          Console.WriteLine(item.number.ToString() + " Occurs " + item.Occurance.ToString()); 
         } 
        */
        Console.WriteLine(mean);
        Console.WriteLine(median);
        Console.WriteLine(mode);
        }
}
/* JAVA
    static int mode() 
    {
        // map frequency to smallest number having that frequency (we are not concerned with larger numbers having same frequency)
        HashMap<Integer, Integer> occurrences = new LinkedHashMap<Integer, Integer>();
        for(int i = 1; i <= array.length; i++) { 
            int current = array[i - 1];
            int count = 1;
            for(int j = i; j < array.length; j++) { 
                if(current == array[j]) {
                    count++;
                }
            }
            // if our map doesn't contain any value for this frequency
            if(occurrences.get(count) == null) {
                occurrences.put(count, current);
            }
        }
        
        // find minimum number that occurs a maximum number of times in array
        return occurrences.get( Collections.max(occurrences.keySet(), null) );
    }
*/
