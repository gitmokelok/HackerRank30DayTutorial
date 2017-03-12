using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day_18_Queues_And_Stacks
{
    class Solution
    {
        Stack<char> MyStack;
        Queue<char> MyQueue;

        public Solution()
        {
            MyStack = new Stack<char>();
            MyQueue = new Queue<char>();
        }

        public void pushCharacter(char a)
        {
            MyStack.Push(a);
        }

        public void enqueueCharacter(char a)
        {
            MyQueue.Enqueue(a);
        }

        public char popCharacter()
        {
            return MyStack.Pop();
        }

        public char dequeueCharacter()
        {
            return MyQueue.Dequeue();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
