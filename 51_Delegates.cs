// 51. DELEGATES

namespace Lesson51
{
    class Program51
    {
        // public static void Main()
        // {
        //     /*
        //         What if we want to pass a function as a parameter? How does C# handles the 
        //         callback functions or event handler? The answer is delegate.

        //         The delegate is a reference type data type that defines the method signature. 
        //         You can define variables of delegate, just like other data type, that can 
        //         refer to any method with the same signature as the delegate.

        //         There are three steps involved while working with delegates:

        //         1. Declare a delegate
        //         2. Create an instance and reference a method
        //         3. Invoke a delegate

        //         A delegate can be declared using the "delegate" keyword followed by a 
        //         function signature, as shown below.


        //         Delegate Syntax:
        //         [access modifier] delegate [return type] [delegate name]([parameters])

        //         The following declares a delegate named MyDelegate.
        //     */

        //     /*
        //         Below, we have declared a delegate MyDelegate with a void return type and a 
        //         string parameter. A delegate can be declared outside of the class or inside 
        //         the class. In practice, it should be declared out of the class.

        //         After declaring a delegate, we need to set the tarFget method or a lambda 
        //         expression (anonymous function). We can do it by creating an object of the 
        //         delegate using the "new" keyword and passing a method whose signature matches
        //         the delegate signature.
        //     */

        //     // Set target method
        //     MyDelegate del = new (MethodA);

        //     // Or 
        //     MyDelegate delA = MethodA;

        //     // Or set lambda expression 
        //     MyDelegate delB = (string msg) =>  Console.WriteLine(msg);

        //     /*
        //         You can set the target method by assigning a method directly without creating 
        //         an object of delegate e.g., MyDelegate del = MethodA.

        //         After setting a target method, a delegate can be invoked using the Invoke() 
        //         method or using the () operator.
        //     */

        //     del.Invoke("del's MethodA called with Invoke().");
        //     del("del's MethodA called without Invoke().\n");

        //     // The following is a full example of a delegate.
        //     MyDelegate delphine = ClassA.MethodA;
        //     delphine("Delphine");

        //     MyDelegate delfino = ClassB.MethodB;
        //     delfino("Delfino");

        //     MyDelegate dellarte = (string msg) => Console.WriteLine($"Called lambda expression: {msg}.");
        //     dellarte("Dellarte");

        //     Console.WriteLine("\n");

        //     /*
        //         PASSING DELEGATE AS A PARAMETER

        //         A method can have a parameter of the delegate type, as shown below.
        //     */

        //     MyDelegate delphox = ClassA.MethodA;
        //     InvokeDelegate(delphox);
        //     delphox("Delphox\n");

        //     MyDelegate delusion = ClassB.MethodB;
        //     InvokeDelegate(delusion);
        //     delusion("Grandeur\n");

        //     MyDelegate delirium = (string msg) => Console.WriteLine($"Called lambda expression: {msg}");
        //     InvokeDelegate(delirium);
        //     delirium("Funny gas\n");

        //     /*
        //         In .NET, Func and Action types are built-in generic delegates that should be 
        //         used for most common delegates instead of creating new custom delegates.
        //     */

        //     /*
        //         MULTICAST DELEGATE

        //         The delegate can point to multiple methods. 
        //         A delegate that points multiple methods is called a multicast delegate. 
        //         The "+" or "+=" operator adds a function to the invocation list, and the 
        //         "-" and "-=" operator removes it.
        //     */

        //     MyDelegate? delano = ClassA.MethodA;
        //     MyDelegate? delta = ClassB.MethodB;

        //     MyDelegate? deltano = delta + delano;
        //     deltano("Deltano");

        //     MyDelegate? deliveroo = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        //     deliveroo += deltano;
        //     deliveroo("Deliveroo + Deltano");

        //     deltano -= delta;
        //     deliveroo("Deliveroo - Delta");

        //     deliveroo -= delano;
            
        //     if(deliveroo != null)
        //     {
        //         deliveroo("Deliveroo - Deltano");
        //     }

        //     else
        //     {
        //         Console.WriteLine("Deliveroo - Deltano is null.");
        //     }

        //     /*
        //         The addition and subtraction operators always work as part of the assignment: 
        //         del1 += del2; is exactly equivalent to del1 = del1+del2; and likewise for 
        //         subtraction.

        //         If a delegate returns a value, then the last assigned target method's value 
        //         will be return when a multicast delegate called.
        //     */

        //     MyDelegate del1 = ClassA.MethodA;
        //     MyDelegate del2 = ClassB.MethodB;

        //     MyDelegate del3 = del1 + del2; 
        //     Console.WriteLine($"Value of del3 == {del3}.\n");

        //     /*
        //         GENERIC DELEGATE

        //         A generic delegate can be defined the same way as a delegate but using 
        //         generic type parameters or return type. 
        //         The generic type must be specified when you set a target method.

        //         For example, consider the following generic delegate that is used for int and 
        //         string parameters.
        //     */

        //     Add<int> sum = Sum;
        //     Console.WriteLine($"sum(10, 20) == {sum(10, 20)}.");

        //     Add<string> con = Concat;
        //     Console.WriteLine($"con(\"Hello \",\"World.\") == {con("Hello ","World.")}");

        //     // Delegates are also used to declare events and anonymous methods.

        //     /*
        //         Points to Remember :

        //         1. Delegate is the reference type data type that defines the signature.

        //         2. Delegate type variables can refer to any method with the same signature 
        //          as the delegate.

        //         3. Syntax: 
        //         [access modifier] delegate [return type] [delegate name]([parameters])

        //         4. A target method's signature must match with delegate signature.

        //         5. Delegates can be invoked like a normal function or the Invoke() method.

        //         6. Multiple methods can be assigned to the delegate using "+" or "+=" 
        //         operator and removed using "-" or "-=" operator. 
        //         It is called multicast delegate.

        //         7. If a multicast delegate returns a value then it returns the value from 
        //          the last assigned target method.

        //         8. Delegates are used to declare events and anonymous methods in C#.
        //     */
        // }

        // Generic delegate
        public delegate T Add<T>(T param1, T param2);

        // Static methods
        public static int Sum(int nb1, int nb2)
        {
            return nb1 + nb2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }

        // Class C
        class ClassC
        {
            // Method C
            static int MethodC()
            {
                Console.WriteLine("100");
                return 100;
            }
        }

        // Class D
        class ClassD
        {
            // MethodD
            static int MethodD()
            {
                Console.WriteLine("200");
                return 200;
            }
        }

        // Method with a delegate as a parameter
        static void InvokeDelegate(MyDelegate del)
        {
            del("Hello World");
        }

        // Target Class A
        class ClassA
        {
            // Target Method A
            public static void MethodA(string msg)
            {
                Console.WriteLine($"Called ClassA.MethodA() with parameter: {msg}.");
            }
        }

        // Target Class B
        class ClassB
        {
            // Target Method B
            public static void MethodB(string msg)
            {
                Console.WriteLine($"Called ClassB.MethodB() with parameter: {msg}.\n");
            }
        }

        // Target method of del and delA
        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }

        // Delegates must be defined outside of Main()
        public delegate void MyDelegate(string msg);
    }
}