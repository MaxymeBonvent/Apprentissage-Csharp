// 40. SORTEDLIST

namespace Lesson40
{
    class Program40
    {
        // public static void Main()
        // {
        //     /*
        //         The SortedList<TKey, TValue>, and SortedList are collection classes that can 
        //         store key-value pairs that are sorted by the keys based on the associated 
        //         IComparer implementation. For example, if the keys are of primitive types, 
        //         then sorted in ascending order of keys.

        //         C# supports generic and non-generic SortedList. It is recommended to use 
        //         generic SortedList<TKey, TValue> because it performs faster and less 
        //         error-prone than the non-generic SortedList.
        //     */

        //     /*
        //         SORTEDLIST CHARACTERISTICS

        //         SortedList<TKey, TValue> is an array of key-value pairs sorted by keys.

        //         Sorts elements as soon as they are added. 
        //         Sorts primitive type keys in ascending order and object keys based on 
        //         IComparer<T>.

        //         Comes under System.Collection.Generic namespace.

        //         A key must be unique and cannot be null.

        //         A value can be null or duplicate.

        //         A value can be accessed by passing associated key in the indexer 
        //         mySortedList[key].

        //         Contains elements of type KeyValuePair<TKey, TValue>.

        //         It uses less memory than SortedDictionary<TKey,TValue>.

        //         It is faster in the retrieval of data once sorted, whereas 
        //         SortedDictionary<TKey, TValue> is faster in insertion and removing key-value 
        //         pairs.
        //     */

        //     /*
        //         CREATING A SORTEDLIST

        //         The following example demonstrates how to create a generic 
        //         SortedList<TKey, TValue>, and add key-value pairs in it.
        //     */

        //     //SortedList of int keys, string values 
        //     SortedList<int, string?> numberNames = new SortedList<int, string?>();

        //     numberNames.Add(3, "Three");
        //     numberNames.Add(1, "One");
        //     numberNames.Add(2, "Two");
        //     numberNames.Add(4, null);
        //     numberNames.Add(10, "Ten");
        //     numberNames.Add(5, "Five");

        //     //The following will throw exceptions
        //     // numberNames.Add("Three", 3); Cannot convert string to int
        //     // numberNames.Add(null, "Five"); Key cannot null

        //     /*
        //         Unhandled exception. System.ArgumentException: An item with the same key has 
        //         already been added. Key: 1 (Parameter 'key').

        //         numberNames.Add(1, "One");
        //     */

        //     /*
        //         In the above example, a generic SortedList<TKey, TValue> object is created by 
        //         specifying the type of keys and values it is going to store. 
        //         The SortedList<int, string> will store keys of int type and values of string 
        //         type.

        //         The Add() method is used to add a single key-value pair in a SortedList. 
        //         Keys cannot be null or duplicate. If found, it will throw a run-time exception. Values can be duplicate and null if the type is nullable.

        //         Use the collection-initializer syntax to initialize a SortedList with multiple 
        //         key-value pairs at the time of instantiating, as shown below.
        //     */

        //     /*
        //         Creating a SortedList of string keys and string values 
        //         using collection-initializer syntax 
        //     */
        //     SortedList<string,string> cityCountry = new SortedList<string,string>()
        //     {
        //         {"London", "UK"},
        //         {"New York", "USA"},
        //         { "Mumbai", "India"},
        //         {"Johannesburg", "South Africa"}
        //     };

        //     /*
        //         The SortedList sorts key-value pairs in the ascending order of keys as 
        //         soon as a key-value pair added. The following example displays all the keys 
        //         and values using foreach loop.
        //     */

        //     SortedList<int,string> numberNames2 = new SortedList<int,string>()
        //     {
        //         {3, "Three"},
        //         {5, "Five"},
        //         {1, "One"}
        //     };

        //     Console.WriteLine("---Initial key-values--");
        //     foreach(KeyValuePair<int, string> kvp in numberNames2)
        //     {
        //         Console.WriteLine("numberNames2 key: {0}, value: {1}", kvp.Key , kvp.Value);
        //     }

        //     Console.WriteLine("\n");

        //     numberNames2.Add(6, "Six");
        //     numberNames2.Add(2, "Two");
        //     numberNames2.Add(4, "Four");

        //     Console.WriteLine("---After adding new key-values--");
        //     foreach(var kvp in numberNames2)
        //     {
        //         Console.WriteLine("numberNames2 key: {0}, value: {1}", kvp.Key , kvp.Value );
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         ACCESSING SORTEDLIST

        //         Specify a key in the indexer sortedList[key], to get or set a value in the 
        //         SortedList.
        //     */

        //     SortedList<int,string> numberNames3 = new SortedList<int,string>()
        //     {
        //         {3, "Three"},
        //         {1, "One"},
        //         {2, "Two"}
        //     };

        //     Console.WriteLine($"numberNames3[1] = {numberNames3[1]}.");
        //     Console.WriteLine($"numberNames3[2] = {numberNames3[2]}.");
        //     Console.WriteLine($"numberNames3[3] = {numberNames3[3]}.");
        //     //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

        //     Console.WriteLine("\n");

        //     numberNames3[2] = "TwoTwo"; //updates value
        //     numberNames3[4] = "Four"; //adds a new key-value if a key does not exists

        //     Console.WriteLine($"numberNames3[2] = {numberNames3[2]}.");
        //     Console.WriteLine($"numberNames3[4] = {numberNames3[4]}.");

        //     Console.WriteLine("\n");

        //     /*
        //         Above, numberNames[10] will throw a KeyNotFoundException because specified 
        //         key 10 does not exist in a sortedlist. To prevent this exception, use 
        //         ContainsKey() or TryGetValue() methods, as shown below.
        //     */

        //     SortedList<int, string> numberNames4 = new SortedList<int, string>()
        //     {
        //         {3, "Three"},
        //         {1, "One"},
        //         {2, "Two"}
        //     };

        //     // If a key-value pair of key 4 exists
        //     if(numberNames4.ContainsKey(4))
        //     {
        //         // Assign four to the value of that key
        //         numberNames4[4] = "four";
        //     }

        //     // If the key-value pairs SortedList contains a key 4 with a string value
        //     if(numberNames4.TryGetValue(4, out string? result))
        //     {
        //         // Display that string value
        //         Console.WriteLine($"numberNames4[4] = {numberNames4[4]}.");
        //     }

        //     // If the key-value pairs SortedList does not contain a key 4 with a string value
        //     else
        //     {
        //         // Display a non-existence message
        //         Console.WriteLine("There is no key 4 in numberNames4.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         Use Keys and Values properties if you want to iterate a SortedList using a 
        //         for loop.
        //     */  

        //     SortedList<int, string> numberNames5 = new SortedList<int,string>()
        //     {
        //         {3, "Three"},
        //         {1, "One"},
        //         {2, "Two"}
        //     };
            
        //     for (int i = 0; i < numberNames5.Count; i++)
        //     {
        //         Console.WriteLine($"numberNames5.Keys[{i}] = {numberNames5.Keys[i]}.\nnumberNames5.Values[{i}] = {numberNames5.Values[i]}.\n");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         REMOVE ELEMENTS FROM SORTEDLIST

        //         Use the Remove(key) and RemoveAt(index) methods to remove key-value pairs from 
        //         a SortedList.
        //     */

        //     SortedList<int,string> numberNames6 = new SortedList<int,string>()
        //     {
        //         {3, "Three"},
        //         {1, "One"},
        //         {2, "Two"},
        //         {5, "Five"},
        //         {4, "Four"}
        //     };
    
        //     numberNames6.Remove(1);// Removes key-value pair of key 1
        //     numberNames6.Remove(10);// Removes key-value pair of key 10, no error is thrown if it doesn't exist

        //     numberNames6.RemoveAt(0);// Removes key-value pair of index 0 
        //     //numberNames.RemoveAt(10);// Run-time exception: ArgumentOutOfRangeException

        //     foreach(var kvp in numberNames6)
        //     {
        //         Console.WriteLine($"kvp in numberNames6 = {kvp}.");
        //     }

        //     Console.WriteLine("\n");
        // }
    }
}