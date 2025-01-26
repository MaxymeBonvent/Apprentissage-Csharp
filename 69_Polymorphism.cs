// 69. POLYMORPHISM

namespace Lesson69
{
    class Program69
    {
        // public static void Main()
        // {
        //     /*
        //         Polymorphism is a Greek word that means multiple forms or shapes. You can use 
        //         polymorphism if you want to have multiple forms of one or more methods of a 
        //         class with the same name.

        //         In C#, polymorphism can be achieved in two ways:

        //         1.Compile-time Polymorphism
        //         2.Run-time Polymorphism
        //     */

        //     /*
        //         COMPILE-TIME POLYMORPHISM (METHOD OVERLOADING)

        //         Compile-time polymorphism is also known as method overloading. C# allows us 
        //         to define more than one method with the same name but with different 
        //         signatures. This is called method overloading.

        //         Method overloading is also known as early binding or static binding because 
        //         which method to call is decided at compile time, early than the runtime.

        //         Rules for Method Overloading:

        //         1. Method names should be the same but method signatures must be different. 
        //         Either the number of parameters, type of parameters, or order of parameters 
        //         must be different.

        //         2. The return type of the methods does not play any role in the method 
        //         overloading.

        //         3. Optional Parameters take precedence over implicit type conversion when 
        //         deciding which method definition to bind.

        //         The following example (ConsolePrinter) demonstrates the method overloading by defining 
        //         multiple Print() methods with a different number of parameters of the 
        //         same type.
        //     */

        //     /*
        //         The following example (ConsolePrinterB) demonstrates polymorphism using the same number of 
        //         parameters with different types.
        //     */

        //     /*
        //         The following example (ConsolePrinterC) demonstrates polymorphism using the same number of 
        //         parameters with different sequences.
        //     */

        //     /*
        //         Please note that return type of methods is not considered. 
        //         The following (ConsolePrinterD) will give a compile-time error.
        //     */

        //     /*
        //         The following methods (ConsolePrinterE) overloaded with different types, sequence, and number 
        //         of parameters.
        //     */

        //     /*
        //         INVOKING OVERLOADED METHODS

        //         We can call the overloaded method by passing the exact parameter it requires. 
        //         For example, if we want to invoke the print(string str) method that displays 
        //         a string value, we will pass only one argument of string type. Likewise, if 
        //         we want to invoke the Print(int a, string str) method, we will pass int and 
        //         string type argument.
        //     */

        //     ConsolePrinter cp = new();

	    //     cp.Print("Hello World!");
	    //     cp.Print(1, "John");

        //     /*
        //         Thus, polymorphism using method overloading plays important role in designing 
        //         an application. The simplest example in .NET API is the overloads of 
        //         Console.WriteLine() methods.
        //     */
        // }

        class ConsolePrinterE
        {
            public static void Print(string str)
            { 
                Console.WriteLine(str);
            }

            public static void Print(string str1, string str2)
            { 
                Console.WriteLine($"{str1}, {str2}");
            }

            public static void Print(string str1, string str2, string str3)
            { 
                Console.WriteLine($"{str1}, {str2}, {str3}");
            }
            
            public static void Print(int nb)
            { 
                Console.WriteLine($"Integer {nb}");
            }
            
            public static void Print(int nb, string str)
            { 
                Console.WriteLine($"{nb}, {str}");
            }

            public static void Print(string str, int nb)
            { 
                Console.WriteLine($"{nb}, {str}");
            }
        }

        class ConsolePrinterD
        {
            public static void Print(int nb, string str)
            { 
                Console.WriteLine($"{nb}, {str}");
            }


            /*
                public static int Print(int nb, string str)
                { 
                    Console.WriteLine($"{nb}, {str}");
                    return 0;
                }

                Compile Error CS0111:
                ConsolePrinterD already defines a member called 'Print' with the same 
                parameter types.

                Changing the return type does not create an overload.
            */
             
        }

        class ConsolePrinterC
        {
            public static void Print(int nb, string str)
            { 
                Console.WriteLine($"{nb}, {str}");
            }

            public static void Print(string str, int nb)
            {

                Console.WriteLine($"{nb}, {str}");
            }
        }

        class ConsolePrinterB
        {
            public static void Print(string str)
            { 
                Console.WriteLine(str);
            }

            public static void Print(int nb)
            { 
                Console.WriteLine($"Integer {nb}.");
            }
        }

        class ConsolePrinter
        {
            public void Print(string str)
            { 
                Console.WriteLine(str);
            }

            public void Print(int nb, string str)
            { 
                Console.WriteLine($"{nb}, {str}");
            }

            public void Print(string str1, string str2)
            { 
                Console.WriteLine($"{str1}, {str2}");
            }

            public void Print(string str1, string str2, string str3)
            { 
                Console.WriteLine($"{str1}, {str2}, {str3}");
            }
        }
    }
}