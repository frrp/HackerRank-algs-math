using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++)
            {
            string s = Console.ReadLine();
            Console.WriteLine(isBalanced(s));
            }
        }
    
    static string isBalanced(string s) {
        var st = new Stack<char>();
        char[] charArr = s.ToCharArray();
        foreach (var c in charArr) {
            switch (c) {
                case '{':
                case '(':
                case '[':
                    st.Push(c);
                    break;
                case '}':
                    if (st.Count==0 || (st.Pop() != '{'))
                        return "NO";
                    break;
                case ')':
                    if (st.Count==0 || (st.Pop() != '('))
                        return "NO";
                    break;
                case ']':
                    if (st.Count==0 || (st.Pop() != '['))
                        return "NO";
                    break;
            }
        }
       return st.Count==0 ? "YES" : "NO";
    }
}