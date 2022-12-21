using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>() { "red", "blue", "pink", "orange", "gray", "violet" };
            Console.WriteLine("List");
            Console.WriteLine("Count: " + colors.Count);
            Console.WriteLine("Add yellow ");
            colors.Add("yellow");
            Console.WriteLine("Count: " + colors.Count);
            foreach(var i in colors)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine("Remove: red");
            colors.Remove("red");
            foreach (var i in colors)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine("Count: " + colors.Count);

            var queue = new Queue<int>();
            Console.WriteLine("Queue");
            queue.Enqueue(1);
            queue.Enqueue(7);
            queue.Enqueue(4);
            queue.Enqueue(2);
            queue.Enqueue(6);
            queue.Enqueue(5);
            queue.Enqueue(9);
            foreach (var i in queue)
            {
                Console.Write(i + " ");
            }
            queue.Dequeue();
            queue.Enqueue(8);
            queue.Dequeue();
            Console.WriteLine("");
            foreach (var i in queue)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            var stack = new Stack();
            Console.WriteLine("Stack");
            stack.Push(1);
            stack.Push(9);
            stack.Push(3);
            stack.Push(6);
            stack.Push(2);
            stack.Push(5);
            foreach (var i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Push: 7, 4");
            stack.Push(7);
            stack.Push(4);
            foreach (var i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Pop");
            stack.Pop();
            foreach (var i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            var dictionary = new Dictionary<int, string>();
            Console.WriteLine("Dictionary");
            dictionary.Add(1, "Test1");
            dictionary.Add(2, "Test2");
            dictionary.Add(3, "Test3");
            dictionary.Add(4, "Test4");
            dictionary.Add(5, "Test5");
            foreach (var i in dictionary)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Count: " + dictionary.Count());
            Console.WriteLine("ElementAt: 3 = " + dictionary.ElementAt(3));
            Console.WriteLine("First: " + dictionary.First());
            Console.WriteLine("Last: " + dictionary.Last());
            Console.WriteLine("Remove: 4");
            dictionary.Remove(4);
            foreach (var i in dictionary)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }
}
