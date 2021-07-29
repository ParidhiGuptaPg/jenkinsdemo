using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcommandlineapp
{
    class Datatype
    {
        void Types()
        {
            String name;
            int age;
            float salary = 67900.89f;
            //double fees = 67444.65d;
            Console.WriteLine("Enter the Name");
            name = Console.ReadLine(); // returns or gets value as a string 
            Console.WriteLine("Enter the Age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name:{0} && Age: {1} && Salary:{2}", name, age, salary);
        }
        void TypeConversion()
        {
            //implicit and explicit
            //Implicit type conversion 
            //int<float<double
            int num = 100;
            float petrol = num;
            double disel = petrol;
            Console.WriteLine("Implicit type conversion:{0}", disel);

            // Explicit type conveersion 
        }

        void BoxingandUnboxing()
        {
            // converting value type to reference type is boxing
            // Converting reference type to value type is unboxing

            int salary = 20000; //value type ----stores in stack 
            Object obj = salary; // converting to object          --boxing
            int number = (int)obj; // reference type to value type -- unboxing---- heap storage
            Console.WriteLine("BoxingandUnboxing:{0}", number);
        }

        void NullableTypes()
        {
            //value nullable type
            //int age1=null;
            int? age = null; //nullable type
            Console.WriteLine("Age is {0}",age??0);
            //reference nullable type
            String? City = null;
            Console.WriteLine("City is {0}",City??"Chennai");
        }

        static void Main()
        {
            Datatype datatype = new Datatype();
            datatype.Types();
            Console.WriteLine(".............");
            datatype.TypeConversion();
            Console.WriteLine(".............");
            datatype.BoxingandUnboxing();
            Console.WriteLine("..........");
            datatype.NullableTypes();

        }
    }
}
