using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int n = Int32.Parse(Console.ReadLine());
        int max = 0;
        Stack<StackNode> stack = new Stack<StackNode>();

        while (n > 0) {
            string[] temp = Console.ReadLine().Split(' ');
            int choice = Convert.ToInt32(temp[0]);
            if(choice == 1) {
                int val = Convert.ToInt32(temp[1]);
                max = Math.Max(val, max);
                stack.Push(new StackNode(val, max));
            } 
            else if(choice == 2) {
                if(stack.Count != 0)
                    stack.Pop();
                // reset max
                if(stack.Count == 0)
                    max = 0;
                else
                    max = stack.Peek().curMax;
            } 
            else if(choice == 3) {
                if(stack.Count != 0) {
                    Console.WriteLine(stack.Peek().curMax);
                }
            }
            n--;
        }
    }

    class StackNode {
        int val;
        public int curMax;
        public StackNode(int val, int curMax) {
            this.val = val;
            this.curMax = curMax;
        }
        public String toString() {
            return val + " [" + curMax + "]";
        }
    }
}