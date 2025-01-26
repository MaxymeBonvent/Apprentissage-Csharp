// 71. METHOD HIDING

namespace Lesson71
{
    class Program71
    {
        // public static void Main()
        // {
        //     /*
        //         In the previous chapter, you learned about method overriding using the 
        //         "virtual" and "override" keywords. Here you will learn what will happen if we 
        //         don't use these keywords and still redefine the base class's methods in the 
        //         derived class?

        //         Look at the following example.
        //     */

        //     Console.WriteLine("A");

        //     PersonA p1 = new();
        //     p1.Greet(); 
                
        //     PersonA p2 = new EmployeeA();
        //     p2.Greet();

        //     EmployeeA emp = new();
        //     emp.Greet();

        //     Console.WriteLine("\n");

        //     /*
        //         As you can see, the calling of the Greet() method does not depend on the type 
        //         of object. Here, EmployeeA.Greet() hides the base class method PersonA.Greet(). 
        //         This is called method hiding (of base class) in C#.
        //     */

        //     /*
        //         METHOD HIDING USING "NEW" KEYWORD

        //         Use the "new" keyword in the derived class to hide the base class method. 
        //         This will be useful when you are reusing third-party APIs where you don't 
        //         have control over the base class.

        //         The "new" keyword will not give the above warning. The following will give the 
        //         same result but will not give any warning at compile time.
        //     */

        //     Console.WriteLine("B");

        //     PersonB perB = new();
        //     perB.Greet();

        //     PersonB perB2 = new EmployeeB();
        //     perB2.Greet();

        //     EmployeeB empB = new();
        //     empB.Greet();

        //     Console.WriteLine("\n");

        //     Console.WriteLine("C");

        //     /*
        //         By using the new keyword with the derived class method, C# treats it as a new 
        //         method of the derived class and hides the base class method. The 
        //         Employee.Greet() will be treated as a new method.

        //         The new keyword preserves the relationships that produce that output, but it 
        //         suppresses the warning. The variables of type base class continue to access 
        //         the members of the base class, and the variable of type derived class 
        //         continues to access members in the derived class first, and then consider 
        //         members inherited from the base class.
        //     */
        // }

        class PersonB
        {
            public void Greet()
            {
                Console.WriteLine("I am a person.");
            }
        }

        class EmployeeB : PersonB
        {
            public new void Greet()
            {
                Console.WriteLine("I am an employee.");
            }
        }

        class PersonA
        {
            public void Greet()
            {
                Console.WriteLine("Hi! I am a person.");
            }
        }

        class EmployeeA : PersonA
        {
            /*
                Compiler Warning CS0108:
                'EmployeeA.Greet()' hides inherited member 'PersonA.Greet()'. 
                Use the "new" keyword if hiding was intended.

            */
            
            // public void Greet()
            // {
            //     Console.WriteLine("Hello! I am an employee.");
            // }
        }
    }
}