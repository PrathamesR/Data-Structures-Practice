using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }
    }


    class CustomLinkedList
    {
        Node head;
        private Node itr;

        public CustomLinkedList()
        {
            this.head = null;
        }

        public void AddElement(int value)
        {
            itr = head;
            if (itr == null)
                this.head = new Node(value, null);
            else
            {
                while (itr.Next != null)
                    itr = itr.Next;
                itr.Next = new Node(value, null);
            }
        }

        public void Display()
        {
            Node node;
            if (head == null)
                Console.WriteLine("The list is empty");
            else
            {
                node = head;
                while (node != null)
                {
                    Console.Write(node.Value + "->");
                    node = node.Next;
                }
            }

            Console.Write("null");
        }

        public void InsertAt(int pos, int value)
        {
            if (pos < 1)
                Console.WriteLine("Invalid Position Entered");
            else
            {
                Node itr = head;
                Node prev=head;
                for(int i=1;i<pos;i++)
                {
                    prev = itr;
                    itr = itr.Next;
                }
                Node temp = prev.Next;
                Node newNode= new Node(value, temp);
                prev.Next = newNode;
            }
        }

        public void Pop()
        {
            head = head.Next;
        }
    }
}
