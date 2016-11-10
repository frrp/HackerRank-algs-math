using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) {
        MyQueue q = new MyQueue();
        
        int n = Int32.Parse(Console.ReadLine());

        while (n > 0) {
            string[] temp = Console.ReadLine().Split(' ');
            int choice = Convert.ToInt32(temp[0]);
            if(choice == 1) {
                int val = Convert.ToInt32(temp[1]);
                q.enqueue(val);
                } 
            else if(choice == 2)
                q.dequeue();    
            else if(choice == 3)
                q.printFirst();
            n--;
        }
    }
}

public class MyQueue 
{
    Stack<Int32> s1, s2;

    public MyQueue(){
        s1 = new Stack<Int32>();
        s2 = new Stack<Int32>();
    }

    public void enqueue(int x){
        s1.Push(x);
    }

    public int dequeue(){
        int x = -1;
        while(s1.Count != 0)
            s2.Push(s1.Pop());
        if(s2.Count != 0)
            x = s2.Pop();
        while(s2.Count != 0)
            s1.Push(s2.Pop());
        return x;
    }
    
    public void printFirst(){
        int x = -1;
        while(s1.Count != 0)
            s2.Push(s1.Pop());
        if(s2.Count != 0)
            x = s2.Peek();
        while(s2.Count != 0)
            s1.Push(s2.Pop());
        Console.WriteLine(x);
    }
}
