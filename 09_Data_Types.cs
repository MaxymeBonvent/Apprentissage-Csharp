// 9. DATA TYPES

namespace Lesson9
{
    class Program9
    {
        // public static void Main()
        // {
        //     /*
        //     C# is a strongly-typed language. It means we must declare the type of a variable 
        //     that indicates the kind of values it is going to store, such as integer, float, 
        //     decimal, text, etc.

        //     The following declares and initializes variables of various data types.
        //     */

        //      int intVar = 100;
        //      Console.WriteLine("intVar = " + intVar);

        //      float floatVar = 10.2f;
        //      Console.WriteLine("floatVar = " + floatVar);

        //      char charVar = 'A';
        //      Console.WriteLine("charVar = " + charVar);

        //      string stringVar = "Hello World!!";
        //      Console.WriteLine("stringVar = " + stringVar);

        //      bool boolVar = true;
        //      Console.WriteLine("boolVar = " + boolVar);

        //     /*
        //     C# mainly categorizes data types in two types: Value types and Reference types. 
        //     Value types include simple types (int, float, bool, char), enum types, 
        //     struct types, and nullable value types. Reference types include className types, 
        //     interface types, delegate types, and array types.
        //     */

        //     /*
        //     PREDEFINED DATA TYPES IN C#

        //     C# includes some predefined value types and reference types. 
        //     The following table lists predefined data types:

        //         |Type|Description           |Range      |Suffix |
        //         |byte	8-bit unsigned integer	0 to 255	
        //         |sbyte	8-bit signed integer	-128 to 127	
        //         |short	16-bit signed integer	-32,768 to 32,767	
        //         |ushort	16-bit unsigned integer	0 to 65,535	
        //         |int	32-bit signed integer	-2,147,483,648 to 2,147,483,647	
        //         |uint	32-bit unsigned integer	0 to 4,294,967,295	u
        //         |long	64-bit signed integer	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807	l
        //         |ulong	64-bit unsigned integer	0 to 18,446,744,073,709,551,615	ul
        //         |float	32-bit Single-precision floating point type	-3.402823e38 to 3.402823e38	f
        //         |double	64-bit double-precision floating point type	-1.79769313486232e308 to 1.79769313486232e308|	d
        //         |decimal	128-bit decimal type for financial and monetary calculations	(+ or -) 1.0 x 10e-28 to 7.9 x 10e28|	m
        //         |char	16-bit single Unicode character	Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)	
        //         |bool	8-bit logical true/false value	True or False	
        //         |object	Base type of all other types.		
        //         |string	A sequence of Unicode characters		
        //         |DateTime	Represents date and time	0:00:00am 1/1/01 to 11:59:59pm 12/31/9999	
        //     */

        //     /*
        //     As you can see in the above table, each data type (except string and object) 
        //     has a value range. The compiler will give an error if the value goes out of 
        //     the data type's permitted range. For example, int's range is from -2,147,483,648 
        //     to 2,147,483,647. So if you assign a value which is not in this range, then the 
        //     compiler will give an error.
        //     */

        //     // int excess = 2147483648;
        //     /*
        //     Compiler Error CS0266 : Cannot implicitly convert type 'uint' to 'int'. 
        //     An explicit conversion exists (are you missing a cast?)
        //     */

        //     /*
        //     Values of unsigned integers, long, float, double, and decimal type must be 
        //     suffixed u, L, f, d, and m respectively.
        //     */

        //     uint ui = 100u;
        //     Console.WriteLine("ui = " + ui);

        //     float fl = 10.2f;
        //     Console.WriteLine("fl = " + fl);

        //     long l = 45755452222222L;
        //     Console.WriteLine("l = " + l);

        //     ulong ul = 45755452222222ul;
        //     Console.WriteLine("ul = " + ul);

        //     double d = 11452222.555d;
        //     Console.WriteLine("d = " + d);

        //     decimal dm = 1000.15m;
        //     Console.WriteLine("dm = " + dm);

        //     /*
        //         ALIAS VS .NET TYPE

        //         The predefined data types are alias to their .NET type (CLR className) name. 
        //         The following table lists alias for predefined data types and related .NET 
        //         className name.

        //         Alias	|.NET Type	    |Type
        //         byte	|System.Byte	|struct
        //         sbyte	|System.SByte	|struct
        //         int	    |System.Int32	|struct
        //         uint	|System.UInt32	|struct
        //         short	|System.Int16	|struct
        //         ushort	|System.UInt16	|struct
        //         long	|System.Int64	|struct
        //         ulong	|System.UInt64	|struct
        //         float	|System.Single	|struct
        //         double	|System.Double	|struct
        //         char	|System.Char	|struct
        //         bool	|System.Boolean	|struct
        //         object	|System.Object	|className
        //         string	|System.String	|className
        //         decimal	|System.Decimal	|struct
        //         DateTime|System.DateTime|struct

        //         Which means whether you define a variable as int or Int32, 
        //         they have the same type.
        //     */

        //     int nb = 1;
        //     Console.WriteLine("Type of nb = " + nb.GetType());

        //     Int32 num = 2;
        //     Console.WriteLine("Type of num = " + num.GetType());

        //     /*
        //         DEFAULT VALUES

        //         Every data type has a default value. Numeric type is 0, boolean has false, 
        //         and char has '\0' as default value. Use the default(typename) to assign a 
        //         default value of the data type, or from C# 7.1 onward, use the default literal.
        //     */

        //     int myNum = default(int); // 0
        //     Console.WriteLine("myNum = " + myNum);

        //     float myFl = default(float);// 0
        //     Console.WriteLine("myFl = " + myFl);

        //     decimal myDc = default(decimal);// 0
        //     Console.WriteLine("myDc = " + myDc);

        //     bool myBool = default(bool);// false
        //     Console.WriteLine("myBool = " + myBool);

        //     char letter = default(char);// ''
        //     Console.WriteLine("letter = " + letter);

        //     // C# 7.1 onwards
        //     int myNewNum = default; // 0
        //     Console.WriteLine("myNewNum = " + myNewNum);

        //     float myNewFl = default;// 0
        //     Console.WriteLine("myNewFl = " + myNewFl);

        //     decimal myNewDc = default;// 0
        //     Console.WriteLine("myNewDc = " + myNewDc);

        //     bool myNewBool = default;// false
        //     Console.WriteLine("myNewBool = " + myNewBool);

        //     char newLetter = default;// ''
        //     Console.WriteLine("newLetter = " + newLetter);

        //     /*
        //         CONVERSIONS

        //         The values of certain data types are automatically converted to different 
        //         data types in C#. This is called an implicit conversion.
        //     */

        //     int numA = 345;
        //     float numB = numA;

        //     Console.WriteLine("Type of numB = " + numB.GetType());

        //     /*
        //         In the above example, the value of an integer variable numA is assigned to the 
        //         variable of float type numB because this conversion operation is predefined 
        //         in C#.

        //         The following is an implicit data type conversion table.

        //         I.C. From   |To
        //         sbyte	    |short, int, long, float, double, decimal
        //         byte	    |short, ushort, int, uint, long, ulong, float, double, decimal
        //         short	    |int, long, float, double, or decimal
        //         ushort	    |int, uint, long, ulong, float, double, or decimal
        //         int	        |long, float, double, or decimal.
        //         uint	    |long, ulong, float, double, or decimal
        //         long	    |float, double, or decimal
        //         ulong	    |float, double, or decimal
        //         char	    |ushort, int, uint, long, ulong, float, double, or decimal
        //         float	    |double

        //         Conversions from int, uint, long, or ulong to float and from long or ulong to 
        //         double may cause a loss of precision. No data type implicitly converted to the 
        //         char type.

        //         However, not all data types are implicitly converted to other data types. 
        //         For example, int type cannot be converted to uint implicitly. It must be 
        //         specified explicitly, as shown below.
        //     */ 

        //     int numD = 100;
        //     uint numE = (uint) numD;
        //     Console.Write("Type of numE = " + numE.GetType());

        //     /*
        //         In the above example, integer numD is converted to uint explicitly by 
        //         specifying uint in the parenthesis (uint). This will convert an integer to 
        //         uint.
        //     */
        // }
    }
}