// 28. DO WHILE LOOP 

namespace Lesson28
{
    class Program28
    {
        // public static void Main()
        // {
        //     /*
        //         The do while loop is the same as while loop except that it executes the 
        //         code block at least once.

        //         Syntax:

        //         do
        //         {
        //             // code block
        //         } 
        //         while(condition); 

        //         The do-while loop starts with the do keyword followed by a code block and a 
        //         boolean expression after the while keyword. The do-while loop stops execution 
        //         when the condition is false. 
        //         Because the while(condition) is specified at the end of the block, the code 
        //         block must be executed at least once.
        //     */

        //     int a = 0;

        //     do
        //     {
        //         Console.WriteLine($"a = {a}.");
        //         a++;

        //     } while (a < 5);

        //     Console.WriteLine("\n");

        //     /*
        //         Specify an initializer out of the loop and increment or decrement a counter 
        //         inside it.

        //         Use break or return to exit from the do-while loop.
        //     */

        //     int b = 0;

        //     do
        //     {
        //         Console.WriteLine($"b = {b}.");
        //         b++;
                
        //         if (b > 5)
        //         {
        //             Console.WriteLine("break");
        //             break;
        //         }
                    

        //     } while (b < 10);

        //     Console.WriteLine("\n");

        //     /*
        //         NESTED DO-WHILE

        //         The do-while loop can be used inside another do-while loop.
        //     */

        //     int c = 0;

        //     do
        //     {
        //         Console.WriteLine($"c = {c}.");
        //         int d = c;

        //         c++;
                            
        //         do
        //         {
        //             Console.WriteLine($"d = {d}.");
        //             d++;
        //         } while (d < 3);

        //     } while (c < 3);

        //     Console.WriteLine("\n");
        // }
    }
}