using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15LinkedList
{
    class Solution
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
            Node node = new Node(data);
            if (head == null)
            {
                return node;
            }
            else if (head.next == null)
            {
                head.next = node;
                return head;
            }
            else
            {
                var currentNode = head;
                while (currentNode.next != null)
                    currentNode = currentNode.next;

                currentNode.next = node;
                    
                return head;
            }


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

        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }


    class Node
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
