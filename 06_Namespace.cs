// 6. NAMESPACE

using System; //built-in namespace
using School;

/*
Namespaces play an important role in managing related classes in C#. The .NET Framework uses 
namespaces to organize its built-in classes. For example, there are some built-in namespaces 
in .NET such as System, System.Linq, System.Web, etc. Each namespace contains related classes.

A namespace is a container for classes and namespaces. The namespace also gives unique names 
to its classes thereby you can have the same class name in different namespaces.

In C#, a namespace can be defined using the "namespace" keyword.
*/

namespace School
{
    // Define classes here
}

// The following namespace contains the Student and Course classes.

namespace School
{
    class Student
    {

    }

    class Course
    {

    }
}

/*
Classes under the same namespace can be referred to as namespace.classname syntax. 
For example, the Student class can be accessed as School.Student.
*/

namespace CSharpTutorials
{
    class MyClass
    {
        // static void Main(string[] args)
        // {
        //     Student student = new Student();
        
        //     Course course = new Course();
        // }
    }
}

/*
To use classes under a namespace without the fully qualified name, import the namespace with 
the "using" keyword at the top of C# class file.
*/

// A namespace can contain other namespaces. Inner namespaces can be separated using ".".

namespace School.Education.Student
{
    class Student
    {

    }
}

// In the above example, the fully qualified class name is School.Education.Student.