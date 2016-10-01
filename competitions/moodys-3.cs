using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int modulus = (int)Math.Pow(10,9)+7;
        int N = Int32.Parse(Console.ReadLine());
        for (int z = 0; z < N; z++)
            {
            string input = Console.ReadLine();
            char[] ExpChar = input.ToCharArray();
            int l = ExpChar.Length;
            int stars = 0;
            string str1 = "";
            string str2 = "";
            long times = 1;
            if (ExpChar[0] == '*' || ExpChar[l-1] == '*')
                Console.WriteLine("Syntax Error");
            else
                foreach (char c in ExpChar)
                {
                    if (c == '*' && str2 != "")
                        {
                        if (stars == 2)
                            {
                            str1 = Evaluate(str1,str2).ToString();
                            stars = 0;
                            str2 = "";
                            }
                        else
                            {
                            times *= long.Parse(str1);
                            str1 = str2;
                            str2 = "";
                            stars = 0;
                        }
                        }
                    if (c != '*' && stars == 0)
                        str1 += c;
                    if (c == '*')
                        stars += 1;
                    if (stars == 3)
                        {
                        Console.WriteLine("Syntax Error");
                        break;
                        }
                    else
                        if (c != '*' && stars > 0)
                            str2 += c;
                 }
            if (stars == 2)
                Console.WriteLine(times*Evaluate(str1,str2) % modulus);
            else
                Console.WriteLine(times*long.Parse(str1)*long.Parse(str2) % modulus);
        }
    }
    
    
    static long Evaluate (string str1, string str2)
        {
        int modulus = (int)Math.Pow(10,9)+7;
        long N1 = Int32.Parse(str1);
        long N2 = Int32.Parse(str2);
        return (long)Math.Pow(N1,N2) % modulus;
        }
}