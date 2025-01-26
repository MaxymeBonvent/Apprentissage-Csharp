// 27. WHILE LOOP

namespace Lesson27
{
    class Program27
    {
        // public static void Main()
        // {
        //     /*
        //         C# provides the while loop to repeatedly execute a block of code as long as 
        //         the specified condition returns true.

        //         Syntax:
        //         while(condition)
        //         {
        //             //code block
        //         } 

        //         The while loop starts with the while keyword, and it must include a boolean 
        //         conditional expression inside brackets that returns either true or false. 
        //         It executes the code block until the specified conditional expression returns 
        //         false.

        //         The for loop contains the initialization and increment/decrement parts. 
        //         When using the while loop, initialization should be done before the loop starts, 
        //         and increment or decrement steps should be inside the loop.
        //     */

        //     int a = 0; // Initialization

        //     while (a < 10) // Condition
        //     {
        //         Console.WriteLine($"a = {a}.");

        //         a++; // Increment
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         Above, a while loop includes an expression i < 10. Inside a while loop, the 
        //         value of i increased to 1 using i++. The above while loop will be executed 
        //         when the value of i equals to 10 and a condition i < 10 returns false.

        //         Use the break or return keyword to exit from a while loop on some condition, 
        //         as shown below.
        //     */

        //     int b = 0;

        //     while (true)
        //     {
        //         Console.WriteLine($"b = {b}.");

        //         b++;

        //         if (b > 9)
        //         {
        //             Console.WriteLine("break");
        //             break;
        //         }
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         Ensure that the conditional expression evaluates to false or exit from the 
        //         while loop on some condition like break to avoid an infinite loop. 
        //         The following loop is missing an appropriate condition or break the loop, 
        //         which makes it an infinite while loop.
        //     */

        //     int c = 1;

        //     // Infinite loop without "break;"
        //     while (c > 0)
        //     {
        //         Console.WriteLine($"c = {c}.");
        //         c++;
        //         break;
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         NESTED WHILE LOOP

        //         C# allows while loops inside another while loop, as shown below. However, it 
        //         is not recommended to use nested while loop because it makes it hard to debug 
        //         and maintain.
        //     */

        //     int d = 0, e = 1;

        //     while (d < 2)
        //     {
        //         Console.WriteLine($"d = {d}.");
        //         d++;

        //         while (e < 2)
        //         {
        //             Console.WriteLine($"e = {e}.");
        //             e++;
        //         }
        //     }
        // }
    }
}