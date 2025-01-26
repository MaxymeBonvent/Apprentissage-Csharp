// 17. DYNAMIC TYPES

namespace Lesson17
{
    class Program17
    {
        // public static void Main()
        // {
        //     /*
        //         C# 4.0 (.NET 4.5, 2010) introduced a new type called dynamic that avoids 
        //         compile-time type checking. A dynamic type escapes type checking at 
        //         compile-time. Instead it resolves type at run time.

        //         A dynamic type variables is defined using the "dynamic" keyword.   
        //     */

        //     dynamic dyn = 1;
        //     Console.WriteLine($"dyn = {dyn}. Type of dyn = {dyn.GetType()}.");

        //     /*
        //         The compiler compiles dynamic types into object types in most cases. 
        //         However, the actual type of a dynamic type variable is resolved at 
        //         run-time.

        //         Dynamic types change types at run-time based on the assigned value. 
        //         The following example shows how a dynamic variable changes type based on 
        //         assigned value.
        //     */

        //     dynamic dyn2 = 0;
        //     Console.WriteLine($"Value of dyn2 = {dyn2}, Type of dyn2 = {dyn2.GetType()}.");

        //     dyn2 = "hello";
        //     Console.WriteLine($"Value of dyn2 = {dyn2}, Type of dyn2 = {dyn2.GetType()}.");

        //     dyn2 = false;
        //     Console.WriteLine($"Value of dyn2 = {dyn2}, Type of dyn2 = {dyn2.GetType()}.");

        //     dyn2 = DateTime.Today;
        //     Console.WriteLine($"Value of dyn2 = {dyn2.ToString("dd/MM/yyyy")}, Type of dyn2 = {dyn2.GetType()}.");

        //     // Dynamic type variables are converted to other types implicitly.

        //     dynamic dyn3 = 1;
        //     int nb = dyn3;
        //     Console.WriteLine($"\nValue of dyn3 = {dyn3}, Type of dyn3 = {dyn3.GetType()}.");
                    
        //     dyn3 = "hello";
        //     string msg = dyn3;
        //     Console.WriteLine($"Value of dyn3 = {dyn3}, Type of dyn3 = {dyn3.GetType()}.");
                    
        //     dyn3 = DateTime.Now;
        //     DateTime dt = dyn3;
        //     Console.WriteLine($"Value of dyn3 = {dyn3.ToString("dd/MM/yyyy")}, Type of dyn3 = {dyn3.GetType()}.");

        //     /*
        //         METHODS AND PARAMETERS

        //         If you assign a class object to the dynamic type, then the compiler would not 
        //         check for correct methods and properties name of a dynamic type that holds the 
        //         custom class object. Consider the following example :
        //     */

        //     dynamic stud = new Student();
        //     Console.WriteLine($"stud = {stud}.");

        //     // Unhandled exceptions
        //     // stud.ShowInfo(1, "Bill");
        //     // stud.ShowInfo("1");
        //     // stud.FakeMethod();

        //     stud.ShowInfo(1);

        //     /*
        //         In the above example, the C# compiler does not check for the number of 
        //         parameters, parameters type, or non-existent. It validates these things at 
        //         run-time, and if it is not valid, then throws a run-time exception. Note that 
        //         Visual Studio IntelliSense is not supported for the dynamic types.

        //         The Dynamic Language Runtime (DLR) API provides the infrastructure that 
        //         supports the dynamic type in C#.
        //     */
        // }

        public class Student
        {
            public void ShowInfo(int id)
            {
                Console.WriteLine($"Student ID = {id}.");
            }
        }
    }
}