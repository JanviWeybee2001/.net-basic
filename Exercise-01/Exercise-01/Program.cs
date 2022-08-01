/*
Enter a number:
5
A
A B A
A B C B A
A B C D C B A
A B C D E D C B A
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=num;i++)
            {
                char printChar = 'A';
                for (int j = 1; j <= i*2-1; j++)
                {
                    if(j<i)
                    {
                        Console.Write(printChar + " ");
                        printChar++;
                    }
                    else
                    {
                        Console.Write(printChar + " ");
                        printChar--;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}