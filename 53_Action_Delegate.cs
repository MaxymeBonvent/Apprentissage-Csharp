// 53. ACTION DELEGATE

namespace Lesson53
{
    class Program53
    {
        // public static void Main()
        // {
        //     /*
        //         Action is a delegate type defined in the System namespace. 
        //         An Action type delegate is the same as Func delegate except that the Action 
        //         delegate doesn't return a value. 
        //         In other words, an Action delegate can be used with a method that has a void 
        //         return type.

        //         For example, the following delegate prints an int value.  
        //     */

        //     // Func delegate
        //     Print prnt = ConsolePrint;
        //     prnt(1);

        //     /*
        //         You can use an Action delegate instead of defining the above Print delegate, 
        //         for example:
        //     */

        //     Action<int> printActionDel = ConsolePrint;
        //     printActionDel(2);

        //     /*
        //         You can initialize an Action delegate using the new keyword or by directly 
        //         assigning a method:
        //     */

        //     Action<int> printActionDelA = ConsolePrint;

        //     Action<int> printActionDelB = new Action<int>(ConsolePrint);

        //     /*
        //         An Action delegate can take up to 16 input parameters of different types.
        //         An Anonymous method can also be assigned to an Action delegate, for example:
        //     */

        //     Action<int> printActionDelC = delegate(int nb)
        //     {
        //         Console.WriteLine($"nb == {nb}.\n");
        //     };

        //     printActionDelC(3);

        //     // A lambda expression also can be used with an Action delegate:

        //     Action<int> printActionDelD = nb => Console.WriteLine($"nb == {nb}.\n");
       
        //     printActionDelD(4);

        //     /*
        //         Thus, you can use any method that doesn't return a value with Action 
        //         delegate types.
        //     */

        //     /*
        //         ADVANTAGES OF ACTION AND FUNC DELEGATES

        //         1. It's easy and quick to define delegates.
        //         2. It shortens code.
        //         3. It's a compatible type throughout the application.
        //     */

        //     /*
        //         Points to Remember :

        //         1. Action delegate is the same as func delegate except that it does not return 
        //         anything. Return type must be void.

        //         2. Action delegate can have 0 to 16 input parameters.

        //         3. Action delegate can be used with anonymous methods or lambda expressions.
        //     */
        // }

        public delegate void Print(int nb);

        static void ConsolePrint(int nb)
        {
            Console.WriteLine($"nb == {nb}.\n");
        }
    }
}