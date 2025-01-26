// 49. THROW KEYWORD 

namespace Lesson49
{
    class Program49
    {
        // public static void Main()
        // {
        //     /*
        //        We have seen in the previous section how to handle exceptions which are 
        //        automatically raised by CLR (Common Language Runtime). 
        //        Here, we will see how to raise an exception manually.

        //         An exception can be raised manually by using the throw keyword. 
        //         Any type of exceptions which is derived from Exception class can be raised 
        //         using the throw keyword.
        //     */

        //     Student? std = new()
        //     {
        //         name = "a"
        //     };

        //     try
        //     {
        //         if(std != null)
        //         {
        //             PrintStudentName(std);
        //         }
        //     }

        //     catch(Exception ex)
        //     {
        //         Console.WriteLine($"Exception caught:{ex.Message}\n");
        //     }                      

        //     Console.ReadKey();

        //     /*
        //         In the above example, PrintStudentName() method raises NullReferenceException 
        //         if Student object is null.

        //         Please notice that throw creates an object of any valid exception type using 
        //         the new keyword. The throw keyword cannot be used with any other type which 
        //         does not derive from the Exception class.
        //     */

        //     /*
        //         RE-THROWING AN EXCEPTION

        //         You can also re-throw an exception from the catch block to pass on to the 
        //         caller and let the caller handle it the way they want. 
        //         The following example re-throws an exception.
        //     */

        //     try
        //     {
        //         Method1();
        //     }

        //     catch(Exception ex)
        //     {
        //         Console.WriteLine($"Exception caught:{ex.Message}");
        //     }

        //     /*
        //         In the above example, an exception occurs in Method2(). 
        //         The catch block simply throws that exception using only throw keyword 
        //         (not throw e). This will be handled in catch block in Method1() where it 
        //         again re-throw the same exception and finally it is being handled in the 
        //         Main() method. The stack trace of this exception will give you the full 
        //         detail of where exactly this exception occurred.
        //     */

        //     /*
        //         If you re-throw an exception using exception parameter then it will not 
        //         preserve the original exception and creates a new exception. 
        //         The following example demonstrates this.
        //     */

        //     try
        //     {
        //         Method3();
        //     }

        //     catch(Exception ex)
        //     {
        //         Console.WriteLine($"Exception caught:{ex.Message}");
        //     }    

        //     /*
        //         In the above example, exception caught in the Main() method will display 
        //         stack trace from Method3 and Main method. It will not display Method3 in 
        //         stack trace as we re-throw exception in Method3() using throw ex. So, never 
        //         throw an exception using throw <exception parameter>.
        //     */
        // }

        static void Method3()
        {
            try
            {
                Method2();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception caught:{ex.Message}");
            } 
        }

        static void Method4()
        {
            string? str = null;
            try
            {
                if(str != null)
                {
                    Console.WriteLine($"str == {str}.");
                }
                
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Exception caught:{ex.Message}");
            } 
        }

        static void Method1()
        {
            try
            {
                Method2();
            }

            catch(Exception ex)
            {
                throw new Exception($"Exception caught:{ex.Message}");
            } 
        }

        static void Method2()
        {
            string? str = null;

            try
            {
                if(str != null)
                {
                    Console.WriteLine($"str == {str}");
                }

                else
                {
                    Console.WriteLine("str is null.");
                }
            }

            catch(Exception ex)
            {
                throw new Exception($"Exception caught:{ex.Message}");
            } 
        }

        private static void PrintStudentName(Student std)
        {
            if (std == null)
            {
                throw new NullReferenceException("Student object is null.");
            }
                
            Console.WriteLine($"std.name == {std.name}.\n");
        }

        class Student
        {
            public string? name = default;
        }
    }
}