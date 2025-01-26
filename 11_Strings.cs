// 11. STRINGS

namespace Lesson11
{
    class Program11
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, a string is a series of characters that is used to represent text. 
        //         It can be a character, a word or a long passage surrounded with the double 
        //         quotes ". The following are string literals.
        //     */

        //     /*
        //         "S"
        //         "String"
        //         "This is a string"
        //     */

        //     /*
        //     C# provides the String data type to store string literals. A variable of the 
        //     string type can be declared and assign string literal, as shown below.
        //     */

        //     string ch = "S";
        //     Console.WriteLine("ch = " + ch);

        //     string word = "String";
        //     Console.WriteLine("word = " + word);

        //     string text = "This is a string";
        //     Console.WriteLine("text = " + text);

        //     /*
        //         The maximum size of a String object in memory is 2GB or about 1 billion 
        //         characters. However, practically it will be less depending upon CPU and 
        //         memory of the computer.

        //         There two ways to declare a string variable in C#. Using System.String class 
        //         and using string keyword. Both are the same and make no difference.
        //     */

        //     string str1 = "hello"; // Uses string keyword
        //     Console.WriteLine("str1 = " + str1 + ". Type of str1 = " + str1.GetType());
 
        //     String str2 = "hello"; // Uses System.String class
        //     Console.WriteLine("str2 = " + str2 + ". Type of str2 = " + str2.GetType());

        //     /*
        //         In C#, a string is a collection or an array of characters. So strings can be 
        //         created using a char array or accessed like a char array.
        //     */

        //     char[] chars = {'H','e','l','l','o'};
        //     Console.WriteLine("chars = " + chars);

        //     string str3 = new string(chars); 
        //     Console.WriteLine("str3 = " + str3);

        //     String str4 = new String(chars); 
        //     Console.WriteLine("str4 = " + str4);

        //     foreach (char c in str3)
        //     {
        //         Console.WriteLine("Character from str3 = " + c);
        //     }

        //     /*
        //         SPECIAL CHARACTERS

        //         A text in the real world can include any character. In C#, because a string 
        //         is surrounded with double quotes, it cannot include " in a string. The 
        //         following will give a compile-time error.
        //     */

        //     // string text = "This is a "string" in C#.";

        //     /*
        //         C# includes escaping character \ (backslash) before these special characters 
        //         to include in a string.

        //         Use backslash \ before double quotes and some special characters such as 
        //         \,\n,\r,\t, etc. to include it in a string.
        //     */

        //     // string text = "This is a "string" in C#.";

        //     string str = "xyzdef\rtest";
        //     Console.WriteLine("str = " + str);

        //     string path = "\\mypc\\ shared\\project";
        //     Console.WriteLine("path = " + path);

        //     /*
        //         VERBATIM STRINGS

        //         It's tedious to prefix \ to include every special characters. 
        //         Verbatim string in C# allows a special characters and line breaks. 
        //         Verbatim string can be created by prefixing @ symbol before double quotes.
        //     */

        //     string str5 = "xyzdefabc";
        //     Console.WriteLine("str5 = " + str5);

        //     string path2 = @"\mypcsharedproject";
        //     Console.WriteLine("path2 = " + path2);

        //     string email = "test@test.com";
        //     Console.WriteLine("email = " + email);

        //     // The @ symbol can also be used to declare a multi-line string.

        //     // Pseudo-multiline string
        //     string str7 = "this is a " 
        //     + 
        //     "multiline " 
        //     + 
        //     "string";
        //     Console.WriteLine("str7 = " + str7);
                    
        //     // Verbatim string, true multiline string
        //     string str8 = @"this is 
        //     a multiline 
        //     string";
        //     Console.WriteLine("str8 = " + str8);

        //     /*
        //         Please note that you cannot use a backslash to allow " in a verbatim string. 
        //         If you wish to include @, use double double-quotes "" to include " in a 
        //         verbatim string.
        //     */

        //     string text2 = "This is a \"string\" in C#.";
        //     Console.WriteLine("text2 = " + text2);

        //     // string text3 = @"This is a "string." in C#.";
        //     // string text4 = @"This is a "string" in C#.";

        //     string text5 = @"This is a ""string"" in C#.";
        //     Console.WriteLine("text5 = " + text5);

        //     /*
        //         STRING CONCATENATION

        //         // Multiple strings can be concatenated with the "+" operator.
        //     */

        //     string name = "Mr." + "James " + "Bond" + ", Code: 007";
        //     Console.WriteLine("name = " + name);
 
        //     string firstName = "James";
        //     string lastName = "Bond";
        //     string code = "007";
            
        //     string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;
        //     Console.WriteLine("agent = " + agent);

        //     /*
        //         A String is immutable in C#. It means it is read-only and cannot be changed 
        //         once created in the memory. Each time you concatenate strings, .NET CLR will 
        //         create a new memory location for the concatenated string. So, it is 
        //         recommended to use StringBuilder instead of string if you concatenate more 
        //         than five strings.

        //         STRING INTERPOLATION

        //         String interpolation is a better way of concatenating strings. We use the "+" 
        //         sign to concatenate string variables with static strings.

        //         C# 6 includes a special character "$" to identify an interpolated string. 
        //         An interpolated string is a mixture of fixed string and string variable 
        //         where string variables should be in brackets.
        //     */

        //     string firstName2 = "James";
        //     string lastName2 = "Bond";
        //     string code2 = "007";
            
        //     string fullName2 = $"Mr. {firstName2} {lastName2}, Code: {code2}";
        //     Console.WriteLine($"fullName2 = {fullName2}");

        //     /*
        //         In the above example of interpolation, "$" indicates the interpolated string, 
        //         and includes string variables to be incorporated with a string.

        //         Use two braces, {{ or }} to include { or } in an interpolated string.
        //     */

        //     string curly = $"Numbers in the interval {{0, 10}}";
        //     Console.WriteLine($"curly = {curly}");
        // }
    }
}