using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice
{
    class Queue
    {
        Node head;

        public Queue()
        {
            head = null;
        }

        public void Display()
        {
            Node itr = head;
            while (itr != null)
            {
                Console.Write(itr.Value + "-");
                itr = itr.Next;
            }
            Console.WriteLine("end");
        }

        public void Enqueue(int value)
        {
            if(head == null)
            {
                head = new Node(value, null);
            }
            else
            {
                Node itr = head;
                while(itr.Next!=null)
                {
                    itr = itr.Next;
                }
                itr.Next = new Node(value, null);
            }
        }

        public void Dequeue()
        {
            if (head != null)
                head = head.Next;
            else
                Console.WriteLine("Queue is Empty");
        }
    }
}
