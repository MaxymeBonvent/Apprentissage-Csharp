// 58. EXTENSION METHOD

using ExtensionMethods;

namespace Lesson58
{
    class Program58
    {
        // public static void Main()
        // {
        //     /*
        //         Extension methods, as the name suggests, are additional methods. 
        //         Extension methods allow you to inject additional methods without modifying, 
        //         deriving or recompiling the original class, struct or interface. 
        //         Extension methods can be added to your own custom class, .NET framework 
        //         classes, or third party classes or interfaces.

        //         In the following example, IsGreaterThan() is an extension method for int 
        //         type, which returns true if the value of the int variable is greater than 
        //         the supplied integer parameter.

        //         int i = 10;

        //         bool result = i.IsGreaterThan(100);

        //         The IsGreaterThan() method is not a method of int data type (Int32 struct). 
        //         It is an extension method written by the programmer for the int data type. 
        //         The IsGreaterThan() extension method will be available throughout the 
        //         application by including the namespace in which it has been defined.

        //         Extension methods have a special symbol in VS's Intellisense, so that you can
        //         easily differentiate between class methods and extension methods.

        //         Now let's see how to write an extension method.

        //         (Tip: LINQ is built upon extension methods that operate on IEnumerable and 
        //         IQueryable type.)
        //     */

        //     /*
        //         An extension method is actually a special kind of static method defined in a 
        //         static class. To define an extension method, first of all, define a static 
        //         class.

        //         For example, we have created an IntExtensions class under the
        //         ExtensionMethods namespace in the following example. 
        //         The IntExtensions class will contain all the extension methods applicable to 
        //         int data type.
        //     */

        //     /*
        //         Now, define a static method as an extension method where the first parameter 
        //         of the extension method specifies the type on which the extension method is 
        //         applicable. We are going to use this extension method on int type. 
        //         So the first parameter must be int preceded with the this modifier.

        //         For example, the IsGreaterThan() method operates on int, so the first 
        //         parameter would be, this int i.
        //     */

        //     /*
        //         Now, you can include the ExtensionMethods namespace wherever you want to use 
        //         this extension method.
        //     */

        //     int a = 10;

        //     bool result = a.IsGreaterThan(11);
        //     Console.WriteLine(result);

        //     /*
        //         The only difference between a regular static method and an extension method 
        //         is that the first parameter of the extension method specifies the type that 
        //         it is going to operator on, preceded by the "this" keyword.
        //     */
        // }
    }
}

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            // "this int i" is the variable that will be in front of the method name
            // "int value" is the one in the parenthesis when the method will be called
            return i > value;
        }
    }
}