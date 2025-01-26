// 68. INHERITANCE

namespace Lesson68
{
    class Program68
    {
        // public static void Main()
        // {
        //     /*
        //         In object-oriented programming, inheritance is another type of relationship 
        //         between classes. Inheritance is a mechanism of reusing the functionalities of 
        //         one class into another related class.

        //         Inheritance is referred to as "is a" relationship. In the real world example, 
        //         a customer is a person. In the same way, a student is a person and an
        //         employee is also a person. They all have some common things, for example, 
        //         they all have a first name, middle name, and last name. So to translate this 
        //         into object-oriented programming, we can create the Person class with first 
        //         name, middle name, and last name properties and inherit the Customer, 
        //         Student, and Employee classes from the Person class. That way we don't need 
        //         to create the same properties in all classes and avoid the violation of the 
        //         DRY (Do not Repeat Yourself) principle.

        //         Note that the inheritance can only be used with related classes where they 
        //         should have some common behaviors and perfectly substitutable. Follow the 
        //         Liskov Substitution Principle in inheritance. 
        //     */

        //     /*
        //         In C#, use the ":" symbol to inherit a class from another class. For example, 
        //         the following Employee class inherits from the Person class in C#.
        //     */

        //     /*
        //         In the above example, the Person class is called the base class or the parent class, and 
        //         the Employee class is called the derived class or the child class.

        //         The Employee class inherits from the Person class and so it automatically 
        //         acquires all the public members of the Person class. It means even if the 
        //         Employee class does not include FirstName, LastName properties and 
        //         GetFullName() method, an object of the Employee class will have all the 
        //         properties and methods of the Person class along with its own members.
        //     */

        //     Employee emp = new()
        //     {
        //         // Fields of the base Person class
        //         FirstName = "Matt",
        //         LastName = "Weyard",

        //         // Fields of the derived Employee class
        //         EmployeeId = 12,
        //         CompanyName = "Mystics"
        //     };

        //     string? fullname = emp.GetFullName();
        //     Console.WriteLine($"Employee's full name == {fullname}.\n");

        //     /*
        //         Note that C# does not allow a class to inherit multiple classes. 
        //         A class can only achieve multiple inheritances through interfaces.
        //     */

        //     /*
        //         ROLE OF ACCESS MODIFIERS IN INHERITANCE

        //         Access modifiers play an important role in inheritance. Access modifiers of 
        //         each member in the base class impact their accessibility in the derived class.

        //         PUBLIC MEMBERS

        //         Public members of the base class are accessible in the derived class and 
        //         also become part of the derived class object.
        //     */

        //     EmployeeB empB = new();

        //     empB.FirstName = "Kiara";
        //     Console.WriteLine($"empB.FirstName == {empB.FirstName}.\n");

        //     /*
        //         PRIVATE MEMBERS

        //         Private members of the base class cannot be accessed directly from the 
        //         derived class and cannot be part of the derived class object.
        //     */

        //     EmployeeC empC = new();

        //     /*
        //         empC.FirstName = "Terry";

        //         Compile Error CS0122 :
        //         'FirstName' is inaccessible due to its protection level
        //     */
            

        //     /*
        //         PROTECTED MEMBERS

        //         Protected members of the base class can be accessible in the derived class 
        //         but cannot be a part of the derived class object.
        //     */

        //     EmployeeD empD = new();

        //     empD.GiveAndShowName();

        //     /*
        //         INTERNAL MEMBERS

        //         Internal members are accessible in the derived class and are part of the 
        //         derived class object.
        //     */

        //     EmployeeE empE = new();

        //     empE.FirstName = "Haru";
        //     Console.WriteLine($"empE.FirstName == {empE.FirstName}.\n");

        //     /*
        //         CONSTRUCTORS

        //         Creating an object of the derived class will first call the constructor of 
        //         the base class and then the derived class. If there are multiple levels of 
        //         inheritance then the constructor of the first base class will be called and 
        //         then the second base class and so on.
        //     */

        //     EmployeeF empF = new();

        //     /*
        //         Use the "base" keyword in the derived class to access the public members of the 
        //         base class. For example, the following calls the base class's parameterized 
        //         constructor using the ":base()".
        //     */

        //     EmployeeG empG = new();

        //     /*
        //         OBJECT INITIALIZATION

        //         You can create an instance of the derived class and assign it to a variable 
        //         of the base class or derived class. The instance's properties and methods are 
        //         depending on the type of variable it is assigned to. Here, a type can be a 
        //         class or an interface, or an abstract class.

        //         The following table list supported members based on a variable type and 
        //         instance type.
        //     */

        //     /*
        //         Instance variable   Instance Type	Instance Members of
        //         Base type	        Base type	     Base type
        //         Base type	        Derived type	 Base type
        //         Derived type	    Derived type	 Base and derived type
        //     */

        //     /*
        //         The following program demonstrates supported members based on the variable 
        //         type:
        //     */

        //     PersonH per1 = new()
        //     {
        //         // Fields of the PersonH base class
        //         Id = 2,
        //         FirstName = "Fizzle",
        //         LastName = "Crowson",

        //         // Fields of the EmployeeH derived class
        //         /*
        //             CompanyName = "Cheese!"
        //             Salary = 1000

        //             Compile Error CS0117:
        //             'PersonH' does not contain a definition for 'CompanyName'
        //         */
        //     };

        //     Console.WriteLine($"Type of per1 == {per1.GetType()}.");

        //     PersonH per2 = new EmployeeH() 
        //     {
        //         // Fields of the PersonH base class
        //         Id = 2,
        //         FirstName = "Dave",
        //         LastName = "Foxden",

        //         // Fields of the EmployeeH derived class
        //         CompanyName = "Safe coops",
        //         Salary = 1000
        //     };

        //     Console.WriteLine($"Type of per2 == {per2.GetType()}.");

        //     EmployeeH empH = new() 
        //     {
        //         // Fields of the PersonH base class
        //         Id = 2,
        //         FirstName = "Dave",
        //         LastName = "Foxden",

        //         // Fields of the EmployeeH derived class
        //         CompanyName = "Safe coops",
        //         Salary = 1000
        //     };

        //     Console.WriteLine($"Type of empH == {empH.GetType()}.\n");

        //     /*
        //         EmployeeH empH2 = new PersonH();

        //         Compile Error CS0266 :
        //         Cannot implicitly convert type 'PersonH' to 'EmployeeH'. 
        //         An explicit conversion exists (are you missing a cast?)
        //     */

        //     /*
        //         In the above example, the type of per2 is Person, so it will only expose 
        //         public properties of the Person type even if an object type is the Employee. 
        //         However, the type of emp is Employee and so it exposes all the public 
        //         properties of both classes. Note that the base type object cannot be assigned 
        //         to the derived type variable.
        //     */

        //     /*
        //         TYPE CONVERSION

        //         The base type converts to the base class implicitly whereas the derived type 
        //         must be converted to the base class explicitly using the "as" operator.
        //     */

        //     PersonH personH = new EmployeeH()
        //     {
        //         FirstName = "Inezia",
        //         LastName = "Elec"
        //     };

        //     /*
        //         ShowFullName(personH);

        //         Compile Error CS1503 :
        //         Argument 'number' cannot implicitly convert from PersonH to EmployeeH.
        //     */

        //     // Valid, explicit conversion with "as"
        //     ShowFullName(personH as EmployeeH);

        //     EmployeeH employeeH = new()
        //     {
        //         // Fields of the base class PersonH
        //         FirstName = "Piers",
        //         LastName = "Sombertone",

        //         // Fields of the derivedclass EmployeeH
        //         CompanyName = "Punks Of Spikemuth",
        //         Salary = 1200
        //     };

        //     ShowFullName(employeeH);

        //     /*
        //         TYPES OF INHERITANCE

        //         There are different types of inheritance supported in C# based on how the 
        //         classes are inherited.

        //         SINGLE INHERITANCE

        //         In a single inheritance, only one derived class inherits a single base class.

        //         Base Class A<---Derived ClassB

        //         MULTI-LEVEL INHERITANCE

        //         In multi-level inheritance, a derived class inherits from a base class and 
        //         then the same derived class becomes a base class for another derived class. 
        //         In practice, there are no limits on the level of inheritance, but you should 
        //         avoid it.

        //         Base Class A<---Derived ClassB<---Derived ClassC

        //         HIERARCHICAL INHERITANCE

        //         In a hierarchical inheritance, multiple derived classes inherit from a single 
        //         base class.
        //                         -- Derived ClassB
        //                         |
        //         Base Class A<---
        //                         |
        //                         -- Derived ClassC

        //         HYBRID INHERITANCE

        //         Hybrid inheritance is a combination of multi-level and hierarchical 
        //         inheritance.

        //                                             ---Derived Class C
        //                                            |
        //         Base Class A<---Derived Class B<---
        //                                            |
        //                                            ---Derived Class D

        //         MULTIPLE INHERITANCE

        //         In multiple inheritance, a class inherits from multiple interfaces. Note that 
        //         C# does not support deriving multiple base classes. Use interfaces for 
        //         multiple inheritance.

        //         Interface 1<---
        //                        |--- Inheriting Class A
        //         Interface 2<---
        //     */

        //     /*
        //         IMPORTANT POINTS

        //         In C#, three types can participate in inheritance: Class, Struct, and 
        //         Interface.

        //         A class can inherit a single class only. It cannot inherit from multiple 
        //         classes.

        //         A class cannot inherit from a struct.

        //         A class can inherit (implement) one or more interfaces.

        //         A Struct can inherit from one or more interfaces. However, it cannot inherit 
        //         from another struct or class.

        //         An interface can inherit from one or more interfaces but cannot inherit from 
        //         a class or a struct.

        //         Constructors or destructors cannot be inherited.
        //     */
        // }

        public static void ShowFullName(EmployeeH? empH)
        {
            if(empH != null)
            {
                Console.WriteLine($"Full name: {empH.FirstName} {empH.LastName}.");
            }
        }

        public class PersonH
        {
            public int Id {get; set;}  
            public string? FirstName {get; set;} 
            public string? LastName {get; set;} 
        }

        public class EmployeeH : PersonH
        {
            public string? CompanyName {get; set;}
            public decimal Salary {get; set;}
        }

        class PersonG
        {
            public PersonG()
            {
                Console.WriteLine("PersonG Constructor.");
            }

            public PersonG(string txt)
            {
                Console.WriteLine(txt);
            }
        }

        class EmployeeG : PersonG
        {
            public EmployeeG() : base("Parameterized constructor of base class PersonG.")
            {
                Console.WriteLine("EmployeeG Constructor.\n");
            }   
        }

        class PersonF
        {
            public PersonF()
            {
                Console.WriteLine("PersonF Constructor.");
            }
        }

        class EmployeeF : PersonF
        {
            public EmployeeF()
            {
                Console.WriteLine("EmployeeF Constructor.\n");
            }   
        }

        class PersonE
        {
            internal string? FirstName {get; set;} 
        }

        class EmployeeE : PersonE
        {
                
        }

        class PersonD
        {
            protected string? FirstName {get; set;}
        }

        class EmployeeD : PersonD
        {
            /*
                FirstName = "Robin";

                Compile Error CS1519 :
                Invalid token '=' in class, struct, or interface member declaration.
            */

            // Method to give a name to an employee and then show it
            public string? GiveAndShowName()
            {
                FirstName = "Robin";
                Console.WriteLine($"First name: {FirstName}.\n");
                return FirstName;
            }
        }

        class PersonC
        {
            // Cannot be inherited because the acces modifier is "private"
            private string? FirstName {get; set;} 
        }

        class EmployeeC : PersonC
        {
        
        }

        class PersonB
        {
            // Can be inherited because the access modifier is "public"
            public string? FirstName {get; set;} 
        }

        class EmployeeB : PersonB
        {
                
        }

        class Person
        {
            public string? FirstName {get; set;}
            public string? LastName {get; set;}

            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }

        class Employee : Person
        {
            public int EmployeeId {get; set;}
            public string? CompanyName {get; set;}
        }
    }
}