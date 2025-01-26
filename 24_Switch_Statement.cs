// 24. SWITCH STATEMENT

namespace Lesson24
{
    class Program24
    {
        // public static void Main()
        // {
        //     /*
        //        The switch statement can be used instead of if else statement when you want to 
        //        test a variable against three or more conditions. Here, you will learn about 
        //        the switch statement and how to use it efficiently in the C# program.

        //         The following is the general syntax of the switch statement :

        //         switch(match expression/variable)
        //         {
        //             case constant-value:
        //                 statement(s) to be executed;
        //                 break;
                        
        //             default: 
        //                 statement(s) to be executed;
        //                 break;
        //         }
        //     */

        //     /*
        //         The switch statement starts with the switch keyword that contains a match 
        //         expression or a variable in the bracket switch(match expression). 
        //         The result of this match expression or a variable will be tested against 
        //         conditions specified as cases, inside the curly braces. 

        //         A case must be specified with the unique constant value and ends with the
        //         colon :. Each case includes one or more statements to be executed. 
        //         The case will be executed if a constant value and the value of a match 
        //         expression/variable are equal. 
                
        //         The switch statement can also contain an optional default label. 
        //         The default label will be executed if no cases executed. 
        //         The break, return, or goto keyword is used to exit the program control from a 
        //         switch case.

        //         The following example demonstrates a simple switch statement :
        //     */

        //     int a = 10;

        //     switch (a)
        //     { 
        //         case 5:
        //             Console.WriteLine("Value of a is 5.");
        //             break;

        //         case 10:
        //             Console.WriteLine("Value of a is 10.");
        //             break;

        //         case 15:
        //             Console.WriteLine("Value of a is 15.");
        //             break;

        //         default:
        //             Console.WriteLine("a's value is unknown.");
        //             break;
        //     }

        //     /*
        //         Above, the switch(a) statement includes a variable "a" whose value will be 
        //         matched with the value of each case value. 
        //         The above switch statement contains three cases with constant values 5, 10, 
        //         and 15. 
                
        //         It also contains the default label, which will be executed if none of
        //         the case value match with the switch variable/expression. Each case starts 
        //         after : and includes one statement to be executed. The value of "a" matches 
        //         with the second case case 10:, so the output would be "Value of a is 10".

        //         Switch statements can include any non-null expression that returns a value 
        //         of type char, string, bool, int, or enum.

        //         The switch statement can also include an expression which result will be 
        //         tested against each case at runtime.
        //     */

        //     int b = 125;

        //     switch (b % 2)
        //     { 
        //         case 0:
        //             Console.WriteLine($"{b} is an even number.");
        //             break;

        //         case 1:
        //             Console.WriteLine($"{b} is an odd number.");
        //             break;
        //     }

        //     /*
        //         SWITCH CASE

        //         Switch cases must be unique constant values. 
        //         They can be bool, char, string, integer, enum, or corresponding nullable types.

        //         From C# 7.0 (2017) onward, switch cases can include non-unique values. 
        //         In this case, the first matching case will be executed.

        //         Consider the following example of a switch statement :
        //     */

        //     string statement = "switch";

        //     switch (statement)
        //     {
        //         case "if.else":
        //             Console.WriteLine("if...else statement.");
        //             break;

        //         case "ternary":
        //             Console.WriteLine("Ternary operator.");
        //             break;
                    
        //         case "switch":
        //             Console.WriteLine("switch statement.");
        //             break;
        //     }

        //     // Multiple cases can be combined to execute the same statements.

        //     int c = 5;

        //     switch (c)
        //     { 
        //         case 1:
        //             Console.WriteLine("c = 1.");
        //             break;

        //         case 2:
        //             Console.WriteLine("c = 2.");
        //             break;

        //         case 4:
        //         case 5:
        //             Console.WriteLine("c = 4 or c = 5.");
        //             break;
                    
        //         default:
        //             Console.WriteLine("c > 5.");
        //             break;
        //     }

        //     /*
        //         Each case must exit the switch statement explicitly by using break, return, 
        //         goto keyword, or some other way, making sure the program control exits a case 
        //         and cannot fall through to the default case.

        //         The following use the return keyword :
        //     */

        //     int d = 125;
        //     Console.WriteLine(IsOdd(d)? $"{d} is an even number." : $"{d} is an odd number.");

        //     /*
        //         Switch cases without break, return, or goto statement or with the same 
        //         constant values would give a compile-time error.
        //     */

        //     // int e = 1;

        //     // switch (e)
        //     // { 
        //     //     case 0:
        //     //         Console.WriteLine($"{e} is even number.");
        //     //         break;

        //     //     case 1:
        //     //         Console.WriteLine($"{e} is odd number.");
        //     //         break;

        //     //     case 2:
        //     //         Console.WriteLine($"{e} is odd number.");
        //     //         default: 
        //     //         /*
        //     //             Compiler Error CS0163 : Control cannot fall through from one case 
        //     //             label ('label') to another.
        //     //         */

        //     //         Console.WriteLine($"{e} is odd number.");
        //     //         break;
        //     // }

        //     /*
        //         NESTED SWITCH STATEMENTS

        //         A switch statement can be used inside another switch statement.
        //     */

        //     int f = 5;

        //     switch (f)
        //     {
        //         case 5:
        //             Console.WriteLine("f = 5.");

        //             switch (f - 1)
        //             {
        //                 case 4:
        //                 Console.WriteLine("f = 4.");
                        
        //                 switch (f - 2)
        //                 {
        //                     case 3:
        //                     Console.WriteLine("f = 3.");
        //                     break;
        //                 }
        //                 break;
        //             }
        //             break;

        //         case 10:
        //             Console.WriteLine("f = 10.");
        //             break;

        //         case 15:
        //             Console.WriteLine("f = 15.");
        //             break;

        //         default:
        //             Console.WriteLine("f = 100.");
        //             break;
        //     }
        // }

        public static bool IsOdd(int i)
        {
            switch (i % 2)
            { 
                case 0:
                    return true;

                case 1:
                    return false;

                default:
                    return false;
            }
        }
    }
}