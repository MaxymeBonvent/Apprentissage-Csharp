// 67. CLASS RELATIONS: ASSOCIATION AND COMPOSITION

namespace Lesson67
{
    class Program67
    {
        // public static void Main()
        // {
        //     /*
        //         In object-oriented programming, classes interact with each other to 
        //         accomplish one or more features of an application. You can define the 
        //         relationship between classes while designing the classes of your application.

        //         There are three types of relationships in object-oriented programming based 
        //         on how a class interacts with another class.

        //         1. Association
        //         2. Composition
        //             Composition
        //             Aggregation
        //         3. Inheritance

        //         The following figure illustrates the relationships.

        //         Association (uses a)
        //         Composition (has a) < Aggregation, Composition
        //         Inheritance (is a)
        //     */

        //     /*
        //         ASSOCIATION

        //         Association relationship is referred to as "uses a" relationship where a 
        //         class uses another class to perform some operation. In association, both 
        //         classes can exist independently where nobody is the owner of another. Some 
        //         people refer association as collaboration or delegation.

        //         Association happens between the classes where one class provides a service to 
        //         another class or the class delegates some kinds of behaviors to another class.

        //         Association is typically implemented with a pointer or reference instance 
        //         variable or as a method argument.

        //         The following example demonstrates the association relationship between the 
        //         Student and StudentRepository class.
        //     */

        //     /*
        //         In the above example, the StudentRepository class uses the Student class to 
        //         save or retrieve student data. Notice that the StudentRepository class uses 
        //         the Student class as a parameter of methods. The StudentRepository class 
        //         provides service to any class who is interested in saving or retrieving 
        //         student data. However, both the classes have independent lifetime meaning 
        //         that disposing one does not dispose of another. So, we can say that the 
        //         relationship between the StudentRepository and the Student class is 
        //         association (or collaboration/delegation). You can also say that the Student 
        //         class delegates the responsibility of the implementation of saving and 
        //         retrieving student-related data to the StudentRepository class.

        //         The association relationship between the classes is marked with the arrow in 
        //         UML (Unified Modeling Language) diagram, as shown below.

        //         Student ---> Association ---> StudentRepository
        //     */

        //     /*
        //         Important Points:

        //         A class only uses behaviors/functionalities (methods) of another class but 
        //         does not change them by overriding them.

        //         A class does not inherit another class.

        //         A class does not include (own) another class as a public member.

        //         Both classes have independent lifetime where disposing of one does not 
        //         automatically dispose of another.
        //     */

        //     /*
        //         COMPOSITION

        //         Composition is referred to as "has a" relationship. Composition relationship 
        //         is formed when a class has a reference to another class as an instance 
        //         property.

        //         In the composition relationships, a class that contains the reference to 
        //         another class is the parent (owner) of that child class. The child class 
        //         without parent class doesn't exist.

        //         Composition relationship has two categories:

        //         1. Composition
        //         2. Aggregation

        //         For example, the following StudentB class has a composite relationship with 
        //         the AddressB class that holds the student's address. The AddressB object 
        //         without the StudentB object cannot exist.
        //     */

        //     /*
        //         In the below example, the Student class has an Address class as a public 
        //         property which makes the composite relationship between the Student and 
        //         Address class. If the Student object is deleted then the Address object will 
        //         also be deleted.

        //         The composite relationship also has a cardinality that is a one-to-one, 
        //         one-to-many, or many-to-many relationship between classes. In the above 
        //         example, the Student and the Address class have a one-to-one relationship 
        //         because each Student will have only one address.

        //         A class can also include the id property of another class instead of an 
        //         instance to form the composite relationship. For example, the Student class 
        //         can contain the AddressId property that points to the Address class.
        //     */

        //     /*
        //         The composition relationship between the classes is marked using the line in 
        //         UML diagram, as shown below.

        //         Student♦---Composition---Adress
        //     */

        //     /*
        //         Important Points:

        //         A class (parent) contains a reference to another class (child).
        //         The child class doesn't exist without the parent class.
        //         Deleting the parent class will also delete the child class.
        //         A class can also include a reference to the id property of another class.
        //     */

        //     /*
        //         AGGREGATION

        //         Aggregation is another category of "has a" relationship where a class can 
        //         contain other classes as properties but those classes can exist independently.

        //         For example, the Student class contains the Course class instance as a 
        //         property to form a composition relationship. However, both classes can 
        //         exist independently so it's called an aggregation relationship.
        //     */

        //     /*
        //         In the above aggregation relationship, even if the Student object is deleted, 
        //         the Course object will still exist. The Student class can also contain 
        //         CourseId property instead of Course instance.

                
        //         Composition and Aggregation both are "has a" relationship but in the 
        //         composition relationship, related classes don't exist independently whereas, 
        //         in the aggregation, related classes exist independently.

                
        //         The aggregation relationship between the classes is marked with a line in UML 
        //         diagram, as shown below.

        //         Student◊---Aggregation---Course
        //     */

        //     /*
        //         Important Points:

        //         Aggregation is another type of composition ("has a" relation).

        //         A class (parent) contains a reference to another class (child) where both 
        //         classes can exist independently.

        //         A class can also include a reference of the id property of another class.
        //     */
        // }

        public class StudentD
        {
            public int StudentId {get; set;}
            public string? FirstName {get; set;}
            public string? MiddleName {get; set;}
            public string? LastName {get; set;}
            public Course? EnrolledCourse {get; set;}
        }

        public class Course
        {
            public int CourseId {get; set;}
            public string? CourseName {get; set;}
            public IList<string>? Topics {get; set;}
            public DateTime StartDate {get; set;}
            public DateTime EndDate {get; set;}
        }

        public class StudentC
        {
            public int StudentId {get; set;}
            public string? FirstName {get; set;}
            public string? MiddleName {get; set;}
            public string? LastName {get; set;}
            public int AddressId {get; set;}
        }

        public class StudentB
        {
            public int StudentId {get; set;}
            public string? FirstName {get; set;}
            public string? MiddleName {get; set;}
            public string? LastName {get; set;}
            public AddressB? HomeAddress {get; set;}
        }

        public class AddressB
        {
            public int AddressId {get; set;}
            public string? Address1 {get; set;}
            public string? Address2 {get; set;}
            public string? City {get; set;}
            public string? State {get; set;}
            public string? ZipCode {get; set;}
            public string? Country {get; set;}
        }

        public class Student
        {
            public int ID {get; set;}
            public string? FirstName {get; set;}
            public string? MiddleName {get; set;}
            public string? LastName {get; set;}
        }

        public class StudentRepository
        {
            public static Student GetStudent(int StudentId)
            {
                // Get student by id from db here

                return new Student();
            }

            public static bool Save(Student student)
            {
                // Save student to db here
                Console.WriteLine("Student saved successfully.");

                return true;
            }

            public static bool Validate(Student student)
            {
                // Get student from db to check whether the data is already exist
                Console.WriteLine("Student does not exist.");

                return true;
            }
        }
    }
}