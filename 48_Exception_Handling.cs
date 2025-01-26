// 48. EXCEPTION HANDLING

namespace Lesson48
{
    class Program48
    {
        // public static void Main()
        // {
        //     /*
        //         Here, you will learn about exception handling in C# using try, catch, and 
        //         finally blocks.

        //         Exceptions in the application must be handled to prevent crashing of the 
        //         program and unexpected result, log exceptions and continue with other 
        //         functionalities. C# provides built-in support to handle the exception using 
        //         try, catch & finally blocks.

        //         Syntax : trycatchfinally
        //     */

        //     /*
        //         try block: Any code that may raise exceptions should be put inside 
        //         a try block. During the execution, if an exception occurs, the flow of the 
        //         control jumps to the first matching catch block.

        //         catch block: The catch block is an exception handler block where you can 
        //         perform some action such as logging and auditing an exception. 
        //         The catch block takes a parameter of an exception type using which you can 
        //         get the details of an exception.

        //         finally block: The finally block will always be executed whether an exception 
        //         is raised or not. Usually, a finally block should be used to release resources, 
        //         for example, to close any stream or file objects that were opened in the try 
        //         block.

        //         The following may throw an exception if you enter a non-numeric character:
        //     */

        //     Console.WriteLine("Enter a number: ");

        //     var num = int.Parse(Console.ReadLine()!); // ! = Null forgiving operator

        //     Console.WriteLine($"Square of {num} is {num * num}.\n");

        //     /*
        //         To handle the possible exceptions in the above example, wrap the code inside 
        //         a try block and handle the exception in the catch block, as shown below.
        //     */

        //     try
        //     {
        //         Console.WriteLine("Try to enter a number: ");

        //         var num2 = int.Parse(Console.ReadLine()!); // ! = Null forgiving operator

        //         Console.WriteLine($"Square of {num2} is {num2 * num2}.");
        //     }

        //     catch
        //     {
        //         Console.WriteLine("Catch. Error occurred. ");
        //     }

        //     finally
        //     {
        //         Console.WriteLine("Finally. Retry with a different number.\n");
        //     }

        //     /*
        //         In the above example, we wrapped this code inside a try block. 
        //         If an exception occurs inside a try block, then the program will jump to the 
        //         catch block. Inside a catch block, we display a message to instruct the user 
        //         about his mistake, and in the finally block, we display a message about what 
        //         to do after running a program.

        //         A try block must be followed by catch or finally or both blocks. 
        //         The try block without a catch or finally block will give a compile-time error.
        //     */

        //     /*
        //         Ideally, a catch block should include a parameter of a built-in or custom 
        //         exception class to get an error detail. 
        //         The following includes the Exception type parameter that catches all types 
        //         of exceptions.
        //     */

        //     try
        //     {
        //         Console.WriteLine("Enter a number: ");

        //         var num3 = int.Parse(Console.ReadLine()!);

        //         Console.WriteLine($"Square of {num3} is {num3 * num3}.\n");
        //     }

        //     catch(Exception ex)
        //     {
        //         Console.WriteLine("Exception caught: " + ex.Message);
        //     }

        //     finally
        //     {
        //         Console.WriteLine("Retry with a different number.\n");
        //     }

        //     /*
        //         EXCEPTION FILTERS

        //         You can use multiple catch blocks with the different exception type parameters. 
        //         This is called exception filters. Exception filters are useful when you want 
        //         to handle different types of exceptions in different ways.
        //     */

        //     Console.WriteLine("Please enter a number to divide 100: ");
        
        //     try
        //     {
        //         int num4 = int.Parse(Console.ReadLine()!);

        //         int result = 100 / num4;

        //         Console.WriteLine($"result == {result}.");
        //     }

        //     catch(DivideByZeroException ex)
        //     {
        //         Console.WriteLine($"DivideByZeroException caught: {ex.Message}");
        //     }

        //     catch(InvalidOperationException ex)
        //     {
        //         Console.WriteLine($"InvalidOperationException caught: {ex.Message}");
        //     }

        //     catch(FormatException ex)
        //     {
        //         Console.WriteLine($"FormatException caught: {ex.Message}");
        //     }

        //     catch(Exception ex)
        //     {
        //         Console.WriteLine($"Exception caught: {ex.Message}");
        //     }

        //     /*
        //         In the above example, we have specified multiple catch blocks with different 
        //         exception types. We can display an appropriate message to the user, depending 
        //         upon the error, so the user does not repeat the same mistake again.

        //         Multiple catch blocks with the same exception type are not allowed. 
        //         A catch block with the base Exception type must be the last block.
        //     */

        //     /*
        //         INVALID CATCH BLOCK

        //         A parameterless catch block and a catch block with the Exception parameter 
        //         are not allowed in the same try-catch statements, because they both do the 
        //         same thing.
        //     */

        //     try
        //     {
        //         //code that may raise an exception
        //     }

        //     catch //cannot have both catch and catch(Exception ex)
        //     { 
        //         Console.WriteLine("Exception caught.");
        //     }

        //     /*
        //         Compile Error CS1017 :
        //         Catch clauses cannot follow the general catch clause of a try statement
        //         A catch block that does not take any parameters must be the last in a series 
        //         of catch blocks.
        //     */
        //     // catch(Exception ex) //cannot have both catch and catch(Exception ex)
        //     // {
        //     //     Console.WriteLine($"Exception caught:{ex.Message}.\n");
        //     // }

        //     /*
        //         Parameterless catch block catch{} or general catch block 
        //         catch(Exception ex) must be the last block. The compiler will give an error 
        //         if you have other catch blocks after a catch or catch(Exception ex) block.
        //     */

        //     try
        //     {
        //         //code that may raise an exception
        //     }

        //     catch
        //     { 
        //         //code that may raise an exception
        //     }

        //     // catch
        //     // { 
        //     //     // this catch block must be last block
        //     // }

        //     // catch (NullReferenceException nullEx)
        //     // {
        //     //     Console.WriteLine(nullEx.Message);
        //     // }

        //     // catch (InvalidCastException inEx)
        //     // {
        //     //     Console.WriteLine(inEx.Message);
        //     // }

        //     /*
        //         FINALLY BLOCK

        //         The finally block is an optional block and should come after a try or catch 
        //         block. The finally block will always be executed whether or not an exception 
        //         occurred. The finally block generally used for cleaning-up code e.g.,
        //         disposing of unmanaged objects.
        //     */

        //     // Initial file
        //     FileInfo? file = null;

        //     try
        //     {
        //         // Ask user to name the file
        //         Console.WriteLine("Enter a file name: ");

        //         // Get useer input
        //         string? fileName = Console.ReadLine();

        //         // If the file name is null or empty
        //         if(string.IsNullOrWhiteSpace(fileName))
        //         {
        //             // Throw an exception
        //             throw new ArgumentException("File name cannot be null or empty.");
        //         }

        //         // If the file name is valid
        //         else
        //         {
        //             // Create a file
        //             file = new FileInfo(fileName);

        //             // Create a writer object
        //             using (StreamWriter writer = file.AppendText())
        //             {
        //                 // Use the writer to write in the file
        //                 writer.WriteLine("Hello, World.");
        //             }
        //         }
        //     }

        //     catch(Exception ex)
        //     {
        //         Console.WriteLine($"Exception caught:{ex.Message}");
        //     }

        //     finally
        //     {
        //         file = null;
        //     }

        //     /*
        //         Multiple finally blocks are not allowed. Finally blocks cannot have 
        //         the "return", "continue", or "break" keywords. 
        //         It doesn't let control to leave the finally block.
        //     */

        //     /*
        //         NESTED TRY-CATCH

        //         C# allows nested try-catch blocks. When using nested try-catch blocks, an 
        //         exception will be caught in the first matching catch block that follows the 
        //         try block where an exception occurred.
        //     */

        //     var divider = 0;

        //     try
        //     {
        //         try
        //         {
        //             var result = 100/divider;
        //         }

        //         catch
        //         {
        //             Console.WriteLine("Inner catch.");
        //         }
        //     }

        //     catch
        //     {
        //         Console.WriteLine("Outer catch.");
        //     }

        //     /*
        //         An inner catch block will be executed in the above example because it is the 
        //         first catch block that handles all exception types.
        //     */

        //     /*
        //         If there isn't an inner catch block that matches with raised exception type, 
        //         then the control will flow to the outer catch block until it finds an 
        //         appropriate exception filter. Consider the following example.
        //     */

        //     var dividerA = 0;

        //     try
        //     {
        //         try
        //         {
        //             var result = 100/dividerA;
        //         }

        //         catch(NullReferenceException ex)
        //         {
        //             Console.WriteLine($"NullReferenceException caught:{ex.Message}");
        //         }
        //     }

        //     catch
        //     {
        //         Console.WriteLine("Outer catch.");
        //     }

        //     /*
        //         In the above example, an exception of type DivideByZeroException will be 
        //         raised. Because the inner catch block only handles the 
        //         NullReferenceTypeException, it will be handled by the outer catch block.
        //     */
        // }
    }
}