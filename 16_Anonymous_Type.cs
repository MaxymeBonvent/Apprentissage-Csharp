// 16. ANONYMOUS TYPE

namespace Lesson16
{
    class Program16
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, an anonymous type is a type (class) without any name that can contain 
        //         public read-only properties only. It cannot contain other members, such as 
        //         fields, methods, events, etc.

        //         You create an anonymous type using the new operator with an object 
        //         initializer syntax. The implicitly typed variable- var is used to hold the 
        //         reference of anonymous types.

        //         The following example demonstrates creating an anonymous type variable 
        //         student that contains three properties named Id, FirstName, and LastName.
        //     */

        //     var student = new {id = 1, firstName = "Jack", lastName = "Frost"};
        //     Console.WriteLine($"student = {student}");

        //     /*
        //         The properties of anonymous types are read-only and cannot be initialized 
        //         with a null, anonymous function, or a pointer type. The properties can be 
        //         accessed using dot (.) notation, like object properties. However, you 
        //         cannot change the values of properties as they are read-only.
        //     */

        //     var student2 = new {id = 2, firstName = "Elsa", lastName = "Mina"};
        //     Console.WriteLine($"student2.id = {student2.id}");
        //     Console.WriteLine($"student2.firstName = {student2.firstName}");
        //     Console.WriteLine($"student2.lastName = {student2.lastName}");

        //     /*
        //         student2.id = 2;
        //         student2.firstName = "Steve";

        //         Compiler error CS0200 : Property or indexer 'student2.id/firstName' cannot be 
        //         assigned to -- it is read only.
        //     */

        //     // An anonymous type's property can include another anonymous type.

        //     var student3 = new 
        //     { 
        //             id = 3, 
        //             firstName = "Matt", 
        //             lastName = "Earthware",
        //             address = new {id = 1, city = "Muda", country = "Weyard"}
        //     };

        //     Console.WriteLine($"student3 = {student3}");

        //     // You can create an array of anonymous types.

        //     var students = new[] 
        //     {
        //         new {id = 4, firstName = "Bowser", lastName = "Koopa"},
        //         new {id = 5, firstName = "Zelda", lastName = "Hylia"},
        //         new {id = 6, firstName = "Samus",  lastName = "Aran"}
        //     };

        //     Console.WriteLine($"students = {students}");

        //     /*
        //         An anonymous type will always be local to the method it's defined in. 
        //         It cannot be returned from a method. However, an anonymous type can be 
        //         passed to a method as an object type parameter, but that is not recommended. 
        //         If you need to pass it to another method, use struct or class instead of 
        //         an anonymous type.

        //         Mostly, anonymous types are created using the Select clause of LINQ queries 
        //         to return a subset of the properties from each object in the collection.
        //     */



        //     IList<Student> studentsList = new List<Student>()
        //     {
        //         new Student(){id = 7, name = "Peach", age = 22},
        //         new Student(){id = 8, name = "Daisy", age = 22},
        //         new Student(){id = 9, name = "Rosalina", age = 3000},
        //     };

        //     Console.WriteLine($"studentsList = {studentsList}.");

        //     var linqStudents =  from stud in studentsList
        //                         select new {id = stud.id, name = stud.name};

        //     foreach(var stud in linqStudents)
        //     {
        //         Console.WriteLine($"{stud.id} - {stud.name}");
        //     }

        //     /*
        //         In the above example, a select clause in the LINQ query selects only 
        //         id and name properties and renames it to id and name. Thus, it is useful in 
        //         saving memory and unnecessary code. The query result collection includes only 
        //         id and name properties.
        //     */

        //     /*
        //         Internally, all anonymous types are directly derived from the 
        //         System.Object class. The compiler generates a class with some auto-generated 
        //         name and applies the appropriate data type to each property based on the value. 
        //         Although your code cannot access it. Use GetType() to see 
        //         the name.
        //     */

        //     var student10 = new {id = 10, firstName = "Sonic", lastName = "Hedgehog"};
        //     Console.WriteLine($"student10.GetType().ToString() = {student10.GetType().ToString()}");

        //     Console.WriteLine($"student10.firstName = {student10.firstName}");
        // }

        public class Student
        {
            public int id {get; set;}
            public string? name {get; set;}
            public int age {get; set;}
        }
    }
}