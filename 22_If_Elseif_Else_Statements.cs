// 22. IF, ELSE IF, ELSE STATEMENTS

namespace Lesson22
{
    class Program22
    {
        // public static void Main()
        // {
        //     /*
        //         C# provides many decision-making statements that help the flow of the C# 
        //         program based on certain logical conditions. Here, you will learn about if, 
        //         else if, else, and nested if else statements to control the flow based on the 
        //         conditions.

        //         C# includes the following flavors of if statements:

        //         1. if statement
        //         2. else-if statement
        //         3. else statement
        //     */

        //     /*
        //         IF STATEMENT

        //         The if statement contains a boolean condition followed by a single or 
        //         multi-line code block to be executed. At runtime, if a boolean condition 
        //         evaluates to true, then the code block will be executed, otherwise it won't.

        //         Syntax :
        //         if(condition)
        //         {

        //         }
        //     */

        //     int a = 10, b = 20;

        //     if (a < b)
        //     {
        //         Console.WriteLine("a is less than b.");
        //     }        

        //     if (a > b)
        //     {
        //         Console.WriteLine("a is greater than b.");
        //     }

        //     /*
        //         In the above example, a boolean condition in the first if statement a < b 
        //         evaluates to true, so the C# compiler will execute the following code block. 
        //         The second if statement's condition a >  evaluates to false, so the compiler 
        //         will not execute its code block.

        //         The conditional expression must return a boolean value, otherwise C# compiler 
        //         will give a compile-time error.
        //     */

        //     // int c = 10, d = 20;

        //     // if (c + 1) Error CS0029 : Cannot implicitly  convert "int" to "bool".
        //     // {
        //     //     Console.WriteLine("c is less than d.");
        //     // }        

        //     // if (c + d) Error CS0029 : Cannot implicitly  convert "int" to "bool".
        //     // {
        //     //     Console.WriteLine("c is greater than d.");
        //     // }

        //     // You can call a function in an if statement that returns a boolean value.

        //     int e = 10, f = 20;

        //     if (IsGreater(e, f))
        //     {
        //         Console.WriteLine("e is greater than f.");
        //     }        

        //     if (IsGreater(f, e))
        //     {
        //         Console.WriteLine("f is greater than e.");
        //     }

        //     /*
        //         ELSE IF STATEMENT

        //         Multiple else if statements can be used after an if statement. 
        //         It will only be executed when the first if condition evaluates to false. 
        //         So, either if or one of the else if statements can be executed, but not both.

        //         Syntax:
        //         if(condition1)
        //         {
                
        //         }

        //         else if(condition2)
        //         {
                
        //         }

        //         else if(condition3)
        //         {
                
        //         }

        //         The following example demonstrates else if statements :
        //     */

        //     int g = 10, h = 20;

        //     if (g == h)
        //     {
        //         Console.WriteLine("g is equal to h.");
        //     }

        //     else if (g > h)
        //     {
        //         Console.WriteLine("g is greater than h.");
        //     }

        //     else if (g < h)
        //     {
        //         Console.WriteLine("g is less than h.");
        //     }

        //     /*
        //         ELSE STATEMENT

        //         The else statement can come only after if or else if statement and can be used 
        //         only once in the if-else statements. The else statement cannot contain any 
        //         condition and will be executed when all the previous if and else if conditions 
        //         evaluate to false.
        //     */

        //     int i = 20, j = 20;

        //     if (i > j)
        //     {
        //         Console.WriteLine("i is greater than j.");
        //     }

        //     else if (i < j)
        //     {
        //         Console.WriteLine("i is less than j.");
        //     }

        //     else
        //     {
        //         Console.WriteLine("i is equal to j.");
        //     }

        //     /*
        //         NESTED IF STATEMENTS

        //         C# supports if else statements inside other if else statements. 
        //         These are called nested if else statements. 
        //         The nested if statements make the code more readable.

        //         Syntax:

        //         if(condition1)
        //         {
        //            if(subcondition1)
        //             {
                        
        //             } 
        //         }

        //         The following example demonstrates nested if else statements :
        //     */

        //     int k = 10, l = 20;

        //     if (k != l)
        //     {
        //         if (k < l)
        //         {
        //             Console.WriteLine("k is less than l.");
        //         }

        //         else if (k > l)
        //         {
        //         Console.WriteLine("k is greater than l.");
        //         }
        //     }

        //     else
        //     {
        //         Console.WriteLine("k is equal to l.");
        //     }
            
        // }

        static bool IsGreater(int i, int j)
        {
            return i > j;                    
        }
    }
}