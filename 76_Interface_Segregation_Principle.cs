// 76. SOL[I]D : INTERFACE SEGREGATION PRINCIPLE

namespace Lesson76
{
    class Program76
    {
        // public static void Main()
        // {
        //     /*
        //         Interface Segregation Principle (ISP) is the fourth principle of SOLID 
        //         principles. It can be used in conjunction with LSP.

        //         Interface Segregation Principle (ISP) states that:

        //         Clients should not be forced to depend on methods they do not use. 
        //     */

        //     /*
        //         Now, you may wondering, who is the client and what and whose methods it is 
        //         talking about?

        //         Here, a client is a code that calls the methods of a class with an instance 
        //         of the interface. For example, a class implements an interface that contains 
        //         10 methods. Now, you create an object of that class with a variable of that 
        //         interface and call only 5 methods for the functionality you wanted and never 
        //         call the other 5 methods. So, this means that the interface contains more 
        //         methods that are not used by all client codes. It is called a fat interface. 
        //         ISP suggests segregating that interface into two or more interfaces so that a 
        //         class can implement the specific interface that it requires.

        //         Let's use the following interface to learn ISP in detail:
        //     */

        //     /*
        //         The above IStudentRepository interface contains 12 methods for different 
        //         purposes. The StudentRepository class implements the IStudentRepository 
        //         interface.

        //         Now, after some time, you observe that not all instances of the 
        //         StudentRepository class call all the methods. Sometimes it calls methods that 
        //         perform student-related tasks or sometimes calls course-related methods. Also, 
        //         the StudentRepository does not follow the single responsibility principle 
        //         because you may need to edit its code if student related as well as 
        //         course-related business logic changes.

        //         To apply ISP to the above problem, we can split our large interface 
        //         IStudentRepository and create another interface ICourseRepository with all 
        //         course-related methods, as shown below.
        //     */

        //     /*
        //         Now, we can create two concrete classes that implement the above two 
        //         interfaces. This will automatically support SRP and increase cohesion.

        //         ISP is not specific to interfaces only but it can be used with abstract 
        //         classes or any class that provides some services to the client code.

        //         ISP helps in implementing Liskov Substitution Principle, increasing cohesion 
        //         that in turn supports the Single Responsibility Principle.
        //     */

        //     /*
        //         The following code detects ISP violation:

        //         1. When you have large interfaces.

        //         2. When you implement an interface in a concrete class where some methods do 
        //         not have any implementation code or throw NotImplementedException.

        //         3. When you call only a small set of methods of a larger interface.
        //     */

        //     /*
        //         The solution to ISP violations:

        //         1. Split large interfaces into smaller ones.

        //         2. Inherit multiple small interfaces if required.
                
        //         3. Use the adapter design pattern for the third-party large interface so that your code can work with the adapter.
        //     */
        // }

        public interface IStudentRepository
        {
            void AddStudent(Student std);
            void EditStudent(Student std);
            void DeleteStudent(Student std);
            bool SubscribeStudentToCourse(Course cs);
            bool UnSubscribeStudentFromCourse(Course cs);
            IList<Student> GetAllStudents();
            IList<Student> GetAllStudents(Course cs);
        }  

        public interface ICourseRepository
        {
            void AddCourse(Course cs);
            void EditCourse(Course cs);
            void DeleteCourse(Course cs);

            IList<Course> GetAllCourses();
            IList<Course> GetAllCourses(Student std);
        }     

        // public class StudentRepository : IStudentRepository
        // {
        //     public void AddCourse(Course cs)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public void AddStudent(Student std)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public void DeleteCourse(Course cs)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public void DeleteStudent(Student std)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public void EditCourse(Course cs)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public void EditStudent(Student std)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public IList<Course> GetAllCourses()
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public IList<Course> GetAllCourses(Student std)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public IList<Student> GetAllStudents()
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public IList<Student> GetAllStudents(Course cs)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public bool SubscribeStudentToCourse(Course cs)
        //     {
        //         //implementation code removed for better clarity
        //     }

        //     public bool UnSubscribeStudentFromCourse(Course cs)
        //     {
        //         //implementation code removed for better clarity
        //     }
        // }

        public class Course
        {

        }
    }
}