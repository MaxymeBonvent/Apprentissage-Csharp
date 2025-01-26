// 45. TUPLE

namespace Lesson45
{
    class Program45
    {
        // public static void Main()
        // {
        //     /*
        //         The Tuple<T> class was introduced in .NET Framework 4.0. (2010). 
        //         A tuple is a data structure that contains a sequence of elements of different 
        //         data types. It can be used where you want to have a data structure to hold an 
        //         object with properties, but you don't want to create a separate type for it.

        //         Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
        //         The following example creates a tuple with three elements:

        //         Tuple<int, string, string> person = 
        //         new Tuple <int, string, string>(1, "Steve", "Jobs");

        //         In the above example, we created an instance of the Tuple that holds a 
        //         person's record. We specified a type for each element and passed values to 
        //         the constructor. Specifying the type of each element is cumbersome. 
        //         C# includes a static helper class Tuple, which returns an instance of the 
        //         Tuple<T> without specifying each element's type, as shown below.

        //         var person = Tuple.Create(1, "Steve", "Jobs");
        //         A tuple can only include a maximum of eight elements. 
        //         It gives a compiler error when you try to include more than eight elements.

        //         var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
        //     */

        //     /*
        //         ACCESSING TUPLE ELEMENTS

        //         A tuple elements can be accessed with Item<elementNumber> properties, e.g., 
        //         Item1, Item2, Item3, and so on up to Item7 property. 
        //         The Item1 property returns the first element, Item2 returns the second 
        //         element, and so on. 
        //         The last element (the 8th element) will be returned using the Rest property.
        //     */

        //     Tuple<int, string, string> person = Tuple.Create(1, "Steve", "Jobs");
        //     Console.WriteLine($"person.Item1 == {person.Item1}.");
        //     Console.WriteLine($"person.Item2 == {person.Item2}."); 
        //     Console.WriteLine($"person.Item3 == {person.Item3}."); 

        //     Console.WriteLine("\n");

        //     var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
        //     Console.WriteLine($"numbers.Item1 == {numbers.Item1}.");
        //     Console.WriteLine($"numbers.Item2 == {numbers.Item2}.");
        //     Console.WriteLine($"numbers.Item3 == {numbers.Item3}.");
        //     Console.WriteLine($"numbers.Item4 == {numbers.Item4}.");
        //     Console.WriteLine($"numbers.Item5 == {numbers.Item5}.");
        //     Console.WriteLine($"numbers.Item6 == {numbers.Item6}.");
        //     Console.WriteLine($"numbers.Item7 == {numbers.Item7}.");
        //     Console.WriteLine($"numbers.Rest == {numbers.Rest}."); 
        //     Console.WriteLine($"numbers.Rest.Item1 == {numbers.Rest.Item1}.");

        //     Console.WriteLine("\n");
        //     /*
        //         Generally, the 8th position is for a nested tuple, which you can access 
        //         using the Rest property.
        //     */

        //     /*
        //         NESTED TUPLES

        //         If you want to include more than eight elements in a tuple, you can do that 
        //         by nesting another tuple object as the eighth element. 
        //         The last nested tuple can be accessed using the Rest property. 
        //         To access the nested tuple's element, use the 
        //         Rest.Item1.Item<elelementNumber> property.
        //     */

        //     var numbers2 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
        //     Console.WriteLine($"numbers2.Item1 == {numbers2.Item1}.");
        //     Console.WriteLine($"numbers2.Item7 == {numbers2.Item7}.");
        //     Console.WriteLine($"numbers2.Rest.Item1 == {numbers2.Rest.Item1}.");
        //     Console.WriteLine($"numbers2.Rest.Item1.Item1 == {numbers2.Rest.Item1.Item1}.");
        //     Console.WriteLine($"numbers2.Rest.Item1.Item2 == {numbers2.Rest.Item1.Item2}.");

        //     Console.WriteLine("\n");

        //     /*
        //         You can include the nested tuple object anywhere in the sequence. 
        //         However, it is recommended to place the nested tuple at the end of the 
        //         sequence so that it can be accessed using the Rest property.
        //     */

        //     var numbers3 = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7,  8), 9, 10, 11, 12, 13);
        //     Console.WriteLine($"numbers3.Item1 == {numbers3.Item1}.");
        //     Console.WriteLine($"numbers3.Item2 == {numbers3.Item2}.");
        //     Console.WriteLine($"numbers3.Item3 == {numbers3.Item3}.");
        //     Console.WriteLine($"numbers3.Item3.Item1 == {numbers3.Item3.Item1}.");
        //     Console.WriteLine($"numbers3.Item4 == {numbers3.Item4}.");
        //     Console.WriteLine($"numbers3.Rest.Item1 == {numbers3.Rest.Item1}.");

        //     Console.WriteLine("\n");

        //     /*
        //         TUPLE AS A METHOD PARAMETER

        //         A method can have a tuple as a parameter.
        //     */

        //     var person2 = Tuple.Create(2, "Madame", "Irma");
        //     DisplayTuple(person2);

        //     /*
        //         TUPLE AS A RETURN TYPE

        //         A Tuple can be returned from a method.
        //     */

        //     var person3 = GetPerson();

        //     /*
        //         USAGE OF TUPLE

        //         Tuples can be used in the following scenarios:

        //         1. When you want to return multiple values from a method without using ref or 
        //         out parameters.

        //         2. When you want to pass multiple values to a method through a single
        //          parameter.

        //         3. When you want to hold a database record or some values temporarily without 
        //         creating a separate class.
        //     */

        //     /*
        //         TUPLE LIMITATIONS:

        //         1. The Tuple is a reference type, not a value type. 
        //         It allocates on heap and could result in CPU-intensive operations.

        //         2. The Tuple is limited to include eight elements. 
        //         You need to use nested tuples if you need to store more elements. 
        //         However, this may result in ambiguity.

        //         3. The Tuple elements can be accessed using properties with a name pattern 
        //         Item<elementNumber>, which might not make sense.
        //     */
        // }

        // Method with a Tuple as a return type
        static Tuple<int, string, string> GetPerson() 
        {
            var personTuple = Tuple.Create(3, "Mr.", "Gaame&Watch");
            Console.WriteLine($"personTuple == {personTuple}.\n");

            return personTuple;
        }

        // Methods must be defined outside of Main(). Method with a Tuple as an argument
        static void DisplayTuple(Tuple<int,string,string> person)
        {
            Console.WriteLine($"ID == {person.Item1}.");
            Console.WriteLine($"First Name == {person.Item2}.");
            Console.WriteLine($"Last Name == {person.Item3}.\n");
        }
    }
}