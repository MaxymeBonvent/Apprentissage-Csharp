// 7. VARIABLES

/*
Variables in C# are the same as variables in mathematics. 
Before we understand what a variable is, let's understand expressions. 
The followings are examples of expressions.
*/

/*
10 + 20
5 * 2
10/2
*/

/*
The result of the above expressions are fixed ; 10 + 20 = 30, 5 * 2 = 10 and 10/2 = 5. 
Now, consider the following expressions.
*/

/*
x + 20
y * 2
z/2
*/

/*
The result of the above expression depends on the value of x, y and z. 
For example, if x = 5 then the result of x + 20 would be 25 and if x = 20 then the result of 
x + 20 would be 40. In the same way, the result of y * 2 depends on the value of y and the 
result of z/2 depends on the value of z. Here, x, y, z are called variables because their 
values can be changed.

The same concept is used in C#. In C#, a variable stores a value of the specific data type. 
It can store a numeric, char, string, or other types of value. You can declare and assign a 
value to a variable like int x = 5; where int is the data type, x is the name of a 
variable, = is an operator that assigns the value to a variable, and 5 is the integer value 
assigned to a variable x.

Syntax :
<data type> <variable name> = <value>;

The following declares and initializes a variable of int type.
*/

namespace Lesson7
{
    class Program7
    {
        // public static void Main()
        // {
        //     int numA = 100;
        //     Console.WriteLine("numA = " + numA);

        //     int i = 100;
        //     Console.WriteLine("i = " + i);

        //     int numB = 110;
        //     Console.WriteLine("numB = " + numB);

        //     float rate = 10.2f;
        //     Console.WriteLine("rate = " + rate);

        //     decimal amount = 100.50M;
        //     Console.WriteLine("amount = " + amount);

        //     char letter = 'C';
        //     Console.WriteLine("letter = " + letter);

        //     bool isValid = true;
        //     Console.WriteLine("isValid = " + isValid);

        //     string name = "Steve";
        //     Console.WriteLine("name = " + name);

        //     int numD;
        //     numD = 140;
        //     Console.WriteLine("numD = " + numD);

        //     int numE = 150;
        //     numE = 200;
        //     Console.WriteLine("numE = " + numE);

        //     int j = 0, k = 10, l = 100;
        //     Console.WriteLine("j = " + j);
        //     Console.WriteLine("k = " + k);
        //     Console.WriteLine("l = " + l);

        //     int m = 1, 
        //     n = 2, 
        //     o = 3;

        //     Console.WriteLine("m = " + m);
        //     Console.WriteLine("n = " + n);
        //     Console.WriteLine("o = " + o);

        //     int p = 100;
        //     int q = p; // value of p will be 100

        //     Console.WriteLine("p = " + p);
        //     Console.WriteLine("q = " + q);

        //     int r = 100;

        //     int s = r + 20; // r = 120

        //     r = 200;
        //     s = r + 20;// q = 220

        //     r = 300;
        //     Console.WriteLine("r = {0}", r);
        //     Console.WriteLine("s = " + s);
        // }  
    }
}

/*
Above, int is a data type, num is a variable name (identifier). The = operator is used 
to assign a value to a variable. The right side of the = operator is a value that will be 
assigned to left side variable. Above, 100 is assigned to a variable num.

The following declares and initializes variables of different data types.
*/

/*
The followings are naming conventions for declaring variables in C#:

Variable names must be unique.
Variable names can contain letters, digits, and the underscore _ only.
Variable names must start with a letter.
Variable names are case-sensitive, num and Num are considered different names.
Variable names cannot contain reserved keywords. Must prefix @ before keyword if you want to 
use a reserved keywords as an identifier.

C# is a strongly typed language. It means you can assign a value of the specified data type. 
You cannot assign an integer value to a string type and vice-versa.
*/

// int numC = "Steve"; Error CS0029 : Cannot implicitely convert "string" to "int"
// Console.WriteLine(numC);

// Variables can be declared first and initialized later.

/*
A variable must be assigned a value before using it, otherwise, C# will give a compile-time 
error.
*/

// int i;
// int j = i; // Error CS0165 : Use of unassigned local variable 'i'

// The value of a variable can be changed anytime after initializing it.

/*
Multiple variables of the same data type can be declared and initialized in a single line 
separated by commas.
*/

/*
Multiple variables of the same type can also be declared in multiple lines separated by a 
comma. The compiler will consider it to be one statement until it encounters a semicolon.
*/

/*
The value of a variable can be assigned to another variable of the same data type. However, 
a value must be assigned to a variable before using it.
*/

/*
Variables can be used in an expression and the result of the expression can be assigned to 
the same or different variable.
*/

/*
In the above example, value of r depends on the value of q. You must re-execute expression 
each time you change the value of q, otherwise the value of r would not change based on the 
value of q.

In C#, variables are categorized based on how they store their value in memory. Variables are 
categorized as value type, reference type or pointer type variables.

It's not necessary to specify the type when declaring variables. Use the "var" keyword 
instead of a data type.
*/