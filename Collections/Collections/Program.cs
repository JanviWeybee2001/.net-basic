using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{

    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    public class customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

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


            var names6 = new SortedSet<string>() { "Krishna", "Janvi", "Krishna", "Krishna" };
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

            // Declare LinkedList using LinkedList<>();
            Console.WriteLine("\n======C# LinkedList<T> class uses the concept of linked list. It allows us to insert and delete elements fastly======\n");

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

            //insert new element after "Janvi"  
            LinkedListNode<string> node = names9.Find("Janvi");
            names9.AddAfter(node, "Ansi");

            //insert new element before Rushita
            node = names9.Find("Rushita");
            names9.AddBefore(node, "Arshita");

            Console.WriteLine("\n----------------names9 value add using find method with AddAfter and AddBefore in LinkedList----------------");
            foreach (var name in names9)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");
            Console.ReadLine();

            // Declare Dictionary using  Dictionary<TKey, TValue>();
            Console.WriteLine("======C# Dictionary<TKey, TValue> class uses the concept of hashtable. It stores values on the basis of key. It contains unique keys only. By the help of key, we can easily search or remove elements======\n");

            var names10 = new Dictionary<int, string>();
            names10.Add(3, "Janvi");
            names10.Add(2, "Rushita");
            names10.Add(1, "Krishna");
            names10.Add(4, "Bunny");

            Console.WriteLine("\n----------------names10 value add using add method in Dictionary and Iterate with the help of 'KeyValuePair<int, string> kv in names10' with kv.Key and  kv.Value----------------");
            foreach (KeyValuePair<int, string> kv in names10)
            {
                Console.WriteLine(kv.Key + " = " + kv.Value);
            }
            Console.ReadLine();

            // Declare Dictionary using  Dictionary<TKey, TValue>();
            Console.WriteLine("======C# SortedDictionary<TKey, TValue> class uses the concept of hashtable. It stores values on the basis of key. It contains unique keys and maintains ascending order on the basis of key======\n");

            var names11 = new SortedDictionary<int, string>();
            names11.Add(4, "Bunny");
            names11.Add(2, "Rushita");
            names11.Add(1, "Janvi");
            names11.Add(3, "Krishna");

            Console.WriteLine("\n----------------names11 value add using add method in Dictionary and Iterate with the help of 'KeyValuePair<int, string> kv in names11' with kv.Key and kv.Value----------------");
            foreach (KeyValuePair<int, string> kv in names11)
            {
                Console.WriteLine(kv.Key + " = " + kv.Value);
            }
            Console.ReadLine();

            // Declare SortedList using SortedList<TKey, TValue>;
            Console.WriteLine("======C# SortedList<TKey, TValue> is an array of key/value pairs. It stores values on the basis of key. The SortedList<TKey, TValue> class contains unique keys and maintains ascending order on the basis of key======\n");

            var names12 = new SortedList<int, string>();
            names12.Add(4, "Bunny");
            names12.Add(2, "Rushita");
            names12.Add(1, "Janvi");
            names12.Add(3, "Krishna");

            Console.WriteLine("\n----------------names12 value add using add method in SortedList and Iterate with the help of 'KeyValuePair<int, string> kv in names12' with kv.Key and kv.Value----------------");
            foreach (KeyValuePair<int, string> kv in names12)
            {
                Console.WriteLine(kv.Key + " = " + kv.Value);
            }
            Console.ReadLine();

            Console.WriteLine("\nNOTE:- \n\nSortedList<TKey, TValue> class uses less memory than SortedDictionary<TKey, TValue>. It is recommended to use SortedList<TKey, TValue> if you have to store and retrieve key/valye pairs. The SortedDictionary<TKey, TValue> class is faster than SortedList<TKey, TValue> class if you perform insertion and removal for unsorted data.\n\n");
            Console.ReadLine();

            Console.WriteLine("\n\n===========Generic Class===========\n\n");

            GenericClass<string> gen = new GenericClass<string>("This is generic class");
            GenericClass<int> genI = new GenericClass<int>(101);
            GenericClass<char> getCh = new GenericClass<char>('I');

            Console.ReadLine();

            //var months = new List<string>();
            //months.Add("January");
            //months.Add("February");
            //months.Add("March");
            //months.Add("April");

            //Console.WriteLine(string.Join(", ", months));

            Console.WriteLine("===========make customer class List===========");
            customer customer1 = new customer()
            {
                ID = 1,
                Name = "Janvi",
                Salary = 35000
            };

            customer customer2 = new customer()
            {
                ID = 2,
                Name = "Rushita",
                Salary = 38000
            };

            customer customer3 = new customer()
            {
                ID = 3,
                Name = "Krishna",
                Salary = 25000
            };

            List<customer> customers = new List<customer> { customer1, customer2, customer3 };
            customers.Insert(2, customer2);
            customers.Insert(0, customer3);

            Console.WriteLine("Index of Customer 1 = {0} by 'customers.IndexOf(customer1)' ", customers.IndexOf(customer1));

            Console.WriteLine("\n\nLength of Customers List is {0} by customers.Count\n", customers.Count);
            foreach(customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }

            Console.ReadLine();
        }
    }
}