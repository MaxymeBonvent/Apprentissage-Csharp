// 15. STRINGBUILDER

using System.Text;

namespace Lesson15
{
    class Program15
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, the string type is immutable. It means a string cannot be changed once 
        //         created. For example, a new string, "Hello World!" will occupy a memory space 
        //         on the heap. Now, changing "Hello World!" to "Hello World! 
        //         from Tutorials Teacher" will create a new string object on the memory heap 
        //         instead of modifying an original string at the same memory address. 
        //         This behavior can hinder performance if the original string is changed 
        //         multiple times by replacing, appending, removing, or inserting new strings to 
        //         the original string.  

        //         To solve this problem, C# introduced the StringBuilder in the System.Text 
        //         namespace. The StringBuilder doesn't create a new object in the memory but 
        //         dynamically expands memory to accommodate the modified string.

        //         CREATING A STRINGBUILDER OBJECT

        //         You can create an object of the StringBuilder class using the "new" keyword and 
        //         passing an initial string. The following example demonstrates creating 
        //         StringBuilder objects.
        //     */

        //     StringBuilder sb = new();
        //     Console.WriteLine($"sb = {sb}. Type of sb = {sb.GetType()}.");

        //     StringBuilder sb2 = new("Hello, world.");
        //     Console.WriteLine($"sb2 = {sb2}.");

        //     /*
        //         Optionally, you can also specify the maximum capacity of the StringBuilder 
        //         object using overloaded constructors, as shown below.
        //     */

        //     StringBuilder sb3 = new(50);
        //     Console.WriteLine($"sb3 = {sb3}.");
            
        //     StringBuilder sb4 = new("Hello World", 50);
        //     Console.WriteLine($"sb4 = {sb4}. Type of sb4 = {sb4.GetType()}.");

        //     /*
        //         Above, C# allocates a maximum of 50 spaces sequentially on the memory heap. 
        //         This capacity will automatically be doubled once it reaches the specified 
        //         capacity. You can also use the capacity or length property to set or retrieve 
        //         the StringBuilder object's capacity.

        //         You can iterate a for loop to get or set a character at the 
        //         specified index.
        //     */

        //     StringBuilder sb5 = new("Hello World");

        //     for(int i = 0; i < sb5.Length; i++)
        //     {
        //         Console.Write(sb5[i]);
        //     }

        //     /*
        //         RETRIEVE STRING FROM STRINGBUILDER

        //         A StringBuilder is not a string. Use the ToString() method to retrieve a 
        //         string from a StringBuilder object.
        //     */

        //     StringBuilder sb6 = new("Hello World");

        //     var greet = sb6.ToString();
        //     Console.WriteLine($"\ngreet = {greet}. Type of greet = {greet.GetType()}.");

        //     /*
        //         ADD/APPEND STRING TO STRINGBUILDER

        //         Use the Append() method to append a string to the end of the current 
        //         StringBuilder object. If a StringBuilder does not contain any string yet, it 
        //         will add that string it. The AppendLine() method appends a string with the 
        //         newline character at the end.
        //     */
            
        //     StringBuilder sb7 = new();

        //     sb7.Append("Hello ");
        //     sb7.AppendLine("World");
        //     sb7.AppendLine("Hello C#");

        //     Console.WriteLine($"sb7 = {sb7}.");

        //     /*
        //         APPEND FORMATED STRING TO STRINGBUILDER

        //         Use the AppendFormat() method to format an input string into the specified 
        //         format and append it.
        //     */

        //     StringBuilder sbAmount = new ("Your total amount is : ");
        //     sbAmount.AppendFormat("{0:C}.", 25); // {0:C} uses local currency

        //     Console.WriteLine($"sbAmount = {sbAmount}");

        //     /*
        //         INSERT STRING INTO STRINGBUILDER

        //         Use the Insert() method to insert a string at the specified index in the 
        //         StringBuilder object.
        //     */

        //     StringBuilder sb8 = new("Hello World");
        //     sb8.Insert(5," za"); 

        //     Console.WriteLine($"sb8 = {sb8}");

        //     /*
        //         REMOVE STRING FROM STRINGBUILDER

        //         Use the Remove() method to remove a string from the specified index and up to 
        //         the specified length.
        //     */

        //     StringBuilder sb9 = new ("Hello World!");
        //     sb9.Remove(0, 2);

        //     Console.WriteLine($"sb9 = {sb9}");

        //     /*
        //         REPLACE STRING IN STRINGBUILDER

        //         Use the Replace() method to replace all the specified string occurrences with 
        //         the specified replacement string.
        //     */

        //         StringBuilder sb10 = new("The blue bird flies across the blue sky above the blue sea on this blue planet.");

        //         Console.WriteLine($"sb10 = {sb10}");

        //         sb10.Replace("blue", "green");

        //         Console.WriteLine($"sb10 = {sb10}");
        // }
    }
}