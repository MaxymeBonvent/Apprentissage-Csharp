// 54. PREDICATE DELEGATE

namespace Lesson54
{
    class Program54
    {
        // public static void Main()
        // {
        //     /*
        //         Predicate is a delegate like Func and Action delegates. 
        //         It represents a method containing a set of criteria and checks whether the 
        //         passed parameter meets those criteria. 
        //         A predicate delegate methods must take 1 input parameter and return a 
        //         boolean.

        //         The Predicate delegate is defined in the System namespace, as shown below:

        //         Predicate signature: public delegate bool Predicate<inp T>(T obj);

        //         Like other delegate types, Predicate can also be used with any method, 
        //         anonymous method, or lambda expression.
        //     */

        //     Predicate<string> isUpperP = IsUpperCase;

        //     bool result = isUpperP("hello, world.");

        //     Console.WriteLine($"result == {result}.\n");

        //     /*
        //         An anonymous method can also be assigned to a Predicate delegate type as 
        //         shown below.
        //     */

        //     Predicate<string> isUpperP2 = delegate(string s) 
        //     { 
        //         return s.Equals(s.ToUpper());
        //     };

        //     bool result2 = isUpperP2("hello, world.");

        //     Console.WriteLine($"result2 == {result2}.\n");

        //     /*
        //         A lambda expression can also be assigned to a Predicate delegate type as 
        //         shown below.
        //     */

        //     Predicate<string> isUpperP3 = s => s.Equals(s.ToUpper());

        //     bool result3 = isUpperP3("hello, world.");

        //     Console.WriteLine($"result3 == {result3}.\n");
        // }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}