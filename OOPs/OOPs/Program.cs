using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{

    class student
    {
        // Fields
        public int studentId { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        // Methods
        public void studentShowInformation()
        {
            Console.WriteLine("Student Information :: StudentId : {0}, Name : {1}, Address : {2}", studentId, name, address);
        }
    }


    // Single level inheritance

    //class Vehicle  // Base Class
    //{
    //    string number;
    //    string owner;
    //}

    //class Car : Vehicle   // Derived class
    //{
    //    int numberOfDoors;
    //}


    // Multi level inheritance

    //class Vehicle  // Base Class
    //{
    //    string number;
    //    string owner;
    //}

    //class FourWheeler : Vehicle   // Derived class
    //{
    //    string type;
    //}

    //class Car: FourWheeler   // Derived class   
    //{
    //    int numberOfDoors;
    //}


    // Herirachical inheritance

    class Vehicle  // Base Class
    {
        string number;
        string owner;
    }

    class FourWheeler : Vehicle   // Derived class
    {
        string type;
    }

    class Car : FourWheeler   // Derived class   
    {
        int numberOfDoors;
    }

    class Tractor : FourWheeler   // Derived class   
    {
        int numberOfAxels;
    }

    class Calculator
    {
        public int add (int num1, int num2)
        {
            return num1 + num2;
        }

        public decimal add(decimal num1, int num2)
        {
            return num1 + num2;
        }
        public decimal add(int num1, int num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

    }

    class Employee
    {
        public decimal Salary;

        public virtual decimal CalculateSalary()
        {
            return Salary;
        }
    }

    class SalesEmployee  : Employee
    {
        public decimal SalesBonus;

        public override decimal CalculateSalary()
        {
            return Salary + SalesBonus;
        }
    }

    class Employees
    {
        public decimal Salarys;

        public decimal CalculateSalarys()
        {
            return Salarys;
        }
    }

    class SalesEmployees : Employees
    {
        public decimal SalesBonuss;

        public new decimal CalculateSalarys()
        {
            return Salarys + SalesBonuss;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            student st1 = new student();

            st.studentId = 1;
            st.name = "Janvi";
            st.address = "Rajkot";

            st1.studentId = 2;
            st1.name = "Rushita";
            st1.address = "Amreli";

            st.studentShowInformation();
            st1.studentShowInformation();

            Calculator calc = new Calculator();

            int result = calc.add(2, 4);
            Console.WriteLine("Result : {0}", result);

            Employee baseemp = new Employee();
            baseemp.Salary = 10000;
            decimal sal = baseemp.CalculateSalary();
            Console.WriteLine(sal);
            Console.ReadLine();

            SalesEmployees emp = new SalesEmployees();
            emp.Salarys = 12000;
            emp.SalesBonuss = 1000;

            decimal salary = emp.CalculateSalarys();
            Console.WriteLine(salary);

            Console.ReadLine();
        }
    }
}
