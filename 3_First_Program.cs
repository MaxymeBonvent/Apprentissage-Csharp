// 3. FIRST PROGRAM

/*
Here, you will learn to create a simple console application in C# 
and understand the basic building blocks of a console application.

C# can be used in a window-based, web-based, or console application. 
To start with, we will create a console application to work with C#.
*/

/*
Every console application starts from the Main() method of the Program class. 
The following example displays "Hello World!!" on the console.
*/

namespace Lesson1
{
    class Program1
    {
        // public static void Main(string[] args)
        // {
        //     string message = "Hello World.";

        //     Console.WriteLine(message);
        // }
    }
}

/*
Let's understand the above C# structure.

1. Every .NET application takes the reference of the necessary .NET framework namespaces that 
it is planning to use with the using keyword, e.g., using System.Text.

2. Declare the namespace for the current class using the namespace keyword, e.g., namespace 
CSharpTutorials.FirstProgram

3. We then declared a class using the class keyword: class Program

4. The Main() is a method of Program class is the entry point of the console application.

5. String is a data type.

6. message is a variable that holds the value of a specified data type.

7. "Hello World!!" is the value of the message variable.

8. Console.WriteLine() is a static method, which is used to display a text on the console.
*/

// Every line or statement in C# must end with a semicolon (;).