// 55. ANONYMOUS METHOD

namespace Lesson55
{
    class Program55
    {
        // public static void Main()
        // {
        //     /*
        //        As the name suggests, an anonymous method is a method without a name. 
        //        Anonymous methods in C# can be defined using the "delegate" keyword and can be 
        //        assigned to a variable of delegate type. 
        //     */

        //     Print print = delegate(int nb) 
        //     { 
        //         Console.WriteLine($"Inside an anonymous method. nb == {nb}.\n"); 
        //     };

        //     print(1);

        //     // Anonymous methods can access variables defined in an outer function.

        //     int i = 1;
    
        //     Print printA = delegate(int nb) 
        //     {
        //         nb += i;
        //         Console.WriteLine($"Anonymous method. nb == {nb}.\n");
        //     };

        //     printA(2);

        //     /*
        //         Anonymous methods can also be passed to a method that accepts a delegate as 
        //         a parameter.

        //         In the following example, PrintHelperMethod() takes the first parameters of 
        //         the Print delegate: 
        //     */

        //     PrintHelperMethod(delegate(int nb) 
        //     {
        //         Console.WriteLine($"Anonymous method. nb == {nb}.\n"); 
        //     }, 4);

        //     // Anonymous methods can be used as event handlers:
        //     // Button saveButton = new();

        //     // saveButton.Click += delegate(Object o, EventArgs e)
        //     // { 
        //     //     System.Windows.Forms.MessageBox.Show("Save Successfully!"); 
        //     // };

        //     // using System.Windows.Forms doesn't work

        //     /*
        //         C# 3.0 (2008) introduced the lambda expression which also works like an 
        //         anonymous method.
        //     */

        //     /*
        //         ANONYMOUS METHOD LIMITATIONS

        //         It cannot contain jump statement like goto, break or continue.
        //         It cannot access ref or out parameter of an outer method.
        //         It cannot have or access unsafe code.
        //         It cannot be used on the left side of the is operator.
        //     */

        //     /*
        //         Points to Remember :

        //         1. Anonymous method can be defined using the delegate keyword.
        //         2. Anonymous method must be assigned to a delegate.
        //         3. Anonymous method can access outer variables or functions.
        //         4. Anonymous method can be passed as a parameter.
        //         5. Anonymous method can be used as event handlers.
        //     */
        // }

        public static void PrintHelperMethod(Print printDel, int val)
        { 
            val += 10;
            printDel(val);
        }

        public delegate void Print(int nb);
    }
}