using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Student
    {
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

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.insert(101, "Ajeet");
            s2.insert(102, "Tom");
            s1.display();
            s2.display();
            Console.ReadLine();
        }
    }
}
