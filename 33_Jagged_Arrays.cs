// 33. JAGGED ARRAYS

namespace Lesson33
{
    class Program33
    {
        // public static void Main()
        // {
        //     /*
        //         A jagged array is an array of array. Jagged arrays store arrays instead of 
        //         literal values.

        //         A jagged array is initialized with two square brackets [][]. 
        //         The first bracket specifies the size of an array, and the second bracket 
        //         specifies the dimensions of the array which is going to be stored.

        //         The following example declares jagged arrays.
        //     */

        //     int[][] jgArr1 = new int[2][];
        //     int[][,] jgArr2 = new int[3][,];

        //     /*
        //         In the above example, jgArr1 can store up to two single-dimensional arrays. 
        //         jgArr2 can store up to three two-dimensional arrays. [,] specifies the 
        //         two-dimensional array.
        //     */

        //     int[][] jgArr3 = new int[2][]; 

        //     jgArr3[0] = new int[3]{1, 2, 3};

        //     jgArr3[1] = new int[4]{4, 5, 6, 7 };

        //     // You can also initialize a jagged array upon declaration like below.

        //     int[][] jgArr4 = new int[2][]
        //     {
        //         new int[3]{1, 2, 3},

        //         new int[4]{4, 5, 6, 7}
        //     };

        //     // You can access a jagged array using two for loops, as shown below.

        //     int[][] jgArr5 = new int[2][]
        //     {
        //         new int[3]{1, 2, 3},

        //         new int[4]{4, 5, 6, 7}
        //     };

        //     for(int i = 0; i < jgArr5.Length; i++)
        //     {
        //         for(int j = 0; j < (jgArr5[i]).Length; j++)
        //         {
        //             Console.WriteLine($"jgArr5[{i}][{j}] = {jgArr5[i][j]}.");
        //         }
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         The following jagged array stores two-dimensional arrays where the second 
        //         bracket [,] indicates the two-dimensional array.
        //     */

        //     int[][,] jgArr6 = new int[2][,];

        //     jgArr6[0] = new int[3, 2] 
        //     { 
        //         {1, 2}, {3, 4}, {5, 6} 
        //     };

        //     jgArr6[1] = new int[2, 2] 
        //     { 
        //         {7, 8}, {9, 10} 
        //     };

        //     // If you add one more bracket then it will be array of array of array.

        //     int[][][] jgArr7 = new int[2][][] 
        //     {
        //         new int[2][]  
        //         { 
        //             new int[3] {1, 2, 3},
        //             new int[2] {4, 5} 
        //         },

        //         new int[1][]
        //         { 
        //             new int[3] {7, 8, 9}
        //         }
        //     };

        //     Console.WriteLine($"jgArr7[0][0][0] = {jgArr7[0][0][0]}.");
        //     Console.WriteLine($"jgArr7[0][1][1] = {jgArr7[0][1][1]}.");
        //     Console.WriteLine($"jgArr7[1][0][2] = {jgArr7[1][0][2]}.");

        //     Console.WriteLine("\n");

        //     /*
        //         In the above example of a jagged array, three brackets [][][] means an array 
        //         of array of array. So, jgArr7 will contain two elements, which means 
        //         two arrays. Now, each of these arrays also contains two arrays. 
        //         jgArr7[0][0][0] points to the first element of first inner array of the first sub-array. 
        //         jgArr7[1][0][2] points to the third element of the first inner array of the second sub-array. 
        //     */
        // }
    }
}