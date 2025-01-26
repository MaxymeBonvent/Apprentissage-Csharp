// 42. HASHTABLE

using System.Collections;

namespace Lesson42
{
    class Program42
    {
        // public static void Main()
        // {
        //     /*
        //         The Hashtable is a non-generic collection that stores key-value pairs, 
        //         similar to generic Dictionary<TKey, TValue> collection. It optimizes lookups 
        //         by computing the hash code of each key and stores it in a different bucket 
        //         internally and then matches the hash code of the specified key at the time of 
        //         accessing values.
        //     */

        //     /*
        //         HASHTABLE CHARACTERISTICS

        //         Hashtable stores key-value pairs.

        //         Comes under System.Collections namespace.

        //         Implements IDictionary interface.

        //         Keys must be unique and cannot be null.
                
        //         Values can be null or duplicate.

        //         Values can be accessed by passing associated key in the indexer like 
        //         myHashtable[key].

        //         Elements are stored as DictionaryEntry objects.
        //     */

        //     /*
        //         CREATING A HASHTABLE

        //         The following example demonstrates creating a Hashtable and adding elements.
        //     */

        //     Hashtable numberNames = new Hashtable();
        //     Console.WriteLine($"numberNames = {numberNames}.\n");

        //     // Adding a key-value pair using the Add() method
        //     numberNames.Add(1,"One");
        //     numberNames.Add(3,"Three");
        //     numberNames.Add(2,"Two");

        //     // The following throws run-time exception: key already added.
        //     //numberNames.Add(3, "Three"); 

        //     foreach(DictionaryEntry dicEn in numberNames)
        //     {
        //         Console.WriteLine($"dicEn in numberNames = {dicEn}.");
        //     }

        //     Console.WriteLine("\n");
                    
        //     // Creating a Hashtable using collection-initializer syntax
        //     var cities = new Hashtable()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };
                    
        //     foreach(DictionaryEntry dicEn in cities)
        //     {
        //         Console.WriteLine($"dicEn in cities = {dicEn}.");   
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         A Hashtable collection can include all the elements of a  Dictionary, 
        //         as shown below.
        //     */

        //     Dictionary<int, string> dict = new Dictionary<int, string>();
        //     Console.WriteLine($"dict = {dict}.");

        //     dict.Add(1, "one");
        //     dict.Add(2, "two");
        //     dict.Add(3, "three");

        //     Hashtable ht = new Hashtable(dict);

        //     Console.WriteLine($"ht = {ht}.");

        //     Console.WriteLine("\n");

        //     for(int i = 0; i < ht.Count; i++)
        //     {
        //         Console.WriteLine($"ht[{i}] = {ht[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         UPDATE A HASHTABLE

        //         You can retrieve the value of an existing key from the Hashtable by passing a 
        //         key in indexer. The Hashtable is non-generic collection, so you must type 
        //         cast values while retrieving it.
        //     */

        //     //creating a Hashtable using collection-initializer syntax
        //     var cities2 = new Hashtable()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };
                
        //     string? citiesOfUK = (string?) cities2["UK"]; //cast to string
        //     string? citiesOfUSA = (string?) cities2["USA"]; //cast to string

        //     Console.WriteLine("Before update:");
        //     Console.WriteLine($"citiesOfUK = {citiesOfUK}.");
        //     Console.WriteLine($"citiesOfUSA = {citiesOfUSA}.");

        //     Console.WriteLine("\n");

        //     cities2["UK"] = "Liverpool, Bristol"; // update value of UK key
        //     cities2["USA"] = "Los Angeles, Boston"; // update value of USA key

        //     string? citiesOfUK_Up = (string?) cities2["UK"]; //cast to string
        //     string? citiesOfUSA_Up = (string?) cities2["USA"]; //cast to string

        //     Console.WriteLine("After update:");
        //     Console.WriteLine($"citiesOfUK_Up = {citiesOfUK_Up}.");
        //     Console.WriteLine($"citiesOfUSA_Up = {citiesOfUSA_Up}.");

        //     Console.WriteLine("\n");

        //     if(!cities2.ContainsKey("France"))
        //     {
        //         cities2["France"] = "Paris";
        //     }

        //     /*
        //         REMOVE ELEMENTS IN A HASHTABLE

        //         The Remove() method removes the key-value that match with the specified key in 
        //         the Hashtable. It throws the KeyNotfoundException if the specified key not 
        //         found in the Hashtable, so check for an existing key using the ContainsKey() 
        //         method before removing.

        //         Use the Clear() method to remove all the elements in one shot.
        //     */

        //     var cities3 = new Hashtable()
        //     {
        //         {"UK", "London, Manchester, Birmingham"},
        //         {"USA", "Chicago, New York, Washington"},
        //         {"India", "Mumbai, New Delhi, Pune"}
        //     };

        //     Console.WriteLine("Initial Hastable:");
        //     foreach(DictionaryEntry dicEn in cities3)
        //     {
        //         Console.WriteLine($"dicEn in cities3 = {dicEn}.");
        //     }

        //     Console.WriteLine("\n");

        //     cities3.Remove("UK"); // removes UK 
        //     //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

        //     // Check if a key exists before removing it
        //     if(cities3.ContainsKey("France"))
        //     { 
        //         cities3.Remove("France");
        //     }

        //     cities3.Clear(); //removes all elements

        //     Console.WriteLine("Hastable after Remove() and Clear():");
        //     foreach(DictionaryEntry dicEn in cities3)
        //     {
        //         Console.WriteLine($"dicEn in cities3 = {dicEn}.");
        //     }

        //     Console.WriteLine("\n");
        // }
    }
}