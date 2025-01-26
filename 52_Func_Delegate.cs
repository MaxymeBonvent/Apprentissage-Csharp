// 52. FUNC DELEGATE

namespace Lesson52
{
    class Program52
    {
        // public static void Main()
        // {
        //     /*
        //         C# includes built-in generic delegate types Func and Action, so that you 
        //         don't need to define custom delegates manually in most cases.

        //         Func is a generic delegate included in the System namespace. 
        //         It has zero or more input parameters and one out parameter. 
        //         The last parameter is considered as an out parameter.

        //         The Func delegate that takes one input parameter and one out parameter is 
        //         defined in the System namespace, as shown below:

        //         namespace System
        //         {    
        //             public delegate TResult Func<in T, out TResult>(T arg);
        //         }

        //         The last parameter in the angle brackets <> is considered the return type, 
        //         and the remaining parameters are considered input parameter types, as shown 
        //         in the following figure.

        //         A Func delegate with two input parameters and one out parameters will be 
        //         represented as shown below.

        //         The following Func delegate takes two input parameters of int type and returns a value of int type:
        //     */

        //     Func<int, int, int> sum = default!;
        //     Console.WriteLine($"sum == {sum}.\n");

        //     /*
        //         You can assign any method to the above func delegate that takes two int 
        //         parameters and returns an int value.
        //     */
            
        //     Func<int, int, int> add = Sum;
        //     int result =  add(2, 3);
        //     Console.WriteLine($"result == {result}.\n");

        //     /*
        //         A Func delegate type can include 0 to 16 input parameters of different types. 
        //         However, it must include an out parameter for the result. 
        //         For example, the following Func delegate doesn't have any input parameter, 
        //         and it includes only an out parameter.
        //     */

        //     Func<int> getRandNb = default!;
        //     Console.WriteLine($"getRandNb == {getRandNb}.\n");

        //     /*
        //         C# FUNC WITH AN ANONYMOUS METHOD

        //         You can assign an anonymous method to a Func delegate by using the "delegate" 
        //         keyword.
        //     */

        //     Func<int> getRandNb2 = delegate()
        //     {
        //         Random rnd = new();
        //         int res = rnd.Next(0, 100);

        //         Console.WriteLine($"res == {res}.\n");
        //         return res;
        //     };

        //     /*
        //         FUNC WITH LAMBDA EXPRESSION

        //         A Func delegate can also be used with a lambda expression, as shown below:
        //     */

        //     Func<int> getRandNb3 = () => new Random().Next(1, 100);

        //     //Or 
        //     Func<int, int, int>  sumA  = (x, y) => x + y;

        //     /*
        //         Points to Remember :

        //         1. Func is built-in delegate type.
        //         2. Func delegate type must return a value.
        //         3. Func delegate type can have 0 to 16 input parameters.
        //         4. Func delegate does not allow ref and out parameters.
        //         5. Func delegate type can be used with an anonymous method or 
        //         lambda expression.
        //     */
        // }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}