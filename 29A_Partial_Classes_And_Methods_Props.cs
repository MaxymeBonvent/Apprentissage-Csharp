// 29A. PARTIAL CLASSES AND METHODS - EmployeeProps

namespace Lesson29
{
    class Program29A
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, you can split the implementation of a class, a struct, a method, or an 
        //         interface in multiple .cs files using the "partial" keyword. The compiler will 
        //         combine all implementations from multiple .cs files when the program is 
        //         compiled.

        //         Consider the following EmployeeProps.cs and EmployeeMethods.cs files that 
        //         contain the Employee class.  
        //     */

        //     /*
        //         RULES FOR PARTIAL CLASSES

        //         All the partial class definitions must be in the same assembly and namespace.

        //         All the parts must have the same accessibility like public or private, etc.

        //         If any part is declared abstract, sealed or base type then the whole class is 
        //         declared of the same type.

        //         Different parts can have different base types and so the final class will 
        //         inherit all the base types.

        //         The Partial modifier can only appear immediately before the keywords class, 
        //         struct, or interface.

        //         Nested partial types are allowed.
        //     */

        //     /*
        //         PARTIAL METHODS

        //         Partial classes or structs can contain a method that split into two separate 
        //         .cs files of the partial class or struct. One of the two .cs files must 
        //         contain a signature of the method, and other file can contain an optional 
        //         implementation of the partial method. Both declaration and implementation of 
        //         a method must have the partial keyword.
        //     */

        //     /*
        //         Below, EmployeeProps.cs contains the declaration of the partial method 
        //         GenerateEmpID() which is being used in the constructor.EmployeeMethods.cs 
        //         contains the implementation of the GenerateEmployeeId() method. 
        //         The following demonstrates creates an object the Employee class which used 
        //         the partial method.
        //     */

        //     for(int nb = 0; nb < 10; nb++)
        //     {
        //         Employee emp = new();
        //         Console.WriteLine($"Employee {nb+1}'s ID = {emp.ID}.");
        //     }

        //     /*
        //         RULES FOR PARTIAL METHODS

        //         Partial methods must use the partial keyword and must return void.
        //         Partial methods can have in or ref but not out parameters.
        //         Partial methods are implicitly private methods, so cannot be virtual.
        //         Partial methods can be static methods.
        //         Partial methods can be generic.
        //     */
        // }
    }

    // Partial classes must be defined outside of Main's class
    public partial class Employee
    {
        // Fields
        public int ID {get; set;}
        public string? Name {get; set;}

        // Partial method
        public partial void GenerateEmpID();

        // Constructor
        public Employee() 
        { 
            GenerateEmpID();
        }
    }
}