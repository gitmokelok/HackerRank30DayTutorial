using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23BSTLevelOrder
{
    public class BSTSolution
    {


        private static Queue NodeDataQueue
        { get; set; }

        private static LinkedList<Node> NodeLinkedList
        {get; set;}
        
        //public BSTSolution()
        //{
        //    NodeDataQueue = new Queue<int>();
        //}
        public static void levelOrder(Node root)
        {
            LinkedListNode<Node> tempRoot = new LinkedListNode<Node>(root);


            if (NodeDataQueue == null)
                NodeDataQueue = new Queue();

            if (root != null )
                NodeDataQueue.Enqueue(root.data);

            if (root.left != null)
            {
                NodeDataQueue.Enqueue(root.left.data);
            }
            else
                return;


            if (root.right != null)
            {
                NodeDataQueue.Enqueue(root.right.data);
            }
            else
                return;
               
            if (root.left != null)
                levelOrder(root.left);
            if (root.right != null)
                levelOrder(root.right);

            while (NodeDataQueue.Count > 0)
                Console.Write(NodeDataQueue.Dequeue() + " ");
        }

        public static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }

        }
    }

    public class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    

}
