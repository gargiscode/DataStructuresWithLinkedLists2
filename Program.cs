using System;

namespace DataStructuresWithLinkedLists2
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList l = new LinkedList();
            l.AddNode(1);
            l.AddNode(2);
            l.AddNode(3);
            l.AddNode(4);
            l.AddNode(5);
            l.AddNode(6);

            l.traverse();
            Node midNode = l.MiddleNode();
            Console.WriteLine("Middle node is "+midNode.val);
        }
    }

    class Node
    {
        public int val;
        public Node next;

        public Node()
        {
            val = 0;
            next = null;
        }
    }

    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
          
        }

        public void AddNode(int x)
        {
            Node curr = head;

            Node newNode = new Node();
            newNode.val = x;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = newNode;
            }

        }

        public Node MiddleNode()
        {
            Node tortoise = head;
            Node hare = head;

            while (hare != null && hare.next != null)
            {
                hare = hare.next.next;
                tortoise = tortoise.next;
            }
            return tortoise;
        }

        public void traverse ()
        {
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.val);
                curr = curr.next;
            }

        }
    }

    
}
