// 66. ENCAPSULATION IN OBJECT-ORIENTED PROGRAMMING

namespace Lesson66
{
    class Program66
    {
        // public static void Main()
        // {
        //     /*
        //         People often get confused between abstraction and encapsulation. As we learnt 
        //         in the previous chapter, abstraction is a way of thinking, whereas 
        //         encapsulation is a technique to implement abstraction.

        //         Encapsulation is a technique to implement abstraction in code. Create classes 
        //         and their members with appropriate access modifiers to show or hide details 
        //         and complexity.

        //         Encapsulation hides the data and implementation details show only the 
        //         required members within a class, thus hiding complexity from other code. No 
        //         other code needs to know about implementation detail and also can’t modify 
        //         the code of the class’s data and methods.

        //         Most object-oriented programming languages allow you to create classes and 
        //         their properties and methods along with the access modifiers such as public, 
        //         private, protected, and internal to show or hide data members and 
        //         implementation details. Interfaces and abstract classes can also be used for 
        //         encapsulation.
        //     */

        //     /*
        //         For example, the Student class has the following members:

        //         As you can see, the FirstName, MiddleName, LastName, and FullName are data 
        //         members and Save(), Subscribe(), GetSubscribedCourses() are methods.

        //         In C#, we can implement encapsulation mostly using class, interface, abstract 
        //         class, property, method, struct, enum, and access modifiers. For the above 
        //         Student entity, we can create the Student class. Use properties for the data 
        //         members and methods for the actions.

        //         The following example demonstrates encapsulation.
        //     */

        //     /*
        //         Below, private fields such as _firstName, _middleName, and _lastName store 
        //         the data privately to hide it from the external code so that they cannot 
        //         modify it with invalid values. FirstName, MiddleName, and LastName properties 
        //         use these fields in the getters and setters to return and set values to these 
        //         fields. These are public properties so that they are visible and accessible 
        //         to outside code via getters and setters. The FullName property internally 
        //         uses private variables to return the full name of the student.

        //         In the same way, the public Enroll() method is visible but it hides the 
        //         implementation detail by internally calling the private Subscribe() method. 
        //         External code cannot know and access the Subscribe() method because it is a 
        //         private method.
        //     */

        //     /*
        //         Advantages of Encapsulation:

        //         Hides data and complexities.

        //         Restrict unauthorized access of data by allowing authorization before data 
        //         access.

        //         Allow validation before setting data.

        //         Only the author of the class needs to understand the implementation, not 
        //         others.

        //         Makes applications easy to maintain.
        //     */
        // }

        public class Student
        {
            // Field
            private string? _firstName;

            // Property
            public string FirstName
            {
                get {return _firstName!;}
                set {_firstName = value;}
            }

            // Field
            private string? _middleName;

            // Property
            public string MiddleName
            {
                get {return _middleName!;}
                set {_middleName = value;}
            }

            // Field
            private string? _lastName;

            // Property
            public string LastName
            {
                get {return _lastName!;}
                set {_lastName = value;}
            }

            // Property
            public string? FullName
            {
                get {return _firstName + " " + _lastName;}
            }

            public static void Save() { 
                //write code to save student 
            }

            public static void Subscribe(Course cs)
            {
                Verify();
                    
                //write code to subscribe to a course
            }

            private static void Verify()
            {
                //write code to verify student before subscribing
            }

            public static void GetSubscribedCourses()
            {
                //write code to return all subscribed courses
            }
        }

        public class Course
        {
            
        }
    }
}