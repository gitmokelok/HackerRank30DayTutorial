using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Day24RemoveDuplicates
{
    public class Solution
    {
        public static Node removeDuplicates(Node head)
        {
            //Write your code here
            var first = new Node(head.data);
            var last = first;
            while (head != null)
            {
                if (head.next != null && head.data == head.next.data)
                {
                    head = head.next;
                    continue;
                }
                head = head.next;
                last.next = head;
                last = last.next;

            }
            return first;

        }
        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
}
