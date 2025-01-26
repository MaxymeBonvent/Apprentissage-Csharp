// 19. VALUE TYPE AND REFERENCE TYPE

namespace Lesson19
{
    class Program19
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, data types are categorized based on how they store their value 
        //         in the memory. C# includes the following categories of data types:

        //         1. Value type
        //         2. Reference type
        //         3. Pointer type
        //     */

        //     /*
        //         1. VALUE TYPE

        //         A data type is a value type if it holds a value within its own memory 
        //         space. It means the variables of value types directly contain values.

        //         All value types derive from System.ValueType, which in-turn, derives from 
        //         System.Object. For example, consider the integer variable int i = 1;

        //         The system stores 1 in the memory space allocated to the variable i.

        //         The following data types are all of value type:

        //         bool
        //         byte
        //         char
        //         decimal
        //         double
        //         enum
        //         float
        //         int
        //         long
        //         sbyte
        //         short
        //         struct
        //         uint
        //         ulong
        //         ushort

        //         PASSING VALUE TYPE VARIABLES

        //         When you pass a value type variable from one method to another, the system 
        //         creates a separate copy of the variable in another method. If the value gets 
        //         changed in one method, it won't affect the variable in another method.
        //     */

        //     int nb = 0;
        //     Console.WriteLine($"Before ChangeValue(), nb = {nb}.");

        //     ChangeValue(nb);
        //     Console.WriteLine($"After ChangeValue(), nb = {nb}.");

        //     /*
        //         In the above example, variable nb in the Main() method remains unchanged even 
        //         after we pass it to the ChangeValue() method and change its value there 
        //         because the nb in the method is a copy and the original remains untouched.
        //     */

        //     /*
        //         REFERENCE TYPE

        //         Unlike value types, a reference type doesn't store its value directly. 
        //         Instead, it stores the address where the value is being stored. 
        //         In other words, a reference type contains a pointer to another memory 
        //         location that holds the data.

        //         For example, consider the following string variable :
        //         string str = "Hello World!!";

        //         The following image shows how the system allocates the memory for the above 
        //         string variable.

        //         As you can see in the above image, the system selects a random location in 
        //         memory (0x803200) for the variable str. The value of variable str is 
        //         0x600000, which is the memory address of the actual data value. 
        //         Thus, reference types store the address of the location where the actual value is stored instead 
        //         of the variable is.

        //         The following are reference type data types:

        //         String
        //         Array (even if their elements are value types)
        //         Class
        //         Delegate
        //     */

        //     /*
        //         PASSING REFERENCE TYPE VARIABLES

        //         When you pass a reference type variable from one method to another, it 
        //         doesn't create a new copy, instead it passes the variable's address. So if 
        //         we change the value of a variable in a method, it will also be reflected in 
        //         the original variable.
        //     */

        //     Student std = new(){name = "Sonic"};
            
        //     Console.WriteLine($"Before ChangeRefType, std.name = {std.name}.");

        //     ChangeRefType(std);

        //     Console.WriteLine($"After ChangeRefType, std.name = {std.name}.");

        //     /*
        //         In the above example, we pass the Student object std1 to the 
        //         ChangeRefType() method. Here, it actually pass the memory address of std. 
        //         Thus, when the ChangeRefType() method changes name, it is actually changing 
        //         name of std object, because std and std are both pointing to the same address 
        //         in memory.

        //         String is a reference type, but it is immutable. 
        //         It means once we assigned a value, it cannot be changed. 
        //         If we change a string value, then the compiler creates a new string object in 
        //         the memory and points a variable to the new memory location. So, passing a 
        //         string value to a function will create a new variable in the memory, and any
        //         change of value in the function will not be reflected in the original 
        //         value, as shown below.
        //     */

        //     string fruit = "apple";

        //     Console.WriteLine($"Before ChangeString, fruit = {fruit}.");

        //     ChangeString(fruit);

        //     Console.WriteLine($"After ChangeString, fruit = {fruit}.");

        //     /*
        //         NULL

        //         The default value of a reference type variable is null when they are not 
        //         initialized. Null means not refering to any object.

        //         A value type variable cannot be null because it holds value, not a memory 
        //         address. C# 2.0 (2005) introduced nullable types, with which you can assign 
        //         null to a value type variable or declare a value type variable without 
        //         assigning a value to it.
        //     */
        // }

        public static void ChangeString(string fruit)
        {
            fruit = "mango";
        }

        public static void ChangeRefType(Student std)
        {
            std.name = "Tails";
        }

        public class Student
        {
            public string? name {get; set;}
        }

        public static void ChangeValue(int x)
        {
            x = 2;
        }

    }
}