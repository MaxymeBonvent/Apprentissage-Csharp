// 26. FOREACH LOOP

using System.Collections; // Necessary for IEnumerable

namespace Lesson26
{
    class Program26
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, the foreach loop iterates collection types such as 
        //         Array, ArrayList, List, SortedList, Hashtable, Dictionary, Stack, Queue, 
        //         Tuple and ValueTuple.

        //         It can be used with any type 
        //         that implements the IEnumerable interface.

        //         Syntax:
        //         foreach(var item in collection)
        //         {
        //             // Access item
        //         }

        //         The following example demonstrates iteration of an array using a foreach loop.
        //     */

        //     string[] carCompanies = {"Tata Motors", "Mahindra", "Volkswagen", "Toyota", "Nissan"};
																
        //     foreach(string company in carCompanies)
        //     {
        //         Console.WriteLine($"{company}");
        //     }

        //     // The following example demonstrates the foreach loop on a list collection.

        //     List<int> oddNumbers = new List<int>() {1, 3, 5, 7, 9};
																
        //     foreach(int num in oddNumbers)
        //     {
        //         Console.Write($"{num} ");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         The System.Collections.Generic namespace contains the ForEach() extension 
        //         method that can be used with any built-in collection classes such as 
        //         List, Dictionary, SortedList, etc.
        //     */

        //     /*
        //         IMPORTANT POINTS:

        //         The foreach loop iterates only in forward direction.

        //         Performance wise foreach loops take more time than for loops 
        //         because internally they use extra memory space.

        //         The foreach loop uses GetEnumarator() method of the IEnumerable interface. 
        //         So the foreach loop can be used with any class that has implemented the 
        //         interface.

        //         Exit foreach loops by using break, return, goto or throw.
        //     */

        //     // The following example demonstrates the foreach loop on a dictionary collection.

        //     var countryCitiesD = new Dictionary<string, string>()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };
                                                                            
        //     foreach(var countryCities in countryCitiesD)
        //     {
        //         Console.WriteLine($"{countryCities.Key}, {countryCities.Value}");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         IMPLEMENT IENUMERABLE INTERFACE

        //         As mentioned before, the foreach loop can be used to iterate any class that 
        //         has implemented the IEnumerable interface. The following example demonstrates 
        //         how to implement the IEnumerable interface in order to use the foreach loop 
        //         with a custom class.
        //     */

        //     Shop shop = new Shop();
																
        //     foreach (Customer cust in shop)
        //     {
        //         Console.WriteLine($"cust.name = {cust.name}.");
        //     }

        //     /*
        //         Below, the Shop class has implemented the IEnumerable interface that contains 
        //         the GetEnumerator() method. This will enable the Shop class to be used with 
        //         the foreach loop that returns Customer objects.
        //     */
        // }

        class Customer
        {
            public int id {get; set;}
            public string? name {get; set;}
        }

        class Shop : IEnumerable
        {
            // Array of customers
            private Customer[] custArray = new Customer[4];

            // Constructor                                                            
            public Shop()
            {
                custArray[0] = new Customer() {id = 1, name = "Steve"};
                custArray[1] = new Customer() {id = 2, name = "Paul"};
                custArray[2] = new Customer() {id = 3, name = "Joe"};
                custArray[3] = new Customer() {id = 4, name = "Yash"};
            }
                                                                        
            // Implementation for the GetEnumerator method.
            public IEnumerator GetEnumerator()
            {
                return custArray.GetEnumerator();
            }
        }
    }
}