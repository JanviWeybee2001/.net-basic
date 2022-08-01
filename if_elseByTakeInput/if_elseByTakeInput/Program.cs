using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_elseByTakeInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
            switch (num)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break;
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //for (; ; )
            //{
            //    Console.WriteLine("Infinitive For Loop");
            //}  ctrl + c is used for stop the infinitve loop
            Console.ReadLine();
        }
    }
}
