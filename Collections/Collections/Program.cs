using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare list using List<>();
            Console.WriteLine("======C# List<T> class is used to store and fetch elements======\n");

            var names1 = new List<string>();
            names1.Add("Janvi");  
            names1.Add("Rushita"); 

            Console.WriteLine("----------------names1 value add using Add method in List----------------");
            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");


            var names2 = new List<String>() { "Janvi", "Krishna" };

            Console.WriteLine("----------------names2 value declare with varible in List----------------");
            foreach (var name in names2)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


            // Declare HashSet using HashSet<>();
            Console.WriteLine("======C# HashSet class can be used to store, remove or view elements. it does not store duplicate elements======\n");

            var names3 = new HashSet<string>();
            names3.Add("Janvi");  
            names3.Add("Rushita");
            names3.Add("Rushita"); // Not add in names3, it is duplicate.

            Console.WriteLine("----------------names3 value add using Add method in HashSet----------------");
            foreach (var name in names3)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");


            var names4 = new HashSet<string>() { "Janvi", "Krishna", "Krishna" };
            Console.WriteLine("----------------names4 value declare with varible in HashSet----------------");
            foreach (var name in names4)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


            // Declare SortedSet using SortedSet<>();
            Console.WriteLine("======C# SortedSet class can be used to store, remove or view elements. It maintains ascending order and does not store duplicate elements======\n");

            var names5 = new SortedSet<string>();
            names5.Add("Rushita");
            names5.Add("Janvi");
            names5.Add("Rushita"); // Not add in names3, it is duplicate.

            Console.WriteLine("----------------names5 value add using Add method in SortedSet----------------");
            foreach (var name in names5)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");


            var names6 = new SortedSet<string>() {"Krishna", "Janvi", "Krishna", "Krishna" };
            Console.WriteLine("----------------names6 value declare with varible in SortedSet----------------");
            foreach (var name in names6)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


            // Declare stack using Stack<>();
            Console.WriteLine("======C# Stack<T> class is used to push and pop elements. It uses the concept of Stack that arranges elements in LIFO (Last In First Out) order. It can have duplicate elements======\n");

            var names7 = new Stack<string>();
            names7.Push("Rushita");
            names7.Push("Janvi");
            names7.Push("Krishna");
            names7.Push("Bunny");

            Console.WriteLine("----------------names7 value add using Push method in Stack----------------");
            foreach (var name in names7)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Peek element: " + names7.Peek() + " by names7.Peek();");
            Console.WriteLine("Pop: " + names7.Pop() + " by names7.Pop();");
            Console.WriteLine("After Pop, Peek element: " + names7.Peek() + " by names7.Peek();");
            Console.ReadLine();


            // Declare queue using Queue<>();
            Console.WriteLine("======C# Queue<T> class is used to Enqueue and Dequeue elements. It uses the concept of Queue that arranges elements in FIFO (First In First Out) order======\n");

            var names8 = new Queue<string>();
            names8.Enqueue("Bunny");
            names8.Enqueue("Rushita");
            names8.Enqueue("Janvi");
            names8.Enqueue("Krishna");

            Console.WriteLine("----------------names8 value add using Enqueue method in Queue----------------");
            foreach (var name in names8)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Peek element: " + names8.Peek() + " by names8.Peek();");
            Console.WriteLine("Dequeue: " + names8.Dequeue() + " by names8.Dequeue();");
            Console.WriteLine("After Dequeue, Peek element: " + names8.Peek() + " by names8.Peek();");
            Console.ReadLine();

            Console.WriteLine("======C# LinkedList<T> class uses the concept of linked list. It allows us to insert and delete elements fastly======\n");

            var names9 = new LinkedList<string>();
            names9.AddLast("Janvi");
            names9.AddLast("Rushita");
            names9.AddFirst("Krishna");
            names9.AddFirst("Banny");

            Console.WriteLine("----------------names9 value add using AddLast and AddFirst in LinkedList----------------");
            foreach (var name in names9)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
