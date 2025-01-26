// 8. IMPLICITLY-TYPED VARIABLES
namespace Lesson8
{
    class Program8
    {
        // public static void Main()
        // {
        //     /*
        //     VAR

        //     In C#, variables must be declared with the data type. 
        //     These are called explicitly typed variables.
        //     */

        //     int i = 100; // Explicitly typed variable
        //     Console.WriteLine("i = " + i);

        //     /*
        //     C# 3.0 introduced the "var" keyword to declare method level variables without 
        //     specifying a data type explicitly.
        //     */

        //     var j = 100; // Implicitly typed local variable
        //     Console.WriteLine("j = " + j);

        //     /*
        //     The compiler will infer the type of a variable from the expression on the right 
        //     side of the = operator. Above, var will be compiled as int.

        //     The following infers the type from an expression.
        //     */

        //     int a = 10;
        //     var b = a + 1; // Compiled as int
        //     Console.WriteLine("a = " + a + ", b = " + b);

        //     /*
        //     "var" can be used to declare any built-in data type, user-defined type, or an 
        //     anonymous type variable. The following example shows the C# compiler infering 
        //     variables' types based on their values :
        //     */

        //     var nb = 10;
        //     Console.WriteLine("Type of nb is {0}", nb.GetType());

        //     var str = "Hello World!!";
        //     Console.WriteLine("Type of str is {0}", str.GetType());

        //     var doub = 100.50d;
        //     Console.WriteLine("Type of doub is {0}", doub.GetType());

        //     var isValid = true;
        //     Console.WriteLine("Type of isValid is {0}", isValid.GetType());

        //     var anon = new {name = "Steve"};
        //     Console.WriteLine("Type of anon is {0}", anon.GetType());

        //     var arr = new[] {1, 10, 20, 30};
        //     Console.WriteLine("Type of arr is {0}", arr.GetType());

        //     var file = new FileInfo("MyFile");
        //     Console.WriteLine("Type of file is {0}", file.GetType());

        //     /*
        //     Implicitly-typed variables must be initialized at the time of declaration; 
        //     otherwise C# compiler would give an error: Implicitly-typed variables must be 
        //     initialized.
        //     */

        //     // var c;
        //     /*
        //         Compiler Error CS0818 : Implicitly typed locals must be initialized.
        //         An implicitly typed local variable must be initialized with a value at the 
        //         same time as it is declared.
        //     */

        //     // Multiple declarations of "var" variables in a single statement are not allowed.

        //     // var d = 100, e = 200, f = 300;

        //     /*
        //     Compiler Error CS0819 : 
        //     Implicitly-typed variables cannot have multiple declarators.
        //     Multiple declarators are allowed in explicit type declarations, but not with 
        //     implicitly typed variables.
        //     */

        //     // "var" cannot be used for function parameters.

        //     // static void Display(var param)
        //     // {
        //     //     Console.Write(param);
        //     // }

        //     /*
        //     Compiler Error CS0825 : The contextual keyword 'var' may only appear within a 
        //     local variable declaration.
        //     */

        //     // "var" can be used in for and foreach loops.

        //     for(var g = 0; g <= 10; g++)
        //     {
        //         Console.WriteLine("g = " + g);
        //     }

        //     // "var" can also be used with LINQ (Language INtegrated Query) queries.

        //     // string collection
        //     IList<string> stringList =
        //     [
        //         "C# Tutorials",
        //         "VB.NET Tutorials",
        //         "Learn C++",
        //         "MVC Tutorials" ,
        //         "Java" 
        //     ];

        //     // LINQ Query Syntax
        //     var result = from strn in stringList
        //         where strn.Contains("Tutorials") 
        //     select strn;
        // }  
    }
}