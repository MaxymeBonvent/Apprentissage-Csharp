// 14. ENUM

namespace Lesson14
{
    class Program14
    {
        // Enums must be defined outside of Main()
        enum WeekDays
        {
            Monday, // 0
            Tuesday, // 1
            Wednesday, // 2
            Thursday, // 3
            Friday, // 4
            Saturday, // 5
            Sunday // 6
        }

        enum Categories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            Travel,         // 8
            Fashion         // 9
        }

        enum Categories2
        {
            Electronics = 4,  
            Food = 22, 
            Automotive = 1, 
            Arts = 10, 
            Travel = 16, 
            Fashion = 12,
            Education = 12
        }

        enum Categories3: byte
        {
            Electronics = 1,  
            Food = 5, 
            Automotive = 6, 
            Arts = 10, 
            BeautyCare = 11, 
            Fashion = 15
        }

//         public static void Main()
//         {
//             /*
//                 In C#, an enum (or enumeration type) is used to assign constant names to a 
//                 group of numeric integer values. It makes constant values more readable, for 
//                 example, WeekDays.Monday is more readable then number 0 when referring to the 
//                 day in a week.

//                 An enum is defined using the enum keyword, directly inside a namespace, class, 
//                 or structure. All the constant names can be declared inside the curly brackets 
//                 and separated by a comma. The following defines an enum for the weekdays.
//             */

//             /*  Above (line 8), the WeekDays enum declares members in each line separated by 
//                 a comma.

//                 ENUM VALUES
// .
//                 If values are not assigned to enum members, the compiler will assign 
//                 integer values to each member starting with 0 by default. The first member 
//                 of an enum will be 0, and the value of each successive enum member is 
//                 increased by 1.

                
//                 You can assign different values to enum member. A change in the default value 
//                 of an enum member will automatically assign incremental values to the other 
//                 members sequentially.

//                 You can even assign different values to each member.

//                 The enum can be of any numeric data type such as byte, sbyte, short, ushort, 
//                 int, uint, long, or ulong. However, an enum cannot be a string type.

//                 Specify the type after enum name as ": type". The following defines the byte 
//                 enum.
//             */

//             /*
//                 ACCESS AN ENUM

//                 An enum can be accessed using the dot syntax: enum.member
//             */

//             Console.WriteLine($"WeekDays.Monday = {WeekDays.Monday}"); 
//             Console.WriteLine($"WeekDays.Tuesday = {WeekDays.Tuesday}"); 
//             Console.WriteLine($"WeekDays.Wednesday = {WeekDays.Wednesday}"); 
//             Console.WriteLine($"WeekDays.Thursday = {WeekDays.Thursday}");
//             Console.WriteLine($"WeekDays.Friday = {WeekDays.Friday}"); 
//             Console.WriteLine($"WeekDays.Saturday = {WeekDays.Saturday}");
//             Console.WriteLine($"WeekDays.Sunday = {WeekDays.Sunday}");

//             /*
//                 CONVERSION

//                 Explicit casting is required to convert from an enum type to its underlying 
//                 integer type.
//             */

//             Console.WriteLine($"WeekDays.Friday = {WeekDays.Friday}");

//             // Enum to Int conversion
//             int numDay = (int) WeekDays.Friday;
//             Console.WriteLine($"numDay = {numDay}");
                    
//             // Int to Enum conversion
//             var wd = (WeekDays) 5;
//             Console.WriteLine($"wd = {wd}");

//             // enum is an abstract class.
//         }
    }
}