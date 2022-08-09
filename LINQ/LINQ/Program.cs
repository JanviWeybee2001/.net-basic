using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
        public List<int> Marks { get; set; }
        public string Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Objstudent = new List<Student>(){
                new Student() { Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" }, Marks = new List<int> {20, 17}, Department="IT" },
                new Student() { Name = "Janvi Desai", Gender = "Feale", Subjects = new List<string> { "Chemistry", "Computer" }, Marks = new List<int> {20, 20}, Department="IT" },
                new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" }, Marks = new List<int> {17, 17}, Department="Marketing" },
                new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" }, Marks = new List<int> {17, 17}, Department="HR" },
                new Student() { Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" }, Marks = new List<int> {10, 12}, Department="Sales" },
                new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" }, Marks = new List<int> {15, 17}, Department="Operations" }
            };

            Console.WriteLine("We can access the data of object this way.. Objstudent[0].Name =  " + Objstudent[0].Name + " \n");

            foreach(Student s in Objstudent)
            {
                Console.WriteLine("Name: {0}, Gender: {1}, Subjects: {2}, Marks: {3}, Total Marks: {4}, Department: {5}", s.Name, s.Gender, string.Join(", ", s.Subjects), string.Join(", ", s.Marks), s.Marks.Aggregate((a,b) => a+b), s.Department);
            }

            Console.WriteLine("\n\nOrder By ASC\n\n");
            var objSorted = Objstudent.OrderBy(s => s.Marks.Aggregate((a, b) => a + b));
            foreach (Student s in objSorted)
            {
                Console.WriteLine("Name: {0}, Gender: {1}, Subjects: {2}, Marks: {3}, Total Marks: {4}, Department: {5}", s.Name, s.Gender, string.Join(", ", s.Subjects), string.Join(", ", s.Marks), s.Marks.Aggregate((a, b) => a + b), s.Department);
            }
                   
            Console.WriteLine("\n\nOrder By DESC\n\n");
            var objSortedDes = Objstudent.OrderByDescending(s => s.Marks.Aggregate((a, b) => a + b));
            foreach (Student s in objSortedDes)
            {
                Console.WriteLine("Name: {0}, Gender: {1}, Subjects: {2}, Marks: {3}, Total Marks: {4}, Department: {5}", s.Name, s.Gender, string.Join(", ", s.Subjects), string.Join(", ", s.Marks), s.Marks.Aggregate((a, b) => a + b), s.Department);
            }

            Console.WriteLine("\n\nThen By DESC\n\n");
            var objSortedThen = Objstudent.OrderBy(s => s.Marks.Aggregate((a, b) => a + b)).ThenBy(s => s.Name);
            foreach (Student s in objSortedThen)
            {
                Console.WriteLine("Name: {0}, Gender: {1}, Subjects: {2}, Marks: {3}, Total Marks: {4}, Department: {5}", s.Name, s.Gender, string.Join(", ", s.Subjects), string.Join(", ", s.Marks), s.Marks.Aggregate((a, b) => a + b), s.Department);
            }
            Console.ReadLine();

            string[] countries = {"UK", "India", "USA", "Russia", "China", "Australia", "Argentina"};


            Console.WriteLine("\n--Take--\n");

            //here take() method will return the value from the String array upto three numbers.  
            IEnumerable<string> result1 = countries.Take(3);
            Console.WriteLine("\nTaken data from Collections\n");
            foreach (string s in result1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n--TakeWhile--\n");

            /*TakeWhile operator is used which will print the values until the specified condition is satisfied. it'll check first element is start with "U" or not.*/
            IEnumerable<string> result2 = countries.TakeWhile(x => x.StartsWith("U"));
            //foreach loop will print the value of the result  
            foreach (string s in result2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n--Skip--\n");

            /*skip method is used to with the IEnumerable to return the value which skip the third element of the array*/
            IEnumerable<string> result3 = countries.Skip(3);
            //foreach loop is used to print the element of the array  
            foreach (string s in result3)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

            Console.WriteLine("\n--ToList--\n");

            //countries.ToList() convert the collection of data into the list.  
            List<string> result4 = countries.ToList();
            //foreach loop is used to print the information of the student  
            foreach (string s in result4)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n--ToArray--\n");

            //countries.ToArray() is used to convert the collection of data into the form of array  
            string[] countryarray = countries.ToArray();
            //foreach loop is used to print the name of the countries  
            foreach (string s in countryarray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n--ToLoookup--\n");

            //objEmployee.ToLookup() method is used to print the value of the data in the pair/collection of items.  

            var Emp = Objstudent.ToLookup(x => x.Department);
            Console.WriteLine("-------Grouping Employees by Department-------\n");
            foreach (var KeyValurPair in Emp)
            {
                Console.WriteLine(string.Concat("This is ", KeyValurPair.Key));
                Console.WriteLine("Name: " + Emp[KeyValurPair.Key]);

                //Lookup employees by Department
                foreach (var item in Emp[KeyValurPair.Key])
                {
                    Console.WriteLine("Name: " + item.Name + ", Department: " + item.Department + ", Gender: {0}, Subjects: {1}\n", item.Gender, string.Join(", ", item.Subjects));
                }
            }

            Console.WriteLine("\n--Casting--\n");

            //create an object named 'obj' of ArrayList   
            ArrayList obj = new ArrayList();

            //assign the values to the object 'obj'   
            obj.Add("USA");
            obj.Add("Australia");
            obj.Add("UK");
            obj.Add("India");
            //Here we are converting the ArrayList object to String type of object and store the result in 'result'  

            IEnumerable<string> result5 = obj.Cast<string>();
            //Now with the help of foreach loop we will print the value of result  
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }

            // Add integer element in ArrayList Object..
            obj.Add(1);

            //ofType() method will return the value only the specific type  

            Console.WriteLine("\n--TypeOf--\n");
            Console.WriteLine("arrayList obj.........");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> result6 = obj.OfType<string>();
            //foreach loop is applied to print the value of the item  

            Console.WriteLine("\nTypeOf<string> result6.........");
            foreach (var item in result6)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--AsEnumerable--\n");

            //here we are creating an array NumArray type of int  
            int[] NumArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("NumArray[0] = {0}", NumArray);
            var result9 = NumArray.OrderByDescending(s => s);
            foreach (var number in result9)
            {
                Console.WriteLine(number);
            }
            //After applying the AsEnumerable method the output will be store in variable result  
            var result7 = NumArray.AsEnumerable();
            var result8 = result7.OrderByDescending(s => s);
            Console.WriteLine("\nresult7[0] = {0}",result7);
            //Now we will print the value of variable result one by one with the help of foreach loop  
            foreach (var number in result8)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n--ToDictionary--\n");

            /*here with the help of ToDictionary() method we are converting the colection of information in the form of dictionary and will fetch only the required information*/
            var student = Objstudent.ToDictionary(x => x.Name, x => x.Gender);
            //foreach loop is used to print the information of the student  
            foreach (var s in student)
            {
                Console.WriteLine(s.Key + "\t" + s.Value);
            }
            Console.ReadLine();

            Console.WriteLine("\n--LINQ Element Operators--\n"); 

            Console.WriteLine("\n--First--\n");

            //Create an array objList of the type of int  
            int[] objList = { 1, 2, 3, 4, 5 };
            //First() method is used to return the first element from the array 'objList'  
            int result11 = objList.First();
            Console.WriteLine("First Element from the List: {0}", result11);

            Console.WriteLine("\n--FirstOrDefault--\n");

            int[] objVal = { };
            /*FirstOrDefault() method is used to return the first element from the list and the list not contain any element will return the default value.*/
            int result12 = objList.FirstOrDefault();
            int val11 = objVal.FirstOrDefault();
            Console.WriteLine("First or Default of exist Element from the List1: {0}", result12);
            Console.WriteLine("First or Default of empty Element list from the List2: {0}", val11);

            Console.WriteLine("\n--Last--\n");

            /*apply the Last() method to fetch the last element of the list and store in result variable of type int*/
            int result13 = objList.Last();
            //Console.Writeline() used to print the value of the Last() method  
            Console.WriteLine("Last Element from the List: {0}", result13);

            Console.WriteLine("\n--LastOrDefault--\n");

            /*LastOrDefault() method will fetch the last element from the LISTOBJ and store the output in the variable result*/
            int result14 = objList.LastOrDefault();
            /*Here LastOrDefault() method is applied on the ValObj array and return the result in the variable val*/
            int val12 = objVal.LastOrDefault();
            Console.WriteLine("Element from the List1: {0}", result14);
            Console.WriteLine("Element from the List2: {0}", val12);

            Console.WriteLine("\n--ElementAt--\n");

            /*With the help of ElementAt() method will fetch the element from the specified position and store the value in 'result' and 'val' variable.*/
            int result15 = objList.ElementAt(1);
            int val13 = objList.ElementAt(3);
            /*WriteLine function will print the value of the specified index*/
            Console.WriteLine("Element At Index 1: {0}", result15);
            Console.WriteLine("Element At Index 3: {0}", val13);

            Console.WriteLine("\n--ElementAtOrDefault--\n");

            /*here ElementAtOrDefault() method will return the default value '0' because the  array 'a' does not contain any value at index 10 position*/
            int val14 = objList.ElementAtOrDefault(10);
            Console.WriteLine("Element At Index 10: {0}", val14);

            Console.WriteLine("\n--Single--\n");

            //objStudent.Single() used to select the student  
            var user = Objstudent.Single(s => s.Name == "Janvi Desai");
            //int val = objList.Single();                       // it give the ERROR, beacaause it contain more than one element.
            int val15 = new List<int> { 1 }.Single();
            //int val16 = [1].Single();                         // It also give the ERROR.
            Console.WriteLine("Element from objStudent: {0}", user.Name);
            Console.WriteLine("Element from new List<int> { 1 }: " + val15);

            Console.WriteLine("\n--SingleOrDefault--\n");

            //objStudent.SingleOrDefault() method will return the information of the student  
            var user11 = Objstudent.SingleOrDefault(i => i.Name == "Janvi Desai");
            string result16 = user11.Name;
            int val = objList.SingleOrDefault(j => j > 5);
            //Console.WriteLine("Element from objStudent: {0}", result16); // It terminate the execituion
            Console.WriteLine("Element from objList: {0}", val);

            Console.WriteLine("\n--DefaultIfEmpty--\n");

            //create an array 'b'          
            int[] bb = { };
            int[] aa = { 1, 2, 3, 4, 5 };
            //with the help of DefaultfEmpty try to fetch the value from both of the list  
            var result17 = aa.DefaultIfEmpty();
            var result18 = bb.DefaultIfEmpty();
            Console.WriteLine("----List1 with Values----");
            //with the help of foreach loop we will print the value of 'result' variable   
            foreach (var val1 in result17)
            {
                Console.WriteLine(val1);
            }
            Console.WriteLine("---List2 without Values---");
            //with the help of foreach loop we will print the value of 'result1' variable   
            foreach (var val2 in result18)
            {
                Console.WriteLine(val2);
            }
            Console.ReadLine();
        }
    }
}
 
// Immediate Window   := ctrl + alt + i
// QuickWatch := shift + F9
// for move := F10
