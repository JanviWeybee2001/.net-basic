using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Adultcheck : Exception
{
    public Adultcheck(string message) : base(message)
    {

    }
}

public class Age
{
    public int age;

    public Age(int age)
    {
        this.age = age;
    }

    public void checkAge()
    {
        if (age < 18)
        {
            throw (new Adultcheck("This perosn is not adult"));
        }
    }
}


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------TRY Catch with EXCEption-----------------\n");
            try
            {
                int num1 = 10;
                int num2 = 0;
                Console.WriteLine(num1 / num2);

                Console.WriteLine("TRy complete");  // IT is not RUN beacause TRY thorow ERROR.
            }
            catch(Exception e)
            {
                Console.WriteLine("\nException : {0}\n", e);

                Console.WriteLine("\nCatch Completed"); // IT will executed
            }
            finally
            {
                Console.WriteLine("\nFinally Completed"); // IT will executed
            }

            Console.ReadLine();
            Console.WriteLine("\n\n-----------------TRY Catch without EXCEption-----------------\n");

            try
            {
                int num1 = 10;
                int num2 = 2;
                Console.WriteLine(num1 / num2);

                Console.WriteLine("\nTRy complete");  // IT is not RUN beacause TRY thorow ERROR.
            }
            catch (Exception e)
            {
                Console.WriteLine("\nException : {0}\n", e);

                Console.WriteLine("\nCatch Completed"); // IT will executed
            }
            finally
            {
                Console.WriteLine("\nFinally Completed"); // IT will executed
            }

            Console.WriteLine("\nOutside of TRY CATCH");

            Console.WriteLine("\n\n-----------------User Defined EXCEption-----------------\n");


            Console.WriteLine("\n new age = 11\n");
            Age ag = new Age(11);
            try
            {
                ag.checkAge();
                Console.WriteLine("This person is adult");
            }
            catch(Adultcheck e)
            {
                Console.WriteLine("\n" + e + "\n");
                Console.WriteLine("\nCatch Completed"); // IT will executed
            }

            Console.WriteLine("\n new age = 21\n");
            ag = new Age(21);
            try
            {
                ag.checkAge();
                Console.WriteLine("This person is adult");
            }
            catch (Adultcheck e)
            {
                Console.WriteLine("\n" + e + "\n");
                Console.WriteLine("\nCatch Completed"); // IT will executed
            }

            Console.WriteLine("\nAge is checked");
           
            Console.ReadLine();
        }
    }
}
