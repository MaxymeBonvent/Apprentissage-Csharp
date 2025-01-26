// 74. S[O]LID : OPEN/CLOSED PRINCIPLE

namespace Lesson74
{
    class Program74
    {
        // public static void Main()
        // {
        //     /*
        //         The Open/Closed Principle (OCP) is the second principle of SOLID. 
        //         Bertrand Meyer originated this term in his book 
        //         Object-oriented Software Construction.

        //         Open/Cloced Principle states that:

        //         Software entities (classes, modules, functions, etc.) should be open for 
        //         extension, but closed for modification. 
        //     */


        //     /*
        //         Now, what does it mean by extension and modification?

        //         Here, the extension means adding new features to the system without modifying 
        //         that system. The plugin systems are the main example of OCP where new 
        //         features are added using new features without modifying the existing ones.

        //         OCP says the behavior of a method of a class should be changed without 
        //         modifying its source code. You should not edit the code of a method 
        //         (bug fixes are ok) instead you should use polymorphism or other techniques to 
        //         change what it does. Adding new functionality by writing new code.
        //     */

        //     /*
        //         In C#, Open/Closed principle can be applied using the following approaches:

        //         1. Using Function Parameters
        //         2. Using Extension methods
        //         3. Using Classes, Abstract class, or Interface-based Inheritance
        //         4. Generics
        //         5. Composition and Dependency Injection

        //         To demonstrate OCP, let's take an example of the Logger class shown below. 
        //         Assume that you are the creator of this class and other programmers want to 
        //         reuse your class so that they don't have to spend time to rewriting it 
        //         (SOLID principles promote reusability).
        //     */

        //     /*
        //         Now, some developers want to change debug messages to suit their needs. 
        //         For example, they want to start debugging messages with "Dev Debug ->". 
        //         So, to satisfy their need, you need to edit the code of the Logger class and 
        //         either create a new method for them or modify the existing Debug() method. 
        //         If you change the existing Debug() method then the other developers who don't 
        //         want this change will also be affected.

        //         One way to use OCP and solve this problem is to use class based-inheritance 
        //         (polymorphism) and override methods. You can mark all the methods of the 
        //         Logger class as virtual so that if somebody wants to change any of the 
        //         methods then they can inherit the Logger class into a new class and override 
        //         it.
        //     */

        //     /*
        //         Now, a new class can inherit the Logger class and change one or more method 
        //         behavior. The developers who wanted to change the debug message will create a 
        //         new class, inherit the Logger class and override the Debug() method to 
        //         display the message they wanted, as shown below.
        //     */

        //     /*
        //         They will now use the above class to display debug messages they want without 
        //         editing the source code of the original class.
        //     */

        //     Console.WriteLine("A");

        //     Logger logger = new();
        //     logger.Debug("Testing debug");

        //     Logger newlogger = new NewLogger();
        //     newlogger.Debug("Testing debug ");

        //     Console.WriteLine("\n");

        //     /*
        //         Thus, OCP using inheritance makes it "Open for extension and closed for 
        //         modification".

        //         Let's take another example. The following is the Course class that we created 
        //         in the previous SRP section.
        //     */

        //     /*
        //         We will have to edit the above Course class whenever there is a requirement 
        //         of adding a new type of course. We will have to add one more if condition or 
        //         switch cases to process the course type. Also, the above Course class does 
        //         not follow the Single Responsibility Principle because if there is any change 
        //         in the process of subscribing to courses or need to add new types of courses, 
        //         then we will have to change the Course class.

        //         To apply OCP to our Course class, abstract class-based inheritance is more 
        //         suitable. We can create an abstract class as a base class and then create a 
        //         new class for each type of course and implement the Subscribe() method in 
        //         each class which will do all the necessary subscription steps, as shown below.
        //     */

        //     /*
        //         As you can see, the Course class is now an abstract class where the 
        //         Subscribe() method is an abstract method that needs to be implemented in a 
        //         class that inherits the Course class. This way there is a separate 
        //         Subscribe() function for separate course types (Separation of concerns). 
        //         You can create a new class for a new type of course in the future that 
        //         inherits the Course class. That way, you don't have to edit the existing 
        //         classes.

        //         You can now subscribe a student to a course, as shown below:
        //     */

        //     Student std = new ()
        //     { 
        //         FirstName = "Steve", 
        //         LastName = "Jobs" 
        //     };
        
        //     CourseB onlineCourse = new OnlineCourseB() 
        //     { 
        //         Title = "Software Engneering" 
        //     };

        //     onlineCourse.Subscribe(std);

        //     /*
        //         ADVANTAGES OF OCP:

        //         1. Minimize the possibilities of error by not modifying existing classes.

        //         2. Easily add new functionalities by adding new classes wherein no current 
        //         functionality depends on the new classes.

        //         3. Promote the Single Responsibility Principle.

        //         4. Unit test each class.
        //     */
        // }

        public class Student
        {
            public string? FirstName {get; set;}
            public string? LastName {get; set;}
        }

        // Base class
        public abstract class CourseB
        {
            public int CourseId {get; set;}
            public string? Title {get; set;}

            public abstract void Subscribe(Student std);
        }
        
        // Derived class
        public class OnlineCourseB : CourseB
        {
            public override void Subscribe(Student std)
            {
                //write code to subscribe to an online course
            }
        }

        // Derived class
        public class OfflineCourseB : CourseB
        {
            public override void Subscribe(Student std)
            {
                //write code to subscribe to a offline course
            }
        }

        public class Course
        {
            public int CourseId {get; set;}
            public string? Title {get; set;}
            public string? Type {get; set;}

            public void Subscribe(Student std)
            {
                Logger logger = new();

                logger.Log("Starting Subscribe()");

                //apply business rules based on the course type live, online, offline, if any 
                if (this.Type == "online")
                {
                    //subscribe to online course 
                }
                else if (this.Type == "offline")
                {
                    //subscribe to offline course 
                }

                // payment processing
                PaymentManager.ProcessPayment();

                //create CourseRepository class to save student and course into StudentCourse table  

                // send confirmation email
                EmailManager.SendEmail();

                logger.Log("End Subscribe()");
            }
        }

        public class PaymentManager
        {
            public static void ProcessPayment()
            {
                Console.WriteLine("ProcessPayment() called.");
            }
        }

        public class EmailManager
        {
            public static void SendEmail()
            {
                Console.WriteLine("SendEmail() called.");
            }
        }

        public class NewLogger : Logger
        {
            public override void Debug(string? msg)
            {
                Console.WriteLine($"Dev Debug -> {msg}");
            }
        }

        public class Logger
        {
            public virtual void Log(string? msg)
            {
                Console.WriteLine(msg);
            }

            public virtual void Info(string? msg)
            {
                Console.WriteLine($"Info: {msg}");
            }

            public virtual void Debug(string? msg)
            {
                Console.WriteLine($"Debug: {msg}");
            }
        }
    }
}