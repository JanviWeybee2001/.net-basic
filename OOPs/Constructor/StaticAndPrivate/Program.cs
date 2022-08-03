using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPrivate
{

    class Example
    {

        public static int Counter;

        // private constructor
        private Example()
        {
            Counter = 5; // here is 5
        }

        // static constructor
        static Example()
        {
            Counter = 10;
        }

        // public constructor
        public Example(int counter)
        {
            Console.WriteLine("public Example(int counter) ... {0}", counter);
            Counter += counter;
            Console.WriteLine("AFTER === public Example(int counter) ... {0}", Counter);
        }

        public static int GetCounter()
        {
            return Counter;
        }

        public class NestedExample
        {
            // internal instance
            public void Test()
            {
                //Internal Instance
                Example ex = new Example(); 
            }
        }

        ~Example()
        {
            Console.WriteLine("------------ EXample DEStructor---------------");
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Example ex = new Example(); 
            // we're not able to create a instance of class which have private constructor. 
            // So, we are directly access the name of class.

            //NestedExample nestedExample = new NestedExample();

            Console.WriteLine("Counter: {0}", Example.GetCounter());

            Example ex = new Example(1);
            Console.WriteLine("BY pass the value Counter: {0}", Example.GetCounter());

            _ = new Example(45);
            Console.WriteLine("BY SECOND pass the value Counter: {0}", Example.GetCounter());

            Console.WriteLine(2 + 4);  // check where destructor is called
            Console.WriteLine("Counter: {0}", Example.GetCounter());


            Console.WriteLine(20 + 4); // check where destructor is calledS

            Console.WriteLine(2 + 40);  // check where destructor is called

            Console.ReadLine();
        }
    }
}

// Always, Destructor is call at the last of the program execution...
