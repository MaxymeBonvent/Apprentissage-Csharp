// 47. BUILT-IN EXCEPTION CLASSES

namespace Lesson47
{
    class Program47
    {
        // public static void Main()
        // {
        //     /*
        //         Here you will learn about the built-in exception classes in C#.

        //         C# .NET includes built-in exception classes for every possible error.
        //         The Exception class is the base class of all the exception classes. 

        //         In the above figure, the Exception class is the base class of the 
        //         SystemException and ApplicationException classes. 
        //         The SystemException class is the base class for all the built-in exception 
        //         classes in .NET Framework. 
        //     */

        //     /*
        //         The ApplicationException was recommended to be base class for all your custom 
        //         exceptions classes (The custom exeception class should be created if non of 
        //         the system exception classes can be used and you need new exception class for 
        //         business rule violations or for other application related errors). 
        //         It was meant to differentiates between exceptions defined by applications 
        //         versus exceptions defined by the system. 
        //         However, Microsoft now recommends to derive custom exception classes from the 
        //         Exception class rather than the ApplicationException class.
        //     */

        //     /*
        //         BUILT-IN EXCEPTION CLASSES

        //         The following table lists important built-in exception classes in .NET:

        //         Exception Class	                Description
        //         ArgumentException	            Raised when a non-null argument that is passed to a method is invalid.
        //         ArgumentNullException	        Raised when null argument is passed to a method.
        //         ArgumentOutOfRangeException	    Raised when the value of an argument is outside the range of valid values.
        //         DivideByZeroException	        Raised when an integer value is divided by zero.
        //         FileNotFoundException	        Raised when a physical file does not exist at the specified location.
        //         FormatException	                Raised when a value is not in an appropriate format to be converted from a string by a conversion method such as Parse.
        //         IndexOutOfRangeException	    Raised when an array index is outside the lower or upper bounds of an array or collection.
        //         InvalidOperationException	    Raised when a method call is invalid in an object's current state.
        //         KeyNotFoundException	        Raised when the specified key for accessing a member in a collection does not exist.
        //         NotSupportedException	        Raised when a method or operation is not supported.
        //         NullReferenceException	        Raised when program access members of null object.
        //         OverflowException	            Raised when an arithmetic, casting, or conversion operation results in an overflow.
        //         OutOfMemoryException	        Raised when a program does not get enough memory to execute the code.
        //         StackOverflowException	        Raised when a stack in memory overflows.
        //         TimeoutException	            Raised when the time interval allotted to an operation has expired.
        //     */

        //     /*
        //         When an error occurs, either the application code or the default handler 
        //         handles the exception.
        //     */
        // }
    }
}