// 25. FOR LOOP

namespace Lesson25
{
    class Program25
    {
        // public static void Main()
        // {
        //     /*
        //         Here, you will learn how to execute a statement or code block multiple times 
        //         using the for loop, structure of the for loop, nested for loops, and how to 
        //         exit from the for loop.

        //         The for keyword indicates a loop in C#. The for loop executes a block of 
        //         statements repeatedly until the specified condition returns false.  

        //         Syntax:
        //         for (initializer; condition; iterator)
        //         {
        //             //code block
        //         } 

        //         The for loop contains the following three optional sections, separated by a 
        //         semicolon:

        //         Initializer: The initializer section is used to initialize a variable that 
        //         will be local to a for loop and cannot be accessed outside loop. 
        //         It can also be zero or more assignment statements, method call, increment, or 
        //         decrement expression e.g., ++i or i++, and await expression.

        //         Condition: The condition is a boolean expression that will return either true 
        //         or false. 
        //         If an expression evaluates to true, then it will execute the loop again; 
        //         otherwise, the loop is exited.

        //         Iterator: The iterator defines the incremental or decremental of the loop 
        //         variable.

        //         The following for loop executes a code block 10 times :
        //     */

        //     for(int a = 0; a < 10; a++)
        //     {
        //         Console.WriteLine($"a == {a}.");
        //     }

        //     /*
        //         In the above example, int a = 0 is an initializer where we define an int variable i and initialize it with 0. 
        //         The second section is the condition expression i < 10, if this condition returns true then it will execute a code block. 
        //         After executing the code block, it will go to the third section, iterator. 
        //         The i++ is an incremental statement that increases the value of a loop variable i by 1. 
        //         Now, it will check the conditional expression again and repeat the same thing until conditional expression returns false.
        //         The below figure illustrates the execution steps of the for loop.
        //     */

        //     /*
        //         If a code block only contains a single statement, then you don't need to wrap 
        //         it inside curly brackets {}, as shown below :
        //     */

        //     Console.WriteLine("\n");

        //     for(int b = 0; b < 10; b++)
        //     Console.WriteLine($"b == {b}.");

        //     Console.WriteLine("\n");

        //     /*
        //         An initializer, condition  and iterator sections are optional. You can 
        //         initialize a variable before for loop, and condition and iterator can be 
        //         defined inside a code block, as shown below.
        //     */

        //     int c = 0;

        //     for(;;)
        //     {
        //         if (c < 10)
        //         {
        //             Console.WriteLine($"c == {c}.");
        //             c++;
        //         }

        //         else
        //         {
        //             break;
        //         }
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         Since all three sections are optional in a for loop, be careful in defining 
        //         a condition and iterator. Otherwise, it will be an infinite loop that will 
        //         never end.
        //     */

        //     // Inifinite loop
        //     // for ( ; ; )
        //     // {
        //     //     Console.Write(1);
        //     // }

        //     /*
        //         The control variable for the for loop can be of any numeric data type, such 
        //         as int, uint, byte, sbyte, short, ushort float, long, double, decimal, etc.
        //     */

        //     for (double d = 1.01d; d < 1.10; d += 0.01d)
        //     {
        //         Console.WriteLine($"d == {d}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         The steps part in a for loop can either increase or decrease the value of a 
        //         variable.
        //     */

        //     for(int e = 10; e > 0; e--)
        //     {
        //         Console.WriteLine($"e == {e}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         EXIT A FOR LOOP

        //         You can also exit from a for loop by using the break keyword.
        //     */

        //     for (int f = 0; f < 10; f++)
        //     {
        //         if(f == 5)
        //         {
        //             Console.WriteLine("break");
        //             break;
        //         }

        //         Console.WriteLine($"f == {f}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         MULTIPLE EXPRESSIONS

        //         A for loop can also include multiple initializer and iterator statements 
        //         separated by comma, as shown below.
        //     */

        //     for (int g = 0, h = 0; g + h < 5; g++, h++)
        //     {
        //         Console.WriteLine($"g == {g}, h == {h}.");
        //     }

        //     Console.WriteLine("\n");

        //     // A for loop can also contain statements as an initializer and iterator.

        //     int i = 0, j = 5;

        //     // For i = 0 and j = 5, as long as i + 1 is less than j - 1, write the values of i and j
        //     for(Console.WriteLine($"Initializer: i = {i}, j = {j}."); i++ < j--; Console.WriteLine($"Iterator: i = {i}, j = {j}."));
        //     {
        //         Console.WriteLine($"i == {i}, j == {j}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         NESTED FOR LOOP

        //         C# allows a for loop inside another for loop.
        //     */

        //     for (int k = 0; k < 2; k++)
        //     {
        //         for(int l = k; l < 4; l++)
        //         {
        //             Console.WriteLine($"k == {k}, l == {l}.");
        //         }
        //     }
        // }
    }
}