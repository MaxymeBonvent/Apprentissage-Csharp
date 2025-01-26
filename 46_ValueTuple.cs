// 46. VALUETUPLE

namespace Lesson46
{
    class Program46
    {
        // public static void Main()
        // {
        //     /*
        //         C# 7.0 (.NET Framework 4.7) introduced the ValueTuple structure, which is a 
        //         value type representation of the Tuple.

        //         The ValueTuple is only available in .NET Framework 4.7. If you don't see 
        //         ValueTuple in your project, then you need to install the ValueTuple. 
        //         (.NET Framework 4.7 or higher, or .NET Standard Library 2.0 or higher already 
        //         includes ValueTuple.)

        //         To install the ValueTuple package, right-click on the project in the solution 
        //         explorer and select Manage NuGet Packages... This will open the NuGet Package 
        //         Manager. Click the Browse tab, search for ValueTuple in the search box, and 
        //         select the System.ValueTuple package, as shown below.

        //         Link : https://www.nuget.org/packages/system.valuetuple/
        //         Install Command : dotnet add package System.ValueTuple --version 4.5.0
        //     */

        //     /*
        //         VALUETUPLE INITIALIZATION

        //         It is easy to create and initialize the ValueTuple. 
        //         It can be created and initialized using parentheses () and specifying the 
        //         values in it.
        //     */

        //     var person = (1, "Bill", "Gates");
        //     Console.WriteLine($"person == {person}.\nType of person == {person.GetType()}.\n");

        //     /*
        //         The ValueTuple can also be initialized by specifying the type of each 
        //         element, as shown below.
        //     */
            
        //     (int, string, string) person2 = (1, "John", "Though");
        //     Console.WriteLine($"person2.Item1 == {person2.Item1}.");
        //     Console.WriteLine($"person2.Item2 == {person2.Item2}."); 
        //     Console.WriteLine($"person2.Item3 == {person2.Item3}.");

        //     Console.WriteLine("\n");

        //     // The following is a short way of declaring types for each member.

        //     (int, string, string) person3 = (2, "Elton", "Jons");
        //     Console.WriteLine($"person3.Item1 == {person3.Item1}.");
        //     Console.WriteLine($"person3.Item2 == {person3.Item2}."); 
        //     Console.WriteLine($"person3.Item3 == {person3.Item3}.");

        //     Console.WriteLine("\n");

        //     /*
        //         Note that we have not used var in the above tuple initialization statement; 
        //         instead, we provided the type of each member values inside the brackets.

        //         Tuple requires at least two values. The following is not a tuple.
        //     */

        //     var nb = (1);
        //     Console.WriteLine($"Type of nb == {nb.GetType()}.");

        //     var nb1 = (1,2);
        //     Console.WriteLine($"Type of nb1 == {nb1.GetType()}.\n");


        //     // Unlike Tuple, a ValueTuple can include more than eight values.

        //     var nb2 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
        //     Console.WriteLine($"Type of nb2 == {nb2.GetType()}.\n");

        //     /*
        //         NAMED MEMBERS

        //         We can assign names to the ValueTuple properties instead of having the 
        //         default property names like Item1, Item2, etc.
        //     */

        //     (int Id, string FirstName, string LastName) person4 = (4, "Mistigrix", "Matou");
        //     Console.WriteLine($"person4 == {person4}.\n");

        //     // We can also assign member names on the right side with values, as below.

        //     var person5 = (ID: 5, FirstName: "Ash", LastName: "Ketchum");
        //     Console.WriteLine($"person5 == {person5}.\n");

        //     /*  
        //         Please note that we can provide member names either on the left or right 
        //         sides but not on both sides. 
        //         The left side has precedence over the right side. 
        //         The following will ignore names on the right side.
        //     */

        //     // PersonId, FName, LName will be ignored.
        //     (int Id, string FirstName, string LastName) person7 = (PersonId: 7, FName: "Alan", LName: "Turing");
        //     Console.WriteLine($"person7 == {person7}.");

        //     // PersonId, FirstName, LastName will be ignored. It will have the default names: Item1, Item2, Item3.
        //     (int, string, string) person8 = (PersonId: 8, FName:"Falco", LName: "Starfox");
        //     Console.WriteLine($"person8 == {person8}.\n");

        //     // We can also assign variables as member values.

        //     string firstName = "Fox", lastName = "Starfox";
        //     var person9 = (FirstName: firstName, LastName: lastName);
        //     Console.WriteLine($"person9 == {person9}.\n");

        //     /*
        //         VALUETUPLE AS PARAMETER

        //         The ValueTuple can also be a parameter type or return type of a method. 
        //         The following method accepts a ValueTuple type parameter.
        //     */

        //     DisplayTuple((10, "Wolf", "Starwolf"));
            
        //     // The following returns a ValueTuple from the method.
        //     GetPerson((11, "Link", "Hylia"));

        //     // You can also specify member names for a ValueTuple returned from the method.
        //     GetPersonB((12, "Zelda", "Hylia"));

        //     /*
        //         DECONSTRUCTION

        //         Individual members of a ValueTuple can be retrieved by deconstructing it. 
        //         A deconstructing declaration syntax splits a ValueTuple into its parts and 
        //         assigns those parts individually to fresh variables.
        //     */

        //     // Change property names
        //     (int PersonId, string FName, string LName) = GetPersonC();

        //     // We can also use var instead of explicit data type names.
        //     (var PersonId2, var FName2, var LName2) = GetPersonC();

        //     /*
        //         ValueTuple also allows "discards" in deconstruction for the members you are 
        //         not going to use.
        //     */
            
        //     // Use discard _ for the unused member LName
        //     (var id, var FName3, _) = GetPersonC(); 

        // }
        // Method
        // static (int, string, string) GetPersonC() 
        // {
        //     return (Id:1, FirstName: "Bill", LastName: "Gates");
        // }

        // Method with a ValueTuple, using custom member names, return type
        static (int id, string firstName, string lastName) GetPersonB((int, string, string) person)
        {
            Console.WriteLine($"person == {person}.\n");
            return person;
        }


        // Method with a ValueTuple return type
        static (int, string, string) GetPerson((int, string, string) person) 
        {
            Console.WriteLine($"person == {person}.\n");
            return person;
        }


        // Method with a ValueTuple parameter
        static void DisplayTuple((int, string, string) person)
        {
            Console.WriteLine($"person == {person}.\n");
        }
    }
}