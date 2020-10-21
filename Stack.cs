using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice
{
    class Stack
    {
        Node top;
       
        public Stack()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            if (top == null)
                top = new Node(value, null);
            else
                top = new Node(value, top);
        }

        public void Display()
        {
            Node itr = top;
            while(itr!=null)
            {   
                Console.Write(itr.Value + "-");
                itr = itr.Next;
            }
            Console.WriteLine("end");
        }

        public void Peek()
        {
            if (top == null)
                Console.WriteLine("Stack is Empty");
            else
                Console.WriteLine("Top is " + top.Value);
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Cant Pop, Stack is Empty");
            }
            else
                top = top.Next;
        }
    }
}
