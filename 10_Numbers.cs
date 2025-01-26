// 10. NUMBERS

namespace Lesson10
{
    class Program10
    {
        // public static void Main()
        // {
        //     /*
        //     Numbers, in general, can be divided into two types: Integer type and 
        //     floating-point types. Integer type numbers are whole numbers without decimal points. 
        //     It can be negative or positive numbers. Floating-point type is numbers with one 
        //     or more decimal points. It can be negative or positive numbers. C# includes 
        //     different data types for integer types and floating-point types based on their 
        //     size in the memory and capacity to store numbers.
        //     */

        //     /*
        //     INTEGER TYPES

        //     Integer type numbers are positive or negative whole numbers without decimal points.
        //     C# includes four data types for integer numbers: byte, short, int, and long.

        //     BYTE

        //     The byte data type stores numbers from 0 to 255. It occupies 8-bit in the memory. 
        //     The byte keyword is an alias of the Byte struct in .NET.

        //     The sbyte is the same as byte, but stores negative numbers from -128 to 127. 
        //     The sbyte keyword is an alias for SByte struct in .NET.
        //     */

        //     byte b1 = 255;
        //     Console.WriteLine("b1 = " + b1);

        //     // byte b2 = -128;
        //     // Compiler Error CS0031 : Constant value 'value' can't be converted to a 'type'.

        //     sbyte sb1 = -128; 
        //     Console.WriteLine("sb1 = " + sb1);

        //     sbyte sb2 = 127; 
        //     Console.WriteLine("sb2 = " + sb2);

        //     Console.WriteLine("Byte.MaxValue = " + Byte.MaxValue);
        //     Console.WriteLine("Byte.MinValue = " + Byte.MinValue);
        //     Console.WriteLine("SByte.MaxValue = " + SByte.MaxValue);
        //     Console.WriteLine("SByte.MinValue = " + SByte.MinValue);

        //     /*
        //         SHORT

        //         The short data type is a signed integer that can store numbers from 
        //         -32,768 to 32,767. It occupies a 16-bit memory. The short keyword is an alias 
        //         for Int16 struct in .NET.

        //         The ushort data type is an unsigned integer. It can store only positive 
        //         numbers from 0 to 65,535. The ushort keyword is an alias for UInt16 struct 
        //         in .NET.
        //     */

        //     short s1 = -32768;
        //     Console.WriteLine("s1 = " + s1);

        //     short s2 = 32767;
        //     Console.WriteLine("s2 = " + s2);

        //     // short s3 = 35000;
        //     // Compiler Error CS0031 : Constant value '35000' cannot be converted to a 'short'.

        //     ushort us1 = 65535;
        //     Console.WriteLine("us1 = " + us1);

        //     // ushort us2 = -32000;
        //     // Compiler Error CS0031 : Constant value '-32000' cannot be converted to a 'ushort'.

        //     Console.WriteLine("Int16.MaxValue = " + Int16.MaxValue);
        //     Console.WriteLine("Int16.MinValue = " + Int16.MinValue);
        //     Console.WriteLine("UInt16.MaxValue = " + UInt16.MaxValue);
        //     Console.WriteLine("UInt16.MinValue = " + UInt16.MinValue);

        //     /*
        //         INT

        //         The int data type is 32-bit signed integer. It can store numbers from 
        //         -2,147,483,648 to 2,147,483,647. The int keyword is an alias of Int32 struct 
        //         in .NET.

        //         The uint is 32-bit unsigned integer. The uint keyword is an alias of UInt32 
        //         struct in .NET. It can store positive numbers from 0 to 4,294,967,295. 
        //         Optionally use U or u suffix after a number to assign it to uint variable.
        //     */

        //     int i = -2147483648;
        //     Console.WriteLine("i = " + i);

        //     int j = 2147483647;
        //     Console.WriteLine("j = " + j);

        //     // int k = 4294967295;
        //     /*
        //         Compile Error CS0266 : Cannot implicitly convert type 'uint' to 'int'. 
        //         An explicit conversion exists (are you missing a cast?)
        //     */

        //     uint uiA = 4294967295;
        //     Console.WriteLine("uiA = " + uiA);

        //     // uint ui2 = -1;
        //     // Compiler Error CS0031 : Constant value '-1' cannot be converted to a 'uint'.

        //     Console.WriteLine("Int32.MaxValue = " + Int32.MaxValue);
        //     Console.WriteLine("Int32.MinValue = " + Int32.MinValue);
        //     Console.WriteLine("UInt32.MaxValue = " + UInt32.MaxValue);
        //     Console.WriteLine("UInt32.MinValue = " + UInt32.MinValue);

        //     /*
        //         The int data type is also used for hexadecimal and binary numbers. 
        //         A hexadecimal number starts with 0x or 0X. From C# 7.2 onwards, a binary 
        //         number starts with 0b or 0B.
        //     */

        //     int hex = 0x2F;
        //     Console.WriteLine("hex = " + hex);

        //     int binary = 0b_0010_1111;
        //     Console.WriteLine("binary = " + binary);

        //     /*
        //         LONG

                
        //         The long type is 64-bit signed integers. It can store numbers from 
        //         -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807. Use L suffix with 
        //         number to assign it to long type variable. The long keyword is an alias of 
        //         Int64 struct in .NET.

        //         The ulong type stores positive numbers from 0 to 18,446,744,073,709,551,615. 
        //         If a number is suffixed by UL, Ul, uL, ul, LU, Lu, lU, or lu, its type is 
        //         ulong. The ulong keyword is an alias of UInt64 struct in .NET.
        //     */

        //     long Lg1 = -9223372036854775808;
        //     Console.WriteLine("Lg1 = " + Lg1);

        //     long Lg2 = 9223372036854775807;
        //     Console.WriteLine("Lg2 = " + Lg2);

        //     ulong ul1 = 18223372036854775808ul;
        //     Console.WriteLine("ul1 = " + ul1);

        //     ulong ul2 = 18223372036854775808UL;
        //     Console.WriteLine("ul2 = " + ul2);

        //     Console.WriteLine("Int64.MaxValue = " + Int64.MaxValue);
        //     Console.WriteLine("Int64.MinValue = " + Int64.MinValue);
        //     Console.WriteLine("UInt64.MaxValue = " + UInt64.MaxValue);
        //     Console.WriteLine("UInt64.MinValue = " + UInt64.MinValue);

        //     /*
        //         FLOATING POINT TYPES

        //         Floating-point numbers are positive or negative numbers with one or more 
        //         decimal points. C# includes three data types for floating-point numbers : 
        //         float, double, and decimal.

        //         FLOAT

        //         The float data type can store fractional numbers from 3.4e−038 to 3.4e+038. 
        //         It occupies 4 bytes in the memory. The float keyword is an alias of Single 
        //         struct in .NET.

        //         Use f or F suffix with literal to make it float type.
        //     */

        //     float f1 = 123456.5F;
        //     Console.WriteLine("f1 = " + f1);

        //     float f2 = 1.123456f;
        //     Console.WriteLine("f2 = " + f2);

        //     Console.WriteLine("Single.MaxValue = " + Single.MaxValue);
        //     Console.WriteLine("Single.MinValue = " + Single.MinValue);

        //     /*
        //         DOUBLE

        //         The double data type can store fractional numbers from 1.7e−308 to 1.7e+308. 
        //         It occupies 8 bytes in the memory. The double keyword is an alias of the 
        //         Double struct in .NET.

        //         Use d or D suffix with literal to make it double type.
        //     */

        //     double db1 = 12345678912345.5d;
        //     Console.WriteLine("db1 = " + db1);

        //     double db2 = 1.123456789123456d;
        //     Console.WriteLine("db2 = " + db2);

        //     Console.WriteLine("Double.MaxValue = " + Double.MaxValue);
        //     Console.WriteLine("Double.MinValue = " + Double.MinValue);

        //     /*
        //         DECIMAL

        //         The decimal data type can store fractional numbers from ±1.0 x 10-28 to 
        //         ±7.9228 x 1028. It occupies 16 bytes in the memory. The decimal is a keyword 
        //         alias of the Decimal struct in .NET.

        //         The decimal type has more precision and a smaller range than both float and 
        //         double, and so it is appropriate for financial and monetary calculations.

        //         Use m or M suffix with literal to make it decimal type.
        //     */

        //     decimal dm1 = 123456789123456789123456789.5m;
        //     Console.WriteLine("dm1 = " + dm1);

        //     decimal dm2 = 1.1234567891345679123456789123m;
        //     Console.WriteLine("dm2 = " + dm2);

        //     Console.WriteLine("Decimal.MaxValue = " + Decimal.MaxValue);
        //     Console.WriteLine("Decimal.MinValue = " + Decimal.MinValue);

        //     /*
        //         SCIENTIFIC NOTATION

        //         Use e or E to indicate the power of 10 as exponent part of scientific 
        //         notation with float, double or decimal.
        //     */

        //     double scienceDb = 0.12e2;
        //     Console.WriteLine("scienceDb = " + scienceDb);

        //     float scienceF = 123.45e-2f;
        //     Console.WriteLine("scienceF = " + scienceF);

        //     decimal scienceDm = 1.2e6m;
        //     Console.WriteLine("scienceDm = " + scienceDm);
        // }
    }
}