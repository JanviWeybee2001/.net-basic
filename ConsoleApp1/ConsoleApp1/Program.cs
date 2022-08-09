using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class check
    {
        public static int Age = 9;

        public check(int age)
        {
            Age = age;
        }

        public void print(int age)
        {
            Console.WriteLine("\n\n" + Age);
            Age = age;
            Console.WriteLine("\n\n" + Age + " " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int total = a + b;
            Console.Write("Total: {0} + {1} = {2}", a, b, total);
            Console.Write("Hello World!!!..");
            Console.ReadLine();

            check c1 = new check(4);
            c1.print(24);

            check c2 = new check(8);
            c2.print(28);

            Console.ReadLine();
        }
    }
}
