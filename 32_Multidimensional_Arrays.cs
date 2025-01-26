// 32. MULTIDIMENSIONAL ARRAYS

namespace Lesson32
{
    class Program32
    {
        // public static void Main()
        // {
        //     /*
        //         C# supports multidimensional arrays up to 32 dimensions. 
        //         The multidimensional array can be declared by adding commas in the square 
        //         brackets. For example, 
        //         [,] declares a two-dimensional array, 
        //         [, ,] declares a three-dimensional array, 
        //         [, , ,] declares a four-dimensional array, and so on. 
        //         So, in a multidimensional array, n° of commas = n° of dimensions - 1.

        //         The following declares multidimensional arrays.  
        //     */

        //     // int[,] arr2d;
        //     // int[, ,] arr3d;
        //     // int[, , ,] arr4d;
        //     // int[, , , ,] arr5d;

        //     /*
        //         Let's understand two-dimensional arrays. 
        //         The following initializes a two-dimensional array.
        //     */

        //     int[,] arr2dA = new int[3,2] {{1, 2}, {3, 4}, {5, 6}};
        //     Console.WriteLine($"arr2dA = {arr2dA}.");

            
        //     int[,] arr2dB = {{1, 2}, {3, 4}, {5, 6}};
        //     Console.WriteLine($"arr2dB = {arr2dB}.");

        //     Console.WriteLine("\n");

        //     /*
        //         In the above example of a two-dimensional array [3, 2], the first number 
        //         defines the number of groups, and the second number defines the number of
        //         elements in each group.
        //     */

        //     //The following accesses values of a two-dimensional array.

        //     int[,] arr2dC = new int[3,2] {{1, 2}, {3, 4}, {5, 6}};

        //     Console.WriteLine($"arr2dC[0, 0] = {arr2dC[0, 0]}.");
        //     Console.WriteLine($"arr2dC[0, 1] = {arr2dC[0, 1]}.");
        //     Console.WriteLine($"arr2dC[1, 0] = {arr2dC[1, 0]}.");
        //     Console.WriteLine($"arr2dC[1, 1] = {arr2dC[1, 1]}.");
        //     Console.WriteLine($"arr2dC[2, 0] = {arr2dC[2, 0]}.");
        //     Console.WriteLine($"arr2dC[2, 1] = {arr2dC[2, 1]}.");

        //     Console.WriteLine("\n");

        //     /*
        //         In the above example, the value of a two-dimensional array can be accessed by 
        //         group index and element as [group index, elemnt index]. So, [0, 0] returns 
        //         the value of the first group and first element and [1, 1] returns the value 
        //         from the second group and second element.

        //         Now, let's understand the three-dimensional array. The following declares and 
        //         initializes three-dimensional arrays.
        //     */

        //     int[, ,] arr3dA = new int[1, 2, 2]
        //     {
        //         {{1, 2}, {3, 4}}
        //     };

        //     int[, ,] arr3dB = new int[2, 2, 2]
        //     {
        //         {{1, 2}, {3, 4}}, {{5, 6}, {7, 8}}
        //     };

        //     int[, ,] arr3dC = new int[2, 2, 3]
        //     {
        //         {{1, 2, 3}, {4, 5, 6}}, {{7, 8, 9}, {10, 11, 12}}
        //     };

        //     Console.WriteLine($"arr3dA[0, 0, 0] = {arr3dA[0, 0, 0]}.");

        //     Console.WriteLine("\n");

        //     /*
        //         As you can see in the above example, [1, 2, 2] of arr3dA specifies that it
        //         will contain one group of two groups of two elements. arr3dB specifies 
        //         dimensions [2, 2, 2], which indicates that it includes two groups of 
        //         two groups of two elements. Thus, the first number indicates the number of 
        //         groups of groups.

        //         Now, consider the following four-dimensional array.
        //     */

        //     int[,,,] arr4dA = new int[1, 1, 2, 2]
        //     {
        //         { 
        //             {{1, 2}, {3, 4}}     
        //         }
        //     };

        //     int[,,,] arr4dB = new int[1, 2, 2, 2]
        //     {
        //             {
        //                 {{1, 2}, {3, 4}},
        //                 {{5, 6}, {7, 8}}
        //             }
        //     };

        //     Console.WriteLine($"arr4dA[0, 0, 0, 0] = {arr4dA[0, 0, 0, 0]}.");

        //     /*
        //         In the above example, the four-dimensional array arr4dA specifies 
        //         [1, 1, 2, 2], which indicates that it contains one group of one group of two 
        //         groups of two elements.

        //         In the same way, you can declare and initialize five-dimensional, 
        //         six-dimensional array, and up to 32-dimensional arrays in C#.
        //     */
        // }
    }
}