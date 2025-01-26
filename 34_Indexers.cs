// 34. INDEXERS 

namespace Lesson34
{
    class Program34
    {
        // public static void Main()
        // {
        //     /*
        //         An indexer is a special type of property that allows a class or a structure 
        //         to be accessed like an array for its internal collection. C# allows us to 
        //         define custom indexers, generic indexers, and overload indexers.

        //         An indexer can be defined the same way as a property with "this" keyword and 
        //         square brackets [].

        //         Syntax:

        //         access-modifier <return type> this[<parameter type> index]
        //         {
        //             get {return the value from the specified index of an internal collection}
        //             set {set values at the specified index in an internal collection}
        //         }
        //     */

        //     // The following example defines an indexer in a class.

        //     /*
        //         The above StringDataStore class defines an indexer for its private array 
        //         strArr. So now, you can use the StringDataStore like an array to add and 
        //         retrieve string values from strArr, as shown below.
        //     */

        //     StringDataStore strStore = new();

        //     strStore[0] = "One";
        //     strStore[1] = "Two";
        //     strStore[2] = "Three";
        //     strStore[3] = "Four";
                    
        //     for(int i = 0; i < 4 ; i++)
        //     {
        //         Console.WriteLine($"strStore[{i}] = {strStore[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     // You can use expression-bodied syntax for get and set from C# 7 (2017) onwards.

        //     /*
        //         GENERIC INDEXER

        //         Indexers can also be generic. 
        //         The following generic class includes a generic indexer.
        //     */

        //     /*
        //         The below generic indexer can be used with any data type. 
        //         The following example demonstrates the use of generic indexers.
        //     */

        //     DataStore<int> grades = new DataStore<int>();
        //     grades[0] = 100;
        //     grades[1] = 25;
        //     grades[2] = 34;
        //     grades[3] = 42;
        //     grades[4] = 12;
        //     grades[5] = 18;
        //     grades[6] = 2;
        //     grades[7] = 95;
        //     grades[8] = 75;
        //     grades[9] = 53;

        //     for (int i = 0; i < grades.Length;i++)
        //     {
        //         Console.WriteLine($"grades[{i}] = {grades[i]}.");
        //     }

        //     Console.WriteLine("\n");
                

        //     DataStore<string> names = new DataStore<string>(5);
        //     names[0] = "Steve";
        //     names[1] = "Bill";
        //     names[2] = "James";
        //     names[3] = "Ram";
        //     names[4] = "Andy";

        //     for (int i = 0; i < names.Length;i++)
        //     {
        //         Console.WriteLine($"names[{i}] = {names[i]}.");
        //     }   

        //     Console.WriteLine("\n");

        //     /*
        //         OVERLOAD INDEXER

        //         You can be overloaded with different data types for index. 
        //         The following example overloads an indexer with int type index and 
        //         string type index.
        //     */

        //     StrDatStoreOverload strStorOvl = new ();

        //     strStorOvl[0] = "One";
        //     strStorOvl[1] = "Two";
        //     strStorOvl[2] = "Three";
        //     strStorOvl[3] = "Four";
            
        //     Console.WriteLine($"strStorOvl[\"one\"] = {strStorOvl["one"]}.");
        //     Console.WriteLine($"strStorOvl[\"two\"] = {strStorOvl["two"]}.");
        //     Console.WriteLine($"strStorOvl[\"three\"] = {strStorOvl["three"]}.");
        //     Console.WriteLine($"strStorOvl[\"four\"] = {strStorOvl["four"]}.");

        //     Console.WriteLine("\n");

        //     // Indexer does not allow ref and out parameters.
        // }

        // //  Class with an overloaded indexer
        // class StrDatStoreOverload
        // {
        //     private string[] strArr = new string[10]; // Internal data storage

        //     // int type indexer
        //     public string this[int index]
        //     {
        //         get
        //         {
        //             if (index < 0 || index >= strArr.Length)
        //                 throw new IndexOutOfRangeException("Error : index out of range.");

        //             return strArr[index];
        //         }

        //         set
        //         {
        //             if (index < 0 || index >= strArr.Length)
        //                 throw new IndexOutOfRangeException("Error : index out of range.");

        //             strArr[index] = value;
        //         }
        //     }

        //     // string type indexer
        //     public string this[string name]
        //     {
        //         get
        //         {
        //             foreach (string str in strArr)
        //             {
        //                 if(str.ToLower() == name.ToLower())        
        //                     return str;
        //             }
                            
        //             return null;
        //         }
        //     }
        // }

        // Generic indexer
        class DataStore<T>
        {
            private T[] store; 

            public DataStore()
            {
                store = new T[10];
            }

            public DataStore(int length)
            {
                store = new T[length];
            }

            public T this[int index]
            {
                get
                {
                    if (index < 0 &&  index >= store.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                        return store[index];
                }

                set
                {
                    if (index < 0 ||  index >= store.Length)
                        throw new IndexOutOfRangeException("Index out of range");

                    store[index] = value;
                }
            }

            public int Length
            {
                get
                {
                    return store.Length;
                }
            }
        }

        // Class with an indexer
        class StringDataStore
        {
            private string[] strArr = new string[10]; // Internal data storage

            public string this[int index]
            {
                get
                {
                    if (index < 0 || index >= strArr.Length)
                        throw new IndexOutOfRangeException("Error : index out of range.");

                        return strArr[index];
                }

                set
                {
                    if (index < 0 ||  index >= strArr.Length)
                        throw new IndexOutOfRangeException("Error : index out of range.");

                    strArr[index] = value;
                }

                /*
                    Expression-bodied syntax

                    get => strArr[index];
                    set => strArr[index] = value;
                */
            }
        }
    }
}