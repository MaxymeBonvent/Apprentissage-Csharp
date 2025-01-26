// 31. ARRAYS

namespace Lesson31
{
    class Program31
    {
        // public static void Main()
        // {
        //     /*
        //         A variable is used to store a literal value, whereas an array is used to 
        //         store multiple literal values.

        //         An array is the data structure that stores a fixed number of literal values 
        //         (elements) of the same data type. Array elements are stored contiguously in 
        //         the memory.

        //         In C#, an array can be of three types: single-dimensional, multidimensional, 
        //         and jagged array. Here you will learn about the single-dimensional array.
        //     */

        //     /*
        //         ARRAY DECLARATION AND INITIALIZATION

        //         An array can be declared using by specifying the type of its elements with 
        //         square brackets.
        //     */

        //     // int[] evenNbs;
        //     // string[] cities;

        //     // The following declares and adds values into an array in a single statement.

        //     int[] evenNbs2 = new int[5]{2, 4, 6, 8, 10}; 
        //     Console.WriteLine($"evenNbs2 = {evenNbs2}.");

        //     string[] cities2 = new string[3]{"Mumbai", "London", "New York"};
        //     Console.WriteLine($"cities2 = {cities2}.");

        //     Console.WriteLine("\n");

        //     /*
        //         Above, evenNums array can store up to five integers. 
        //         The number 5 in the square brackets new int[5] specifies the size of an array. In the same way, the size of cities array is three. Array elements are added in a comma-separated list inside curly braces .

        //         Arrays type variables can be declared using var without square brackets.
        //     */

        //     var evenNbs3 = new int[]{2, 4, 6, 8, 10}; 
        //     Console.WriteLine($"evenNbs3 = {evenNbs3}.");

        //     var cities3 = new string[]{"Mumbai", "London", "New York"};
        //     Console.WriteLine($"cities3 = {cities3}.");

        //     Console.WriteLine("\n");

        //     /*
        //         If you are adding array elements at the time of declaration, then size is 
        //         optional. The compiler will infer its size based on the number of elements 
        //         inside curly braces, as shown below.
        //     */

        //     int[] evenNbs4 = {2, 4, 6, 8, 10};
        //     Console.WriteLine($"evenNbs4 = {evenNbs4}.");

        //     string[] cities4 = {"Mumbai", "London", "New York"};
        //     Console.WriteLine($"cities4 = {cities4}.");

        //     Console.WriteLine("\n");

        //     /*
        //         The following examples demonstrate invalid array declarations.

        //         int[] evenNums5 = new int[];
        //         Compiler Error CS1586 : 
        //         Array creation must have array size or array initializer.

        //         int[] evenNums6 = new int[4] {2, 4};
        //         Compiler Error CS0847 : An array initializer of length '{0}' is expected.

        //         var evenNums7 = {2, 4, 6, 8, 10};
        //         Compiler Error CS0820 : 
        //         Cannot assign array initializer to an implicitly typed local.
        //     */

        //     /*
        //         LATE INITIALIZATION

        //         It is not necessary to declare and initialize an array in a single statement. 
        //         You can first declare an array then initialize it later on using the new 
        //         operator.
        //     */

        //     int[] evenNums8;
        //     evenNums8 = new int[5];
        //     evenNums8 = new int[]{ 2, 4, 6, 8, 10 };
        //     Console.WriteLine($"evenNums8 = {evenNums8}.");

        //     Console.WriteLine("\n");

        //     /*
        //         ACCESSING ARRAY ELEMENTS

        //         Array elements can be accessed using an index. 
        //         An index is a number associated with each array element, starting with 
        //         index 0 and ending with (array size - 1).

        //         The following examples add/update and retrieve array elements using indexes.
        //     */

        //     int[] evenNums9 = new int[5];

        //     evenNums9[0] = 92;
        //     evenNums9[1] = 4;
        //     /*
        //         evenNums9[6] = 12;
        //         Unhandled exception. 
        //         System.IndexOutOfRangeException: Index was outside the bounds of the array.
        //     */

        //     Console.WriteLine($"evenNums9[0] = {evenNums9[0]}.");
        //     Console.WriteLine($"evenNums9[1] = {evenNums9[1]}.");

        //     Console.WriteLine("\n");

        //     /*
        //         Note that trying to add more elements than its specified size will result in 
        //         IndexOutOfRangeException.
        //     */

        //     /*
        //         ACCESSING AN ARRAY USING A FOR LOOP

        //         Use a for loop to access array elements. 
        //         Use the length property of an array in the condition of the for loop.
        //     */

        //     int[] evenNums10 = {2, 4, 6, 8, 10};

        //     for(int i = 0; i < evenNums10.Length; i++)
        //     {
        //         Console.WriteLine($"evenNums10[{i}] {evenNums10[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     for(int i = 0; i < evenNums10.Length; i++)
        //     {
        //         evenNums10[i] += 10;
        //         Console.WriteLine($"evenNums10[{i}] {evenNums10[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //        ACCESSING AN ARRAY USING A FOREACH LOOP

        //        Use a foreach loop to read values of an array without using an index. 
        //     */

        //     int[] evenNums11 = {2, 4, 6, 8, 10}; 
        //     string[] cities = {"Mumbai", "London", "New York"}; 

        //     foreach(int num in evenNums11)
        //     {
        //         Console.WriteLine($"num = {num}.");
        //     }

        //     Console.WriteLine("\n");

        //     foreach(string city in cities)
        //     {
        //         Console.WriteLine($"city = {city}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         LINQ METHODS

        //         All arrays in C# are derived from an abstract base class System.Array.

        //         The Array class implements the IEnumerable interface, so you can use LINQ 
        //         extension methods such as Max(), Min(), Sum(), Reverse(), etc.
        //     */

        //     int[] nums = new int[5]{10, 15, 16, 8, 6};

        //     Console.WriteLine($"nums.Max = {nums.Max()}.");
        //     Console.WriteLine($"nums.Min = {nums.Min()}.");
        //     Console.WriteLine($"nums.Sum = {nums.Sum()}.");
        //     Console.WriteLine($"nums.Average = {nums.Average()}.");
        //     Console.WriteLine($"nums.Reverse = {nums.Reverse()}.");

        //     Console.WriteLine("\n");

        //     /*
        //         The System.Array class also includes methods for creating, manipulating, 
        //         searching, and sorting arrays. See a list of all Array methods here.
        //     */

        //     int[] nums2 = new int[5]{10, 15, 16, 8, 6};
        //     Console.WriteLine("Initial array :");

        //     for(int i = 0; i < nums2.Length; i++)
        //     {
        //         Console.Write($"{nums2[i]} ");
        //     }
        //     Console.WriteLine("\n");


        //     // Sorts in ascending order by default
        //     Array.Sort(nums2);
        //     Console.WriteLine("After sorting :");
        //     for(int i = 0; i < nums2.Length; i++)
        //     {
        //         Console.Write($"{nums2[i]} ");
        //     }
        //     Console.WriteLine("\n");

        //     Array.Reverse(nums2);
        //     Console.WriteLine("After reversing :");
        //     for(int i = 0; i < nums2.Length; i++)
        //     {
        //         Console.Write($"{nums2[i]} ");
        //     }
        //     Console.WriteLine("\n");

        //     Console.WriteLine("After Array.ForEach :");
        //     Array.ForEach(nums2, n => Console.Write($"{n} "));
        //     Console.WriteLine("\n");

        //     Array.BinarySearch(nums2, 5);
        //     Console.WriteLine("After Array.BinarySearch :");
        //     for(int i = 0; i < nums2.Length; i++)
        //     {
        //         Console.Write($"{nums2[i]} ");
        //     }
        //     Console.WriteLine("\n");

        //     /*
        //         PASSING AN ARRAY AS AN ARGUMENT

        //         An array can be passed as an argument to a method parameter. 
        //         Arrays are reference types, so the method can change the value of the array 
        //         elements.
        //     */

        //     int[] nums3 = {1, 2, 3, 4, 5};

        //     Console.WriteLine($"Initial array :");

        //     for(int i = 0; i < nums3.Length; i++)
        //     {
        //         Console.Write($"{nums3[i]} ");
        //     }

        //     Console.WriteLine("\n");

        //     UpdateArray(nums3);

        //     Console.WriteLine($"After update :");

        //     for(int i = 0; i < nums3.Length; i++)
        //     {
        //         Console.Write($"{nums3[i]} ");
        //     }
        // }

        public static void UpdateArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            arr[i] += 10;   
        }
    }
}