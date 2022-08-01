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
            Console.ReadLine();
        }
    }
}
