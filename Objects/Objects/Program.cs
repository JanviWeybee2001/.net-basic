using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Student Constructer invoked");
        }

        public int id;
        public String name;
        public void insert(int i, String n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name);
        }
        ~Student()
        {
            Console.WriteLine("Student Destructor invoked");
            Console.ReadLine();
        }

    }

    public class Students
    {
        public string name;
        public int age;
        public static float rateOfInterest  = 3.3f;
        public static int count = 0;

        // default constructor
        public Students()
        {
            Console.Write("\n------This is CONSTRUCTOR-------");
        }

        // destructor
        ~Students()
        {
            Console.Write("\n------This is DESTRUCTOR---------");
            Console.ReadLine();
        }

        // parameterized constructor and this keyword
        public Students(string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }

        static Students()
        {
            Console.WriteLine("static constructor");
            //rateOfInterest = 3.3f;
        }

        public void Print()
        {
            Console.WriteLine(name + " " + age + " " + rateOfInterest);
        }
    }

    class Geeks
    {

        private string[] days = new string[7];

        // declaring an indexer
        public string this[int index]
        {
            get
            {
                return days[index];
            }

            set
            {
                days[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.insert(101, "Ajeet");
            s1.display();
            Student s2 = new Student();
            s2.insert(102, "Tom");
            s2.display();

            Students info = new Students()
            {
                name = "Janvi",
                age = 21

            };
            Console.Write("\n" + info.name + " " + info.age);
            Console.ReadLine();

            Console.Write("\n-------------Displaying data through method--------------\n");
            Students s11 = new Students("Rushita", 21);
            Students s22 = new Students("Krishna", 20);
            s11.Print();
            s22.Print();
            Console.Write("\nTotal Objects are : " + Students.count);
            Console.ReadLine();


            Console.Write("\n-----------Declare indexer------------\n");
            Geeks g = new Geeks();
            g[0] = "Sun";
            g[1] = "Mon";
            g[2] = "Tue";
            g[3] = "Wed";
            g[4] = "Thu";
            g[5] = "Fri";
            g[6] = "Sat";
            for (int i = 0; i < 7; i++)
                Console.Write(g[i] + " ");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
