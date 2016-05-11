using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomitra.CSHARP.Types
{
    public static class TypeExamples {


        public static void ExecuteExampleSize()
        {
            Console.WriteLine("SByte Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(sbyte), SByte.MinValue, SByte.MaxValue);
            Console.WriteLine("Byte Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(byte), Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("Short Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(short), Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("UShort Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(ushort), UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("Int Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(int), Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("UInt Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(uint), UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("Long Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(long), Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("ULong Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(ulong), UInt64.MinValue, UInt64.MaxValue);
            Console.WriteLine("Float Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(float), Single.MinValue, Single.MaxValue);
            Console.WriteLine("Double Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(double), Double.MinValue, Double.MaxValue);
            Console.WriteLine("Decimal Size: {0} Bytes, Min Value: {1}, Max Value: {2}", sizeof(decimal), Decimal.MinValue, Decimal.MaxValue);
        }

        public static void ExecuteExampleSuffixes()
        {
            float someValue = 1.5F;
        }

        public static void ExecuteExampleLargeIntConvFloat()
        {
            int someLargeIntValue = 1000000001;
            Console.WriteLine("Some large Int Value: {0}", someLargeIntValue);
            float someFloatValue = someLargeIntValue;
            Console.WriteLine("Some large float Value after conversion from int: {0}", someFloatValue);
            double someDoubleValue = someLargeIntValue;
            Console.WriteLine("Some large double Value after conversion from int: {0}", someDoubleValue);
            int someLargeIntValue2 = (int)someFloatValue;
            Console.WriteLine("Some large Int Value after re-conversion from float: {0}", someLargeIntValue2);
            someLargeIntValue2 = (int)someDoubleValue;
            Console.WriteLine("Some large Int Value after re-conversion from double: {0}", someLargeIntValue2);
        }

        public static void ExecuteExampleChecked()
        {
            int someLargeIntValue = 1000000001;
            int anotherLargeInValue = 100001;

            int outcome = unchecked(someLargeIntValue * anotherLargeInValue);

            //int maxPlusOne = Int32.MaxValue + 1;

            Console.WriteLine("Overflow by multipling two large ints {0} and {1}: {2}", someLargeIntValue, anotherLargeInValue, outcome);
        }
    }
}
