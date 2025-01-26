// 30. STATIC CLASSES, METHODS, CONSTRUCTORS AND FIELDS
namespace Lesson30
{
    public class Program30
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, static means something which cannot be instantiated. 
        //         You cannot create an object of a static class and cannot access static 
        //         members using an object.

        //         C# classes, variables, methods, properties, operators, events, and 
        //         constructors can be defined as static using the static modifier keyword.
        //     */

        //     /*
        //         STATIC CLASS

        //         Apply the static modifier before the class name and after the access modifier 
        //         to make a class static. The following defines a static class with static 
        //         fields and methods.
        //     */

        //     Calculator.Sum(1, 2);

        //     /*
        //         Below, the Calculator class is a static. All the members of it are also static.

        //         You cannot create an object of the static class; therefore the members of the 
        //         static class can be accessed directly using a class name like 
        //         ClassName.MemberName, as shown below.
        //     */

        //     float result = Calculator.Sum(10, 25);
        //     Console.WriteLine(result);

        //     var calcType = Calculator.Type; 
        //     Calculator.Type = "Scientific";

        //     /*
        //         RULES FOR STATIC CLASSES

        //         1. Static classes cannot be instantiated.

        //         2. All the members of a static class must be static; otherwise the compiler 
        //         will give an error.

        //         3. A static class can contain static variables, static methods, static 
        //         properties, static operators, static events, and static constructors.

        //         4. A static class cannot contain instance members and constructors.

        //         5. Indexers and destructors can't be static.

        //         6. var cannot be used to define static members.

        //         You must specify a type of member explicitly after the static keyword.

        //         7. Static classes are sealed class and therefore, cannot be inherited.

        //         8. A static class cannot inherit from other classes.

        //         9. Static class members can be accessed using ClassName.MemberName.

        //         10. A static class remains in memory for the lifetime of the application 
        //         domain in which your program resides.
        //     */

        //     /*
        //         STATIC MEMBERS IN NON-STATIC CLASSES

        //         Non-static classes can contain one or more static methods, 
        //         fields, properties, events and other non-static members.

        //         It's more practical to define a non-static class with some static members, 
        //         than to declare an entire class as static.
        //     */

        //     /*
        //         STATIC FIELDS

        //         Static fields in a non-static class can be defined using the static keyword.

        //         Static fields of a non-static class is shared across all the instances. 
        //         So, changes done by one instance would reflect in others.
        //     */

        //     Stopwatch sw1 = new();
        //     Console.WriteLine($"Number of Stopwatches = {Stopwatch.instancesNb}.");

        //     Stopwatch sw2 = new();
        //     Console.WriteLine($"Number of Stopwatches = {Stopwatch.instancesNb}.");

        //     /*
        //         STATIC METHODS

        //         You can define one or more static methods in a non-static class. 
        //         Static methods can be called without creating an object. 
        //         You cannot call static methods using an object of the non-static class.

        //         The static methods can only call other static methods and access static 
        //         members. You cannot access non-static members of the class in the static 
        //         methods.
        //     */

        //     count++;
        //     Console.WriteLine($"count = {count}.");

        //     /*
        //         Console.WriteLine($"name = {name}."); 
        //         Compiler Error CS0120 : An object reference is required for the non-static 
        //         field, method, or property 'name'.
        //     */

        //     Display("text");
            
        //     /*
        //         SetRootFolder("Path/to/file");
        //         Compiler Error CS0120 : An object reference is required for the non-static 
        //         field, method, or property 'Program30.SetRootFolder'.
        //     */

        //     /*
        //         RULES FOR STATIC METHODS

        //         1.  Static methods can be defined using the static keyword before a return 
        //             type and after an access modifier.

        //         2.  Static methods can be overloaded but cannot be overridden.

        //         3.  Static methods can contain local static variables.

        //         4.  Static methods cannot access or call non-static variables unless they are 
        //             explicitly passed as parameters.
        //     */

        //     /*
        //         STATIC CONSTRUCTORS

        //         A non-static class can contain a parameterless static constructor. 
        //         It can be defined with the static keyword and without access modifiers like 
        //         public, private, and protected.

        //         The following example demonstrates the difference between static constructor 
        //         and instance constructor.
        //     */

        //     /*
        //         Above, the non-static class StopWatch contains a static constructor and also 
        //         a non-static constructor.

        //         The static constructor is called only once whenever the static method is used 
        //         or creating an instance for the first time. The following example shows that 
        //         the static constructor gets called when the static method called for the first 
        //         time. Calling the static method second time onwards won't call a static
        //         constructor.
        //     */

        //     Console.WriteLine("\n");

        //     StopwatchB.DisplayInfo();
        //     StopwatchB.DisplayInfo();

        //     Console.WriteLine("\n");

        //     /*
        //         The following example shows that the static constructor gets called when you 
        //         create an instance for the first time.
        //     */

        //     StopwatchB sb1 = new(); 
        //     Console.WriteLine($"sb1 = {sb1}.");

        //     Console.WriteLine("\n");

        //     StopwatchB sb2 = new(); 
        //     Console.WriteLine($"sb2 = {sb2}.");
        //     StopwatchB.DisplayInfo();

        //     Console.WriteLine("\n");

        //     /*
        //         RULES FOR STATIC CONSTRUCTORS

        //         1. The static constructor is defined using the static keyword and without 
        //         using access modifiers public, private, or protected.

        //         2. A non-static class can contain one parameterless static constructor. 
        //         Parameterized static constructors are not allowed.

        //         3. Static constructor will be executed only once in the lifetime. 
        //         So, you cannot determine when it will get called in an application if a class is being used at multiple places.

        //         4. A static constructor can only access static members. 
        //         It cannot contain or access instance members.

        //         Static members are stored in a special area in the memory called 
        //         High-Frequency Heap. 
        //         Static members of non-static classes are shared across all instances of 
        //         the class. 
        //         So, the changes done in one instance will be reflected in all other 
        //         instances.
        //     */
        // }

        // Non-static class
        public class StopwatchB
        {
            // Static constructor
            static StopwatchB()
            {
                Console.WriteLine("Static constructor StopwatchB called.");
            }

            // Instance constructor
            public StopwatchB()
            {
                Console.WriteLine("Instance constructor StopwatchB called.");
            }

            // Static method
            public static void DisplayInfo()
            {
                Console.WriteLine("DisplayInfo of StopwatchB called.");
            }

            // Instance method
            public void Start()
            {
                Console.WriteLine($"Start of StopwatchB called.");
            }

            // Instance method
            public void Stop()
            {
                Console.WriteLine($"Stop of StopwatchB called.");
            }
        }

        // Static field
        // static int count = 0;

        // Non-static field
        // string? name = "demo program";

        // Static method
        static void Display(string? text)
        {
            Console.WriteLine($"text = {text}.");
        }

        // Non-static method
        public void SetRootFolder(string path)
        {
            Console.WriteLine($"File path = {path}.");
        }

        public class Stopwatch
        {
            public static int instancesNb = 0;
            
            // Instance constructor
            public Stopwatch()
            {
                Stopwatch.instancesNb++;
            }
        }

        public static class Calculator
        {
            // Static fields
            private static float result = 0;
            
            public static string? Type = "arithmetic";

            // Static methods
            public static float Sum(float num1, float num2)
            {
                Console.WriteLine($"{num1} + {num2} = {num1+num2}.");
                return num1 + num2;
            }

            public static void Store(float resultValue)
            {
                result = resultValue;
            }
        }
    }
}