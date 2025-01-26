// 77. SOLI[D]: DEPENDENCY INVERSION PRINCIPLE

namespace Lesson77
{
    class Program77
    {
        // public static void Main()
        // {
        //     /*
        //         Dependency Inversion Principle is the last principle of SOLID principles. 
        //         It helps in loose coupling.

        //         Dependency Inversion Principle states that:

        //         High-level modules should not depend on low-level modules. Both should depend 
        //         on abstraction.  
        //     */

        //     /*
        //         Now, the question is what are high-level and low-level modules and what is an 
        //         abstraction?

        //         A high-level module is a module (class) that uses other modules (classes) to 
        //         perform a task. A low-level module contains a detailed implementation of some 
        //         specific task that can be used by other modules. The high-level modules are 
        //         generally the core business logic of an application whereas the low-level 
        //         modules are input/output, database, file system, web API, or other external 
        //         modules that interact with users, hardware, or other systems.

        //         Abstraction is something that is not concrete. Abstraction should not depend 
        //         on detail but details should depend on abstraction. For example, an abstract 
        //         class or interface contains methods declarations that need to be implemented
        //         in concrete classes. Those concrete classes depend on the abstract class or 
        //         interface but not vice-versa.
        //     */

        //     /*
        //         Now, how do we know a class depends on another class?

        //         You can identify a class is depends on another class if it creates an object 
        //         of another class. You may require to add the reference of the namespace to 
        //         compile or run the code.

        //         Let's use the following example to understand the DIP:
        //     */

        //     /*
        //         The below Student class creates an object of the StudentRepository class for 
        //         CRUD operation to a database. Thus, the Student class depends on the 
        //         StudentRepository class for CRUD operations. The Student class is the 
        //         high-level module and the StudentRepository class is the low-level module.
        //     */

        //     /*
        //         Here, the problem is that the Student class creates an object of concrete 
        //         StudentRepository class using the new keyword and makes both tightly coupled.
        //         This leads to the following problems:

        //         Creating objects using the new keyword at all places is repeated code. 
        //         The object creation is not in one place. Violation of the Do Not Repeat 
        //         Yourself (DRY) principle. If there is some change in the constructor of the 
        //         StudentRepository class then we need to make the changes in all the places. 
        //         If object creation is in one place then it would be easy to maintain the code.

        //         Creating an object using new also make unit testing impossible. We cannot 
        //         unit test the Student class separately.

        //         The StudentRepository class is a concrete class, so any changes in the class 
        //         will require changing the Student class too.
        //     */

        //     /*
        //         DIP says that high-level modules should not depend on the low-level module. 
        //         Both should depend on abstraction. Here, abstraction means use of interface 
        //         or abstract class.

        //         The following is the result of applying the DIP principle to the above example.
        //     */

        //     /*
        //         The StudentRepository class above implements the IStudentRepository interface. 
        //         Here, IStudentRepository is an abstraction of CRUD operations for 
        //         student-related data. The StudentRepository class provides the implementation 
        //         of that methods, so it depends on the methods of the IStudentRepository 
        //         interface.

        //         The Student class does not create an object of the StudentRepository class 
        //         using the new keyword. The constructor requires a parameter of the 
        //         IStudentRepository class which will be passed from the calling code. 
        //         Thus, it also depends on the abstraction (interface) rather than the 
        //         low-level concrete class (StudentRepository).

        //         This will create loose coupling and also make each class unit testable. 
        //         The caller of the Student class can pass an object of any class that 
        //         implements the IStudentRepository interface and by so not tied to a 
        //         specific concrete class.
        //     */

        //     // For production
	    //     Student std1 = new();

	    //     // For unit tests
	    //     Student std2 = new();

        //     /*
        //         Instead of creating manually, you can use the factory class to create it, so 
        //         that all the object creation will be in one place.
        //     */

        //     /*
        //         It is recommended to use Dependency Injection and IOC 
        //         (Indicator Of Compromise) containers for creating and passing objects of 
        //         low-level classes to high-level classes.
        //     */
        // }

        // -- REPOSITORY AND FACTORY -- //
        // public class RepositoryFactory
        // {
        //     public static IStudentRepositoryB GetStudentRepository() 
        //     {
        //         return new StudentRepositoryB();
        //     }

        //     // public static IStudentRepositoryB GetTestStudentRepository() 
        //     // {
        //     //     return new TestStudentRepositoryB();
        //     // }
        // }

        // --- EXAMPLE 2 --- //
        public class StudentB
        {
            public int Id {get; set;}
            public string? FirstName {get; set;}
            public string? LastName {get; set;}
            public DateTime DoB {get; set;}

            private IStudentRepositoryB _stdRepo;

            public StudentB(IStudentRepositoryB stdRepo)
            {
                _stdRepo = stdRepo;
            }

            public void Save()
            {
                _stdRepo.AddStudent(this);
            }
        }

        public interface IStudentRepositoryB
        {
            void AddStudent(StudentB std);
            void EditStudent(StudentB std);
            void DeleteStudent(StudentB std);
                
            IList<StudentB> GetAllStudents();
        }

        public class TestStudentRepositoryB
        {

        }

        // public class StudentRepositoryB : IStudentRepositoryB
        // {
        //     public void AddStudent(StudentB std)
        //     {
        //         //code removed for clarity
        //     }

        //     public void DeleteStudent(StudentB std)
        //     {
        //         //code removed for clarity
        //     }

        //     public void EditStudent(StudentB std)
        //     {
        //         //code removed for clarity
        //     }

        //     // public IList<StudentB> GetAllStudents()
        //     // {
        //     //     //code removed for clarity
        //     // }
        // }

        // --- EXAMPLE 1 --- //
        public class Student
        {
            public int Id {get; set;}
            public string? FirstName {get; set;}
            public string? LastName {get; set;}
            public DateTime DoB {get; set;}

            // Tight coupling
            private StudentRepository stdRepo = new();
            
            public Student()
            {

            }

            public void Save()
            {
                stdRepo.AddStudent(this);
            }
        }

        public class StudentRepository 
        {
            public void AddStudent(Student std)
            {
                //EF code removed for clarity
            }

            public void DeleteStudent(Student std)
            {
                //EF code removed for clarity
            }

            public void EditStudent(Student std)
            {
                //EF code removed for clarity
            }
                
            // public IList<Student> GetAllStudents()
            // {
            //     //EF code removed for clarity
            // }
        }
    }
}