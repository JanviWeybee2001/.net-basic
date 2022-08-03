using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Constructor
{
    class Student
    {

        public int StudentId { get; set; }

        public string Name { get; set; }

        public string College { get; set; }

        // default constructor
        public Student()
        {
            College = "GECR college";
        }

        public Student(int StudentId, string name)
        {
            // HERE, this is say that, we are going to set the value of particular variable.
            // Beacause passing variable and the class variable name are same.
            this.StudentId = StudentId; 
            this.Name = name;
        }

        public Student(string college)
        {
            this.College = college;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("Student :=  StudentId : {0}, Name : {1}, College : {2}",st.StudentId, st.Name, st.College);

            Student st1 = new Student(1, "Rushita");
            Console.WriteLine("Student :=  StudentId : {0}, Name : {1}, College : {2}", st1.StudentId, st1.Name, st1.College);

            Student st2 = new Student("Darshan");
            Console.WriteLine("Student :=  StudentId : {0}, Name : {1}, College : {2}", st2.StudentId, st2.Name, st2.College);

            Console.ReadLine();
        }
    }
}
