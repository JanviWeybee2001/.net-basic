using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        // User defined function without return type  
        public void Show(string message)
        {
            Console.WriteLine("Hello " + message + " by '+'");
            Console.WriteLine("Hello {0} by ','", message);
            // No return statement  
        }

        // User defined function  
        public void Show(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }

        public void Showref(ref int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }

        public void Showout(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value  
        }

        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Program program = new Program(); // Creating Object  
            program.Show("Janvi Desai"); // Calling Function

            int val = 50;
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function " + val);

            Console.WriteLine("Value before calling the function " + val);
            program.Showref(ref val); // Calling Function by passing reference            
            Console.WriteLine("Value after calling the function " + val);

            val = 20;  // In out, initialization is not needed. val= 20 is initialization...

            Console.WriteLine("Value before calling the function " + val);
            program.Showout(out val); // Calling Function by passing reference            
            Console.WriteLine("Value after calling the function " + val);

            double sum = AddNumber(12.5,23.3);
            Console.WriteLine($"Sum = {sum}");

            (int,string) variable1 =  GetPosition();
            Console.WriteLine(variable1);
            Console.WriteLine(variable1.Item1);
            Console.WriteLine(variable1.Item2);

            int prod=0, sumTotal = 0;
            SumAndProd(2, 5,ref prod, ref sumTotal);
            Console.WriteLine(prod + " " + sumTotal);
            Console.ReadLine();
        }

        public static double AddNumber(double firstNum, double secondNum) => firstNum + secondNum;

        public static (int, string) GetPosition()
        {
            return (1,"One");
        }

         public static void SumAndProd(int x, int y, ref int prod, ref int sumTotal)
        {
             prod = x * y;
            sumTotal = x + y;
        }

    }
}
