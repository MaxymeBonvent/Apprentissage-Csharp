// 62. OBJECT INITIALIZER SYNTAX

namespace Lesson62
{
    class Program62
    {
        // public static void Main()
        // {
        //     /*
        //        C# 3.0/.NET 3.5 (2008) introduced Object Initializer Syntax, a new way to 
        //        initialize an object of a class or collection. 
        //        Object initializers allow you to assign values to fields or properties at 
        //        the time of creating an object without invoking a constructor. 
        //     */

        //     Student stud = new()
        //     {
        //         ID = 1,
        //         Name = "Tara",
        //         Age = 29,
        //         Address = "22 Bakersville Park, CA"
        //     };

        //     Console.WriteLine($"stud == {stud}.\n");

        //     /*
        //         In the above example, Student class is defined without any constructors. 
        //         In the Main() method, we have created Student object and assigned values to 
        //         all or some properties in the curly bracket at the same time. 
        //         This is called object initializer syntax.

        //         The compiler compiles the above initializer into something like the following.
        //     */

        //     Student __student = new Student();
        //     __student.ID = 1;
        //     __student.Name = "Tara";
        //     __student.Age = 29;
        //     __student.Address = "22 Bakersville Park, CA";

        //     Student std = __student;

        //     /*
        //         COLLECTION INITIALIZER SYNTAX

        //         Collection can be initialized the same way as class objects using collection 
        //         initializer syntax.
        //     */

        //     Student stud1 = new() {ID = 1, Name = "John"};
        //     Student stud2 = new() {ID = 2, Name = "Steve"};
        //     Student stud3 = new() {ID = 3, Name = "Bill"} ;
        //     Student stud4 = new() {ID = 3, Name = "Bill"};
        //     Student stud5 = new() {ID = 5, Name = "Ron"};

        //     IList<Student> studList =
        //     [
        //         stud1, 
        //         stud2, 
        //         stud3, 
        //         stud4, 
        //         stud5 
        //     ];

        //     Console.WriteLine($"studList == {studList}.\n");

        //     // You can also initialize collections and objects at the same time.

        //     IList<Student> studList2 =
        //     [
        //             new() {ID = 1, Name = "John"},
        //             new() {ID = 2, Name = "Steve"},
        //             new() {ID = 3, Name = "Bill"},
        //             new() {ID = 3, Name = "Bill"},
        //             new() {ID = 4, Name = "Ram" },
        //             new() {ID = 5, Name = "Ron" } 
        //     ];

        //     Console.WriteLine($"studList2 == {studList2}.\n");

        //     // You can also specify null as an element:

        //     IList<Student> studList3 = 
        //     [
        //         new Student() {ID = 1, Name = "John"},
        //         null!
        //     ];

        //     Console.WriteLine($"studList3 == {studList3}.\n");

        //     /*
        //         ADVANTAGES OF INITIALIZERS

        //         Initializer syntax makes code more readable and makes it easy to add elements 
        //         into the collection.

        //         It's useful in multi-threading.
        //     */
        // }

        public class Student
        {
            public int ID {get; set;}
            public string? Name {get; set;}
            public int Age {get; set;}
            public string? Address {get; set;}
        }
    }
}