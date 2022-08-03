using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembly1;

namespace Assembly2
{

    public class Assembly2DerivedClass : Assembly1BaseClass
    {
        public void TestAccessInDerivedClass()
        {
            //Not Accessible
            //Console.WriteLine(privateVariable); 
            //Console.WriteLine(internalVariable);

            //Accessible 
            Console.WriteLine(protaectedVariable);
            Console.WriteLine(protaectedInternalVariable);
            Console.WriteLine(publicVariable); 
        }
    }

    public class Assembly2OtherClass
    {
        Assembly1BaseClass objBase = new Assembly1BaseClass();
        public void TestAccess()
        {
            //Not Accessible
            //Console.WriteLine(objBase.privateVariable);
            //Console.WriteLine(objBase.protaectedVariable);
            //Console.WriteLine(objBase.internalVariable);
            //Console.WriteLine(objBase.protaectedInternalVariable);

            // Accessible
            Console.WriteLine(objBase.publicVariable);
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
            Console.WriteLine("----------------------Derived----------------------");
            Assembly2DerivedClass objDerived = new Assembly2DerivedClass();
            Console.WriteLine("-----------Derived class method by derived class object-----------");
            objDerived.TestAccessInDerivedClass();
            Console.WriteLine("-----------Base class method by derived class object-----------");
            objDerived.TestAccess();

            Console.ReadLine();
            Assembly2OtherClass objOther = new Assembly2OtherClass();
            Console.WriteLine("----------------------Other----------------------");
            objOther.TestAccess();

            Console.ReadLine();
        }
    }
}
