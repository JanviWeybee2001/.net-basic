using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {

        static void PrintArrays(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }

        static void printArray(int[] arr)
        {
            Console.WriteLine("Printing array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void printMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum element is: " + min);
        }

        // User defined function  
        public void ShowArr(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }

        public void ShowObj(params object[] items) // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr001 = new int[5];  //creating array 
            //int arr[] = new int[5];  //compile time error

            //int[] arr = { 10, 20, 30, 40, 50 };
            //int[] arr = new int[] { 10, 20, 30, 40, 50 };
            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };

            int[,] arr01 = new int[3, 4];//declaration of 2D array  
            //int[,,] arr02 = new int[3, 3, 3];//declaration of 3D array  

            // There are 3 ways to initialize multidimensional array in C# while declaration.

            //int[,] arr = new int[3, 3] = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // We can omit the array size.

            //int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // We can omit the new operator also.

            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            arr001[0] = 10;//initializing array  
            arr001[2] = 20;
            arr001[4] = 30;

            arr01[0, 1] = 10;//initialization  
            arr01[1, 2] = 20;
            arr01[2, 3] = 30;

            //traversing array  
            for (int i = 0; i < arr001.Length; i++)
            {
                Console.WriteLine(arr001[i]);
            }

            foreach (int i in arr001)
            {
                Console.WriteLine(i);
            }

            int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            int[] arr2 = { 12, 23, 44, 11, 54 };
            printArray(arr1);//passing array to function  
            printArray(arr2);

            printMin(arr1);//passing array to function  
            printMin(arr2);


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr01[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }

            //Declaration of Jagged array
            int[][] arr11 = new int[2][];
            arr11[0] = new int[4] {0,1,2,3} ;
            arr11[1] = new int[6];

            // Traverse array elements  
            for (int i = 0; i < arr11.Length; i++)
            {
                for (int j = 0; j < arr11[i].Length; j++)
                {
                    System.Console.Write(arr11[i][j] + " ");
                }
                System.Console.WriteLine();
            }

            int[][] arr21 = new int[3][]{
                new int[] { 11, 21, 56, 78 },
                new int[] { 2, 5, 6, 7, 98, 5 },
                new int[] { 2, 5 }
            };

            for (int i = 0; i < arr21.Length; i++)
            {
                for (int j = 0; j < arr21[i].Length; j++)
                {
                    System.Console.Write(arr21[i][j] + " ");
                }
                System.Console.WriteLine();
            }

            Program program = new Program(); // Creating Object  
            program.ShowArr(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  

            program.ShowObj("Ramakrishnan Ayyer", "Ramesh", 101, 20.50, "Peter", 'A'); // Passing arguments of variable length  


            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            // Creating an empty array  
            int[] arr201 = new int[6];
            // Displaying length of array  
            Console.WriteLine("length of first array: " + arr.Length);
            // Sorting array  
            Array.Sort(arr);
            Console.Write("First array elements: ");
            // Displaying sorted array  
            PrintArrays(arr);
            // Finding index of an array element  
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
            // Coping first array to empty array  
            Array.Copy(arr, arr201, arr.Length);
            Console.Write("Second array elements: ");
            // Displaying second array  
            PrintArrays(arr2);
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArrays(arr);

            // Command line arguments  
            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}


//There are 3 types of arrays in C# programming:

//Single Dimensional Array
//Multidimensional Array
//Jagged Array

//params is a keyword which is used to specify a parameter that takes variable number of arguments.