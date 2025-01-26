// 50. CUSTOM EXCEPTION TYPE

using System.Text.RegularExpressions; //ecessary to use the Regex static class

namespace Lesson50
{
    class Program50
    {
        // public static void Main()
        // {
        //     /*
        //         C# includes the built-in exception types such as NullReferenceException, 
        //         MemoryOverflowException, etc. However, you often like to raise an exception 
        //         when the business rule of your application gets violated. So, for this, you 
        //         can create a custom exception class by deriving the ApplicationException class.

        //         The .NET framework includes ApplicationException class since .NET v1.0 (2002). 
        //         It was designed to use as a base class for the custom exception class. 
        //         However, Microsoft now recommends Exception class to create a custom 
        //         exception class. You should not throw an ApplicationException exception in 
        //         your code, and you should not catch an ApplicationException exception unless 
        //         you intend to re-throw the original exception.

        //         For example, create InvalidStudentNameException class in a school 
        //         application, which does not allow any special character or numeric value in a 
        //         name of any of the students.  
        //     */

        //     /*
        //         Now, you can raise InvalidStudentNameException in your program whenever the 
        //         name contains special characters or numbers. 
        //         Use the "throw" keyword to raise an exception.
        //     */

        //     Student? stud = null;
          
        //     try
        //     {
        //         stud = new()
        //         {
        //             Name = "James007"
        //         };

        //         ValidateStudent(stud);
        //     }

        //     catch(InvalidStudentNameException ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //     }

        //     Console.ReadKey();
        // }

        // Method to validate a student's name
        private static void ValidateStudent(Student std)
        {
            Regex regex = new("^[a-zA-Z]+$");

            if(std.Name != null && !regex.IsMatch(std.Name))
            {
                throw new InvalidStudentNameException(std.Name);
            }
        }

        // Student class
        class Student
        {
            public int ID {get; set;}
            public string? Name {get; set;}
        }

        // Exception class
        [Serializable]
        class InvalidStudentNameException : Exception
        {
            // Primary constructor (?)
            public InvalidStudentNameException() {}

            public InvalidStudentNameException(string name)
                : base(String.Format($"Invalid student name: {name}."))
            {

            }
        }
    }
}