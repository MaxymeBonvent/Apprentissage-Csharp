// 5. CLASS AND OBJECTS

/*
A class is like a blueprint of a specific object that has certain attributes and features. 
For example, a car should have some attributes such as four wheels, two or more doors, 
steering, a windshield, etc. It should also have some functionalities like start, stop, run, 
move, etc. Now, any object that has these attributes and functionalities is a car. Here, the 
car is a class that defines some specific attributes and functionalities. Each individual car 
is an object of the car class. You can say that the car you are having is an object of the 
car class.

Likewise, in object-oriented programming, a class defines some properties, fields, events, 
methods, etc. A class defines the kinds of data and the functionality their objects will have.
*/

/*
DEFINE A CLASS2

In C#, a class can be defined by using the class keyword. 
Let's define a class named "Student".
*/

class Student
{

}

/*
A class can contain one or more constructors, fields, methods, properties, delegates, and 
events. They are called class members. A class and its members can have access modifiers such 
as public, private, protected, and internal, to restrict access from other parts of the 
program.

Let's add different members to the Student class.
*/

/*
FIELD

A class can have one or more fields. It is a class-level variable that holds a value. 
Generally, field members should have a private access modifier used with property.
*/

class Student2
{
    public int ID = 1;
}

/*
PROPERTY

A property encapsulates a private field using setters and getters to assign and retrieve 
underlying field values.
*/

class Student3
{
    private int ID;

    public int StudentID
    {
        get {return ID;}
        set {ID = value;}
    }
}

/*
In the above example, ID is a private field that cannot be accessed directly. 
It will only be accessed using the StudentId property. The "get" returns the value of the 
underlying field and "set" assigns the value to the ID.

You can also apply some additional logic in get and set, as in the below example.
*/

class Student4
{
    private int ID;

    public int StudentID
    {
        get {return ID;}

        set 
        {
            if(value > 0)
            {
                ID = value;
            }
        }
    }
}

/*
AUTO-IMPLEMENTED PROPERTY

From C# 3.0 onwards, property declaration has been made easy if you don't want to apply some 
logic in getters or setters. Using auto-implemented property, you don't need to declare an 
underlying private field. The C# compiler will automatically create it 
in IL (Intermediate Language) code.
*/

class Student5
{
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
}

/*
In the above example, backing private fields for the FirstName and LastName will be created 
internally by the compiler. This speeds up the development time and code readability.
*/

/*
METHOD


A method can contain one or more statements to be executed as a single unit. 
It may or may not return a value and can have one or more input parameters.

Syntax :

[access_modifier] return_type MethodName(type parameterName1, type parameterName2, etc.)
{
    
}
*/

// The following defines the Sum method that returns the sum of two numbers.

class SummationC
{
    public static int Sum(int num1, int num2)
    {
        var total = num1 + num2;
        return total;
    }
}

/*
The following method doesn't return anything and doesn't have any parameters, its return type 
is void.
*/


class Greetings
{
    public static void Greet()
    {
        Console.Write("Hello World!");
    }
}

// The following defines the GetFullName() method in the Student class.

class Student6
{
    public string? FirstName {get; set;}
    public string? LastName {get; set;}

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}

/*
CONSTRUCTOR

A constructor is a special type of method which will be called automatically when you create 
an instance of a class. A constructor is defined by using an access modifier and class name 
<access-modifier> <class-name>().
*/

class Student7
{
    // Constructor
    public Student7()
    {
        
    }
}

/*
A constructor name must be the same as a class name.
A constructor can be public, private, or protected.
The constructor cannot return any value so cannot have a return type.
A class can have multiple constructors with different parameters but can only have one parameterless constructor.
If no constructor is defined, the C# compiler will create it internally.
*/

/*
OBJECTS OF A CLASS

You can create one or more objects of a class. Each object can have different values of 
properties and field, but methods and events behave the same.

In C#, an object of a class can be created using the "new" keyword and assign that object to a 
variable of a class type. For example, the following creates an object of the Student class 
and assign it to a variable of the Student type.
*/


class Student8
{
    // Constructor
    public Student8()
    {
    
    }

    // Objects of a class must be declared inside the class
    readonly Student8 myStudent = new();
}

// You can now access public members of a class using the object.MemberName notation.


namespace Students
{
    public class Student9
    {
        public string? FirstName {get; set;}
        public string? LastName {get; set;}

        public string GetFullName()
        {
            Console.WriteLine("Full name : " + FirstName + " " + LastName + ".");
            return FirstName + " " + LastName;
        }
    }

    class MainC
    {
        // public static void Main()
        // {
        //     Student9 myStudent = new()
        //     {
        //         FirstName = "Reimu",
        //         LastName = "Hakurei"
        //     };

        //     Student9 myStudent2 = new()
        //     {
        //         FirstName = "Marisa",
        //         LastName = "Kirisame"
        //     };

        //     Student9 myStudent3 = new()
        //     {
        //         FirstName = "Reisen",
        //         LastName = "Inaba"
        //     };


        //     myStudent.GetFullName();
        //     myStudent2.GetFullName();
        //     myStudent3.GetFullName();
        // }
    }
}

// You can create multiple objects of a class with different values of properties and fields.