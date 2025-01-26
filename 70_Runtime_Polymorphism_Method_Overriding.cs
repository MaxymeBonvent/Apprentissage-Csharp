// 70. RUNTIME POLYMORPHISM: METHOD OVERRIDING

namespace Lesson70
{
    class Program70
    {
        // public static void Main()
        // {
        //     /*
        //         Runtime polymorphism is also known as inheritance-based polymorphism or 
        //         method overriding.

        //         Inheritance allows you to inherit a base class into a derived class and all 
        //         the public members of the base class automatically become members of the 
        //         derived class. However, you can redefine the base class's member in the 
        //         derived class to provide a different implementation than the base class. 
        //         This is called method overriding that also known as runtime polymorphism.

        //         In C#, by default, all the members of a class are sealed and cannot be 
        //         redefined in the derived class. Use the virtual keyword with a member of the 
        //         base class to make it overridable, and use the override keyword in the 
        //         derived class to indicate that this member of the base class is being 
        //         redefined in the derived class.
        //     */

        //     /*
        //         As you can see, Greet() method in the Person class is defined with the 
        //         virtual keyword. It means this method can be overridden in the derived class 
        //         using the override keyword. In the Employee class, the Greet() method is 
        //         redefined with the override keyword. Thus, the derived class extends the base 
        //         class's method.

        //         Now, the question is which method will be called, the base class's method or 
        //         the derived class method? Well, it depends on the type of object. Can you 
        //         guess the output of the following program?
        //     */

        //     Person p1 = new();
        //     p1.Greet();

        //     // Variable myVar = new Object();
        //     Person p2 = new Employee();
        //     p2.Greet();
        //     // Says "I'm an employee."

        //     Employee emp = new();
        //     emp.Greet();

        //     Console.WriteLine("\n");

        //     /*
        //         C# will call the method depending on the type of the object not the type of 
        //         the variable. If you create an object of the Person class then it will call 
        //         the Greet() method of the Person class and if you create an object of the 
        //         Employee class then it will call the Greet() method of the Employee class no 
        //         matter to which type of variable it assigned to.

        //         As you learned in the previous chapter the C# compiler decides which methods 
        //         to call at the compile time in the compile-time polymorphism. In the run time 
        //         polymorphism, it will be decided at run time depending upon the type of an 
        //         object.

        //         To understand why method overriding is called the runtime polymorphism, look 
        //         at the following example.
        //     */

        //     Person p3 = new ();
        //     Display(p3);
                
        //     Person p4 = new Employee();
        //     Display(p4);
                
        //     Employee emp2 = new();
        //     Display(emp2);

        //     Console.WriteLine("\n");

        //     /*
        //         In the above example, the Display() method takes a parameter of the Person 
        //         type. Thus, you can pass an object of the Person type or the Employee type 
        //         when you call the Display() method. The Display() method does not know the 
        //         type of parameter you passed at compile time. It can be anything at runtime. 
        //         That's why method overriding is called run-time polymorphism.
        //     */

        //     /*
        //         RULES FOR OVERRIDING

        //         A method, property, indexer, or event can be overridden in the derived class.

        //         Static methods cannot be overridden.

        //         Must use virtual keyword in the base class methods to indicate that the 
        //         methods can be overridden.

        //         Must use the override keyword in the derived class to override the base class 
        //         method.
        //     */
        // }

        public static void Display(Person p)
        {
            p.Greet();
        }

        public class Person
        {
            public virtual void Greet()
            {
                Console.WriteLine("Hi! I am a person.");
            }
        }

        public class Employee : Person
        {
            public override void Greet()
            {
                Console.WriteLine("Hello! I am an employee.");
            }
        }
    }
}