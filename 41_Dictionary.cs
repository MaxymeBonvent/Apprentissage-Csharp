// 41. DICTIONARY

namespace Lesson41
{
    class Program41
    {
        // public static void Main()
        // {
        //     /*
        //        The Dictionary<TKey, TValue> is a generic collection that stores key-value 
        //        pairs in no particular order. 
        //     */

        //     /*
        //         DICTIONARY CHARACTERISTICS

        //         Dictionary<TKey, TValue> stores key-value pairs.

        //         It comes under the System.Collections.Generic namespace.

        //         It implements IDictionary<TKey, TValue> interface.

        //         Keys must be unique and cannot be null.

        //         Values can be null or duplicate.

        //         Values can be accessed by passing associated key in the indexer like 
        //         myDictionary[key].

        //         Elements are stored as KeyValuePair<TKey, TValue> objects.
        //     */

        //     /*
        //         CREATING A DICTIONARY

        //         You can create the Dictionary<TKey, TValue> object by passing the type of 
        //         keys and values it can store. The following example shows how to create a 
        //         dictionary and add key-value pairs.
        //     */

        //     IDictionary<int, string> numberNames = new Dictionary<int, string>();

        //     // Adding a key/value using the Add() method
        //     numberNames.Add(1,"One"); 
        //     numberNames.Add(2,"Two");
        //     numberNames.Add(3,"Three");

        //     // The following throws run-time exception: key already added.
        //     //numberNames.Add(3, "Three"); 

        //     foreach(KeyValuePair<int, string> kvp in numberNames)
        //     {
        //         Console.WriteLine($"kvp in numberNames = {kvp}.");
        //     }

        //     Console.WriteLine("\n");

        //     // Creating a dictionary using collection-initializer syntax
        //     var cities = new Dictionary<string, string>()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };
                    
        //     foreach(var kvp in cities)
        //     {
        //         Console.WriteLine($"kvp in cities = {kvp}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         In the above example, numberNames is a Dictionary<int, string> type dictionary, 
        //         so it can store int keys and string values. In the same way, cities is a 
        //         Dictionary<string, string> type dictionary, so it can store string keys and 
        //         string values. Dictionary cannot include duplicate or null keys, whereas 
        //         values can be duplicated or null. Keys must be unique otherwise, it will 
        //         throw a runtime exception.
        //     */

        //     /*
        //         ACCESS DICTIONARY ELEMENTS

        //         The Dictionary can be accessed using indexer. Specify a key to get the 
        //         associated value. You can also use the ElementAt() method to get a 
        //         KeyValuePair from the specified index.
        //     */

        //     var cities2 = new Dictionary<string, string>()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };

        //     Console.WriteLine($"cities2[\"UK\"] = {cities2["UK"]}."); //prints value of UK key
        //     Console.WriteLine($"cities2[\"USA\"] = {cities2["USA"]}.");//prints value of USA key
        //     //Console.WriteLine(cities2["France"]); // run-time exception: Key does not exist

        //     Console.WriteLine("\n");

        //     // Use ContainsKey() to check for an unknown key
        //     if(cities2.ContainsKey("France"))
        //     {  
        //         Console.WriteLine($"cities2[\"France\"] = {cities2["France"]}.");
        //     }

        //     // Use TryGetValue() to get the value of an unknown key
        //     if(cities2.TryGetValue("France", out string? result))
        //     {
        //         Console.WriteLine($"result = {result}.");
        //     }

        //     // Use ElementAt() to retrieve key-value pair using index
        //     for (int i = 0; i < cities2.Count; i++)
        //     {
        //         Console.WriteLine($"cities2.ElementAt({i}) = {cities2.ElementAt(i)}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         UPDATE A DICTIONARY

        //         Update the value of a key by specifying a key in the indexer. 
        //         It will throw the KeyNotFoundException if a key does not exist in the 
        //         dictionary, therefore use the ContainsKey() method before accessing unknown 
        //         keys.                
        //     */

        //     var cities3 = new Dictionary<string, string>()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };

        //     cities3["UK"] = "Liverpool, Bristol"; // update value of UK key
        //     Console.WriteLine($"cities3[\"UK\"] = {cities3["UK"]}.");

        //     cities3["USA"] = "Los Angeles, Boston"; // update value of USA key
        //     Console.WriteLine($"cities3[\"USA\"] = {cities3["USA"]}.");
        //     //cities3["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

        //     if(cities3.ContainsKey("France"))
        //     {
        //         cities3["France"] = "Paris";
        //     }

        //     Console.WriteLine("\n");


        //     /*
        //         REMOVE ELEMENTS IN DICTIONARY

        //         The Remove() method deletes an existing key-value pair from a dictionary. 
        //         The Clear() method deletes all the elements of the dictionary.
        //     */

        //     var cities4 = new Dictionary<string, string>()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };

        //     foreach(KeyValuePair<string, string> kvp in cities4)
        //     {
        //         Console.WriteLine($"kvp in cities4 = {kvp}.");
        //     }

        //     cities4.Remove("UK"); // Removes UK 
        //     // cities.Remove("France"); // Throws run-time exception: KeyNotFoundException

        //     cities4.Remove("France");

        //     cities4.Clear(); // Removes all elements

        //     foreach(KeyValuePair<string, string> kvp in cities4)
        //     {
        //         Console.WriteLine($"kvp in cities4 = {kvp}.");
        //     }

        //     Console.WriteLine("\n");
        // }
    }
}