using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomitra.CSHARP.Types
{
    public class Basics
    {
        //Predefined types
        //Custome types

    }

    // Non Static Class
    public class NoStaticClassWithStaticMember
    {
        public static int someStaticMember;

        public NoStaticClassWithStaticMember()
        {
            Console.WriteLine("Increasing value of static member during the construction.");
            someStaticMember++;
        }
        public void someNonStaticMethod()
        {
            Console.WriteLine("Value of Static Member: " + someStaticMember);
        }

    }

    // Static Class
    public static class StaticClass
    {
        public static int someStaticMember;

        public static void someStaticMethod()
        {
            Console.WriteLine("This is a Static Method.");
        }

        /********* This is not allowed. ***********/

        /************************************** 
        * Static Class can't have static member
        public int someNonStatMember;

        //  Static Class can't have static method
        public void someNonStatMethod()
        {
            Console.WriteLine("This is a Static Method.");

        }

        // Static class can't have constructor
        public StaticClass()
        {
        }
         *********************************/
    }

    public static class StaticExamples
    {

        public static void ExecuteExampleBasic()
        {
            Types.NoStaticClassWithStaticMember c = new NoStaticClassWithStaticMember();
            c.someNonStaticMethod();
            c = new NoStaticClassWithStaticMember();
            c.someNonStaticMethod();
        }

    }
}
