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
            if (itr == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            head = head.Next;
        }

        public void PopLast()
        {
            itr = head;
            
            if(itr==null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            Node prev=null;
            while(itr.Next!=null)
            {
                prev = itr;
                itr = itr.Next;
            }
            prev.Next = null;
        }

        public int Search(int value)
        {
            itr = head;
            if(itr==null)
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int pos = 0;
            while(itr!=null)
            {
                pos++;
                if (itr.Value == value)
                    return pos;
                itr = itr.Next;
            }
            Console.WriteLine("Element not found");
            return -1;
        }

        public void InsertAfter(int prev, int value)
        {
            int pos = Search(prev);
            if(pos!=-1)
            {
                InsertAt(pos, value);
            }
        }

        public void Delete(int value)
        {
            itr = head;
            if(itr==null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            Node prev = null;
            while(itr.Next!=null)
            {
                if (itr.Value == value)
                {
                    prev.Next = itr.Next;
                    return;
                }
                else
                {
                    prev = itr;
                    itr = itr.Next;
                }
            }

            Console.WriteLine("Element Not Found");
        }

        public int Size()
        {
            itr = head;
            int pos = 0;
            while (itr != null)
            {
                pos++;
                itr = itr.Next;
            }
            return pos;
        }

        public void SortedLinkedList()
        {
            int size = Size();

            Node itr=head;
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size-i-2;j++)
                {
                    if (itr.Value>itr.Next.Value)
                    {
                        int temp = itr.Value;
                        itr.Value = itr.Next.Value;
                        itr.Next.Value = temp;
                    }
                    itr = itr.Next;
                }
            }
        }
    }
}