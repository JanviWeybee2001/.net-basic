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

    public enum Months
    {
        Jan, Feb, Mar, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec 
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
            Console.Write("\n------This is students CONSTRUCTOR-------");
        }

        // destructor
        ~Students()
        {
            Console.Write("\n------This is students DESTRUCTOR---------");
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
            Console.WriteLine("static Students constructor");
            Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine(name + " " + age + " " + rateOfInterest);
            Console.ReadLine();
        }
    }

    class Geeks
    {
        private string[] days = new string[7];

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

    class demo
    {
        public 
            int value;

        public demo()
        {
        }
        public demo(int val)
        {
            value = val;
        }

        public void passObj(demo d)
        {
            Console.WriteLine(d.value);
            Console.ReadLine();
        }
    }

    static class Me
    {
        static string name;
        static int age;

        static Me()
        {
            Console.WriteLine("--------------I'm Me Constructor------------");
            Console.ReadLine();
        }

        // Static class does not contain destructor.

        public static (int, string) IntroOfMe(int age, string name)
        {
            return (age, name);
        }

        public static void helloMe()
        {
            Console.WriteLine("Hello Me");
            Console.ReadLine();
        }
    }

    class Program
    {
        
        public struct rectangle
        {
            int width, height;

            public rectangle (int x, int y)
            {
                width = x;
                height = y;
            }

            public int AreaOfRect()
            {
                return width * height;
            }
        }

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

            int x = (int)Months.Jan;
            Console.WriteLine($"January on {x}");

            foreach(Months m in Enum.GetValues(typeof(Months)))
            {
                Console.Write(m + " ");
            }
            Console.ReadLine();

            rectangle r = new rectangle(4, 3);
            Console.WriteLine(r.AreaOfRect());
            Console.ReadLine();

            demo d1 = new demo(7);
            demo d2 = new demo(
                );
            Console.WriteLine(d1.value);

            d2.passObj(d1);


            Console.WriteLine($"Me = {Me.IntroOfMe(21, "janvi")}");

            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
