using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{

    public class Assembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protaectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protaectedInternalVariable = "protected internal";
        public string publicVariable = "public";

        public void TestAccess()
        {
            // Accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protaectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protaectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly1DerivedClass : Assembly1BaseClass
    {
        public void TestAccessInDerivedClass()
        {
            //Not Accessible
            //Console.WriteLine(privateVariable); 

            //Accessibl 
            Console.WriteLine(protaectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protaectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly1OtherClass
    {
        Assembly1BaseClass objBase = new Assembly1BaseClass();
        public void TestAccess()
        {
            //Not Accessible
            //Console.WriteLine(objBase.privateVariable);
            //Console.WriteLine(objBase.protaectedVariable);

            // Accessible
            Console.WriteLine(objBase.internalVariable);
            Console.WriteLine(objBase.protaectedInternalVariable);
            Console.WriteLine(objBase.publicVariable);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Assembly1BaseClass objBase = new Assembly1BaseClass();
            Console.WriteLine("----------------------Base----------------------");
            objBase.TestAccess();

            Console.ReadLine();
            Assembly1DerivedClass objDerived = new Assembly1DerivedClass();
            Console.WriteLine("----------------------Derived----------------------");
            Console.ReadLine();
            Console.WriteLine("-----------Derived class method by derived class object-----------");
            objDerived.TestAccessInDerivedClass();
            Console.WriteLine("-----------Base class method by derived class object-----------");
            objDerived.TestAccess();

            Console.ReadLine();
            Assembly1OtherClass objOther = new Assembly1OtherClass();
            Console.WriteLine("----------------------Other----------------------");
            objOther.TestAccess();

            Console.ReadLine();
        }
    }
}
