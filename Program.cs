using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            CustomLinkedList list = new CustomLinkedList();
            list.AddElement(1);
            list.AddElement(5);
            list.AddElement(6);

            list.InsertAt(2, 10);
            list.InsertAt(2, 30);
            list.InsertAt(4, 60);

            list.Display();
            Console.WriteLine();
            list.Pop();
            list.Display();

            Console.WriteLine();
            list.PopLast();
            list.Display();

            Console.WriteLine("\nElement found at position: " + list.Search(5));
            Console.WriteLine("Element found at position: " + list.Search(10));

            list.InsertAfter(10, 50);
            list.Display();

            list.Delete(10);
            Console.WriteLine();
            list.Display();
            Console.WriteLine("\nThe size of the list is: " + list.Size());

            list.SortedLinkedList();
            list.Display();


            Console.WriteLine("\n\nStack");
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push(5);
            stack.Push(7);
            stack.Peek();
            stack.Display();
            stack.Pop();
            stack.Display();
            stack.Pop();
            stack.Display();
            stack.Pop();
            stack.Pop();

            Console.WriteLine("\nQueue");
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(1);
            queue.Display();

            queue.Dequeue();
            queue.Display();

            Console.Read();
        }
    }
}
