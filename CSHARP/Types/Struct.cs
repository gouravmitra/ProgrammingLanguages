using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomitra.CSHARP.Types
{
    public struct SomeStruct
    {
        public int firstData;
        public int lastData;

        public void show()
        {
            Console.WriteLine("First Data: {0} Second Data: {1}", firstData, lastData);
        }
    }

    public static class StructExamples {

        public static void ExecuteExampleBasic()
        {
            //Struct Examples Basics
            SomeStruct myStruct = new SomeStruct();
            myStruct.firstData = 10;
            myStruct.lastData = 20;
            myStruct.show();

            // Struct Examples Copy
            SomeStruct myStruct2 = myStruct;
            myStruct2.show();
        }

        public static void ExecuteExampleCopy()
        {
            //Struct Examples Basics
            SomeStruct myStruct = new SomeStruct();
            myStruct.firstData = 10;
            myStruct.lastData = 20;
            myStruct.show();

            // Struct Examples Copy
            SomeStruct myStruct2 = myStruct;
            myStruct2.show();
        }
    }
}
