// 23. TERNARY OPERATOR ?:

namespace Lesson23
{
    class Program23
    {
        // public static void Main()
        // {
        //     /*
        //         C# includes a decision-making operator ?: which is called the conditional 
        //         operator or ternary operator. It is the short form of the if else conditions.

        //         Syntax:
        //         condition ? statement 1 : statement 2;


        //         The ternary operator starts with a boolean condition. 
        //         If this condition evaluates to true it will execute the first statement 
        //         after ?, otherwise the second statement after : will be executed.

        //         The following example demonstrates the ternary operator :
        //     */

        //     int a = 20, b = 10;

        //     string result = a > b ? "a is greater than b." : "a is less than or equal to b.";

        //     Console.WriteLine(result);

        //     /*
        //         Above, a conditional expression a > b returns true, so the first statement 
        //         after ? will be execute.

        //         The following executes the second statement :
        //     */

        //     int c = 10, d = 100;

        //     string result2 = c > d ? "c is greater than d." : "c is less than or equal to d.";

        //     Console.WriteLine(result2);

        //     /*
        //         Thus, a ternary operator is a short form of if else statement. 
        //         The above example can be rewritten using an if else statement, as shown below :
        //     */

        //     int e = 10, f = 100;

        //     if (e > f)
        //     {
        //         Console.WriteLine("e is greater than f.");
        //     }
                
        //     else
        //     {
        //         Console.WriteLine("e is less than or equal to f.");
        //     }

        //     /*
        //         NESTED TERNARY OPERATOR

        //         Nested ternary operators are possible by including a conditional expression 
        //         as a second statement.
        //     */

        //     int g = 10, h = 11;

        //     string result3 = g > h ? "g is greater than h." : 
        //                         g < h ? "g is less than h." : 
        //                             g == h ? "g is equal to h." : "No result.";

        //     Console.WriteLine(result3);

        //     /*
        //         The ternary operator is right-associative. The expression a ? b : c ? d : e 
        //         is evaluated as a ? b : (c ? d : e), not as (a ? b : c) ? d : e.
        //     */

        //     int i = 2, j = 10, k = 11;

        //     string result4 = i * 3 > j ? "i * 3 is greater than j." : 
        //     j > k ? "j is greater than k." : "j is less than or equal to k.";

        //     Console.WriteLine(result4);
        // }
    }
}