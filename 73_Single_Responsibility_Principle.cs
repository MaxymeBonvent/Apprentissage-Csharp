// 73. [S]OLID : SINGLE RESPONSIBILITY PRINCIPLE

namespace Lesson73
{
    class Program73
    {
        // public static void Main()
        // {
        //     /*
        //         The Single Responsibility Principle is the first principle of SOLID 
        //         principles. It is the fundamental principle of object-oriented programming 
        //         that determines how we should design classes.

        //         The Single Responsibility Principle states that:

        //         Each software module should have one and only one reason to change.
        //         In other words, a class should have only one responsibility and therefore it 
        //         should have only one reason to change its code. If a class has more than one 
        //         responsibility, then there will be more than one reason to change the class 
        //         (code).

        //         Now, the question is what is responsibility?

        //         An application can have many functionalities (features). For example, an 
        //         online e-commerce application has many features such as displaying product 
        //         lists, submitting an order, displaying product ratings, managing customers' 
        //         shipping addresses, managing payments, etc. Along with these features, it 
        //         also validates and persists products and customers' data, logs activities for 
        //         auditing and security purposes, applies business rules, etc. You can think of
        //         these points as functionalities or features or responsibilities. Change in 
        //         any functionality leads to change in the class that is responsible for that 
        //         functionality.

        //         Let's check how many responsibilities the following Student class has: 
        //     */

        //     /*
        //         The above Student class has the following responsibilities:

        //         1. Holds student's properties such as Id, FirstName, LastName, and DoB.
        //         2. Save a new student, or update an existing student to a DB.
        //         3. Delete existing students from the DB if not subscribed to any course.
        //         4. Apply business rules to subscribe to courses based on the course type.
        //         5. Process the payment for the course.
        //         6. Send confirmation email to a student upon successful registration.
        //         7. Logs each activity to the console.
        //     */

        //     /*
        //         If anything in the above responsibility changes, then we will have to modify 
        //         the Student class. For example, if you need to add a new property then we 
        //         need to change the Student class. Or, if you need a change in the database, 
        //         maybe moving from a local server to a cloud, then you need to change the code 
        //         of the Student class. Or, if you need to change the business rules 
        //         (validation) before deleting a student or subscribing to a course, or change 
        //         the logging medium from console to file, then in all these cases you need to 
        //         change the code of the Student class. Thus, you have many reasons to change 
        //         the code because it has many responsibilities.

        //         SRP tells us to have only one reason to change a class. Let's change the 
        //         Student class considering SRP where we will keep only one responsibility for 
        //         the Student class and abstract away (delegate) other responsibilities to 
        //         other classes.
        //     */

        //     /*
        //         Start with each responsibility mentioned above and decide whether we should 
        //         delegate it to other classes or not.

        //         1. The Student class should contain all the properties and methods which are 
        //         specific to the student. Except for the Subscribe() method, all the 
        //         properties and methods are related to the student, so keep all the properties.

        //         2. The Save() and Delete() method is also specific to a student. 
        //         Although, it uses Entity Framework to do the CRUD (Create, Read, Update, 
        //         Delete) operation which is another reason to change the Student class. 
        //         We should move the underlying EF code to another class to do all DB 
        //         operations like StudentRepository class should be created for all CRUD 
        //         operations for the Student. This way if any changes on the DB side then we 
        //         may need to change only the StudentRepository class.

        //         3. The Subscribe() method is more suitable for the Course class because a 
        //         course can have different subscription rules based on the course type. 
        //         So it is idle to move the Subscribe() method to the Course class.

        //         4. Sending confirmation emails is also a part of the Subscribe() method, so 
        //         it will be a part of the Course class now. Although, we will create a 
        //         separate class EmailManger for sending emails.

        //         5. Here, all the activities are logged on the console using the hard-coded 
        //         Console.WriteLine() method. Any changes in the logging requirement would 
        //         cause the Student class to change. For example, if the admin decides to log 
        //         all activities in the text file then you need to change the Student class. 
        //         So, it's better to create a separate Logger class that is responsible for all 
        //         the logging activities.
        //     */

        //     /*
        //         Now, look at the following classes redesigned after applying SRP using the 
        //         above considerations.
        //     */

        //     /*
        //         Now, think about the above classes. Each class has a single responsibility. 
        //         The Student class contains properties and methods specific to the 
        //         student-related activities. The Course class has course-related 
        //         responsibilities. The StudentRepository has responsibilities for 
        //         student-related CRUD operations using Entity Framework. 
        //         The Logger class is responsible for logging activity. 
        //         The EmailManager class has email-related responsibilities. 
        //         The PaymentManager class has payment-related activities.   

        //         In this way, we have delegated specific responsibilities to separate classes 
        //         so that each class has only one reason to change. 
        //         These increase cohesion and loose coupling.             
        //     */

        //     /*
        //         SEPARATION OF CONCERNS

        //         The Single Responsibility Principle follows another principle called 
        //         Separation of Concerns.

        //         Separation of Concerns suggests that the application should be separated into 
        //         distinct sections where each section addresses a separate concern or set of 
        //         information that affects the program. It means that high-level business logic 
        //         should avoid dealing with low-level implementation.

        //         In our example, we separated each concern into separate classes. 
        //         We had only one Student class initially, but then we separated each concern 
        //         like CRUD operations, logging, email, etc. into separate classes. Thus, the 
        //         Student class (high-level class) does not have any idea how CRUD or sending 
        //         emails is happening. It just use the appropriate method and that's it.

        //         The SRP and Separation of Concerns principle increase cohesion and loose 
        //         coupling.
        //     */
        // }

        public class StudentB
        {
            public int Id {get; set;}
            public string? FirstName {get; set;}
            public string? LastName {get; set;}
            public DateTime DoB {get; set;}
            public string? Email {get; set;}
            public string? Address1 {get; set;}
            public string? Address2 {get; set;}
            public string? City {get; set;}
            public string? State {get; set;}
            public string? Zipcode {get; set;}

            public void Save() 
            { 
                Logger.Log("Starting Save()");

                StudentB std = new();
            
                StudentRepository.Save(std);

                Logger.Log("End Save()");
            }

            public void Delete() 
            { 
                Logger.Log("Starting Delete()");

                //check if already subscribed courses

                StudentB std = new();

                StudentRepository.Delete(std);

                Logger.Log("End Delete()");
            }
        }

        public class Logger
        {
            public static void Log(string msg)
            {
                Console.WriteLine(msg);
            }
        }

        public class StudentRepository()
        {
            public static bool Save(StudentB std)
            {
                Logger.Log("Starting Save()");

                //use EF to add a new student or update existing student to db

                Logger.Log("Ending Saving()");

                return true;
            }

            public static bool Delete(StudentB std) 
            { 
                Logger.Log("Starting Delete()");

                //use EF to delete a student 

                Logger.Log("Ending Delete()");

                return true;
            }

            public bool SaveCourse(Student std, Course cs) 
            { 
                Logger.Log("Starting SaveCourse()");

                //use EF to save a course for a student

                Logger.Log("Ending SaveCourse()");

                return true;
            }
        }

        public class CourseB
        {
            public int CourseId {get; set;}
            public string? Title {get; set;}
            public string? Type {get; set;}

            public void Subscribe(Student std)
            {
                Logger.Log("Starting Subscribe()");

                //apply business rules based on the course type live, online, offline, if any 
                if (this.Type == "online")
                {
                    //subscribe to online course 
                }
                else if (this.Type == "live")
                {
                    //subscribe to offline course 
                }

                // Payment processing
                PaymentManager.ProcessPayment();

                //create CourseRepository class to save student and course into StudentCourse table  

                string? receiver = "receiver";
                string? sender = "sender";
                string? subject = "subject";
                string? msg = "msg";

                // send confirmation email
                EmailManager.SendEmail(receiver, sender, subject, msg);

                Logger.Log("End Subscribe()");
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
            public static void SendEmail(string receiverMail, string senderMail, string subject, string message)
            {
                // smtp code here
            }	 
        }

        public class StudentA
        {
            public int Id {get; set;}
            public string? FirstName {get; set;}
            public string? LastName {get; set;}
            public DateTime DoB {get; set;}
            public string? Email {get; set;}
            public string? Address1 {get; set;}
            public string? Address2 {get; set;}
            public string? City {get; set;}
            public string? State {get; set;}
            public string? Zipcode {get; set;}

            public void Save() 
            { 
                Console.WriteLine("Starting Save()");
                Console.WriteLine("End Save()");
            }

            public void Delete() 
            { 
                Console.WriteLine("Starting Delete()");
                Console.WriteLine("End Delete()");
            }

            public Course Subscribe(Course course) 
            { 
                Console.WriteLine("Starting Subscribe()");

                // Apply business rules based on the course type 
                if(course.Type == "Online")
                {
                    // Validate
                    return course;
                }

                else if(course.Type == "Live")
                {
                    // Refuse
                    return course;
                }

                // Payment processing code
                // Save course subscription to DB
                // Send email confirmation code

                Console.WriteLine("End Subscribe()");

                // End method
                return null!;
            }
        }

        public class Course
        {
            public string? Type {get; set;}
        }
    }
}