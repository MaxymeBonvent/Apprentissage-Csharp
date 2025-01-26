// 38. ARRAYLIST

using System.Collections; // Necessary for ArrayList

namespace Lesson38
{
    class Program38
    {
        // public static void Main()
        // {
        //     /*
        //         In C#, the ArrayList is a non-generic collection of objects whose size 
        //         increases dynamically. 
        //         It is the same as Array except that its size increases dynamically.

        //         An ArrayList can be used to add unknown data where you don't know the types 
        //         and the size of the data.  
        //     */

        //     /*
        //        CREATE AN ARRAYLIST

        //        The ArrayList class included in the System.Collections namespace. 
        //        Create an object of the ArrayList using the "new" keyword. 
        //     */

        //     ArrayList arList = new ArrayList();
        //     Console.WriteLine($"arList = {arList}.");

        //     Console.WriteLine("\n");

        //     /*
        //         ADDING ELEMENTS IN AN ARRAYLIST

        //         Use the Add() method or object initializer syntax to add elements in an 
        //         ArrayList.

        //         An ArrayList can contain multiple null and duplicate values.
        //     */

        //     // Adding elements using ArrayList.Add() method
        //     ArrayList arList1 = new ArrayList();
        //     arList1.Add(1);
        //     arList1.Add("Bill");
        //     arList1.Add(" ");
        //     arList1.Add(true);
        //     arList1.Add(4.5f);
        //     arList1.Add(null);

        //     foreach(var item in arList1)
        //     {
        //         Console.WriteLine($"item of arList1 = {item}.");
        //     }

        //     Console.WriteLine("\n");

        //     // Adding elements using object initializer syntax
        //     ArrayList arList2 = new ArrayList()
        //     {
        //         2, 
        //         "Steve", 
        //         " ", 
        //         true, 
        //         4.5, 
        //         null
        //     };

        //     foreach(var item in arList2)
        //     {
        //         Console.WriteLine($"item of arList2 = {item}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         Use the AddRange(ICollection c) method to add an entire Array, HashTable, 
        //         SortedList, ArrayList, BitArray, Queue, and Stack in an ArrayList.
        //     */

        //     ArrayList arList3 = new ArrayList();

        //     ArrayList arList4 = new ArrayList()
        //     {
        //         1, "Bill", " ", true, 4.5f, null
        //     };

        //     int[] arr = [100, 200, 300, 400];

        //     Queue myQ = new();
        //     myQ.Enqueue("Hello");
        //     myQ.Enqueue("World.");

        //     arList3.AddRange(arList4);
        //     arList3.AddRange(arr); 
        //     arList3.AddRange(myQ);

        //     foreach(var item in arList3)
        //     {
        //         Console.WriteLine($"item of arList3 = {item}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         ACCESSING AN ARRAYLIST

        //         The ArrayList class implements the IList interface. So, elements can be 
        //         accessed using indexer, in the same way as an array. Index starts from zero 
        //         and increases by one for each subsequent element.

        //         An explicit casting to the appropriate types is required, or use the var 
        //         variable.
        //     */

        //     ArrayList arList5 = [1, "Bill", 2, 4.5f];

        //     // Access individual item using indexer
        //     int? firstElement = (int?) arList5[0];
        //     Console.WriteLine($"firstElement = {firstElement}.");

        //     string? secondElement = (string?) arList5[1];
        //     Console.WriteLine($"secondElement = {secondElement}.");

        //     /*
        //         Unhandled exception. System.InvalidCastException: 
        //         Unable to cast object of type 'System.String' to type 'System.Nullable`1[System.Int32]'.

        //         int? thirdElement = (int?) arList5[1];
        //         Console.WriteLine($"thirdElement = {thirdElement}.");
        //     */

        //     // Using "var" keyword without explicit casting
        //     var fourthElement = arList5[0];
        //     Console.WriteLine($"fourthElement = {fourthElement}.");

        //     var fifthElement = arList5[1];
        //     Console.WriteLine($"fifthElement = {fifthElement}.");

        //     /*
        //       Unhandled exception. System.ArgumentOutOfRangeException: 
        //       Index was out of range. Must be non-negative and less than the size of the 
        //       collection.  

        //       var sixthElement = arList5[5];
        //     */

        //     Console.WriteLine("\n");
        //     Console.WriteLine("Before update:");

        //     for(int i = 0; i < arList5.Count; i++)
        //     {
        //         Console.WriteLine($"arList5[{i}] = {arList5[i]}.");
        //     }

        //     // Update elements
        //     arList5[0] = "Steve"; 
        //     arList5[1] = 100;

        //     Console.WriteLine("\n");
        //     Console.WriteLine("After update:");

        //     for(int i = 0; i < arList5.Count; i++)
        //     {
        //         Console.WriteLine($"arList5[{i}] = {arList5[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         ITERATE AN ARRAYLIST

        //         The ArrayList implements the ICollection interface that supports iteration of 
        //         the collection types. So, use a foreach or a for loop to iterate an 
        //         ArrayList. The Count property of an ArrayList returns the total number of 
        //         elements in an ArrayList.
        //     */

        //     /*
        //         INSERT ELEMENTS IN AN ARRAYLIST

        //         Use the Insert() method to insert an element at the specified index into an 
        //         ArrayList.

        //         Syntax: void Insert(int index, Object value)
        //     */

        //     ArrayList arList6 = [1, "Bill", 300, 4.5f];

        //     Console.WriteLine("Before Insert():");
        //     foreach (var val in arList6)
        //     {
        //         Console.WriteLine($"val of arList6 = {val}.");
        //     }

        //     Console.WriteLine("\n");

        //     arList6.Insert(1, "Second Item");

        //     Console.WriteLine("After Insert():");
        //     foreach (var val in arList6)
        //     {
        //         Console.WriteLine($"val of arList6 = {val}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         Use the InsertRange() method to insert a collection in an ArrayList at the 
        //         specfied index.

        //         Syntax: Void InsertRange(int index, ICollection c)
        //     */

        //     ArrayList arList7 = [100, 200, 300];
        //     ArrayList arList8 = [400, 500, 600];

        //     Console.WriteLine("Before InsertRange() :");
        //     foreach(var item in arList7)
        //     {
        //         Console.WriteLine($"item in arList7 = {item}.");
        //     }

        //     Console.WriteLine("\n");

        //     arList7.InsertRange(2, arList8);

        //     Console.WriteLine("After InsertRange() :");
        //     foreach(var item in arList7)
        //     {
        //         Console.WriteLine($"item in arList7 = {item}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         REMOVE ELEMENTS FROM ARRAYLIST

        //         Use the Remove(), RemoveAt(), or RemoveRange() methods to remove elements from 
        //         an ArrayList.
        //     */

        //     ArrayList arList9 = [1, null, "Bill", 3, " ", 4.5f, 7];

        //     Console.WriteLine("Initial arList9:");
        //     for(int i = 0; i < arList9.Count; i++)
        //     {
        //         Console.WriteLine($"arList9[{i}] = {arList9[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     arList9.Remove(null); //Removes first occurence of null
        //     Console.WriteLine("arList9 after Remove(null):");
        //     for(int i = 0; i < arList9.Count; i++)
        //     {
        //         Console.WriteLine($"arList9[{i}] = {arList9[i]}.");
        //     }

        //     Console.WriteLine("\n");


        //     arList9.RemoveAt(4); //Removes element at index 4
        //     Console.WriteLine("arList9 after RemoveAt(4):");
        //     for(int i = 0; i < arList9.Count; i++)
        //     {
        //         Console.WriteLine($"arList9[{i}] = {arList9[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     arList9.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
        //     Console.WriteLine("arList9 after RemoveRange(0, 2):");
        //     for(int i = 0; i < arList9.Count; i++)
        //     {
        //         Console.WriteLine($"arList9[{i}] = {arList9[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         CHECK ELEMENT IN AN ARRAYLIST

        //         Use the Contains() method to determine whether the specified element exists 
        //         in the ArrayList or not. It returns true if exists otherwise returns false.
        //     */

        //     ArrayList arList10 = [1, "Bill", 3, 4.5f, 6];

        //     Console.WriteLine($"arList10.Contains(3) = {arList10.Contains(3)}.");
        //     Console.WriteLine($"arList10.Contains(\"Bill\") = {arList10.Contains("Bill")}.");
        //     Console.WriteLine($"arList10.Contains(10) = {arList10.Contains(10)}.");
        //     Console.WriteLine($"arList10.Contains(\"Steve\") = {arList10.Contains("Steve")}.");

        //     Console.WriteLine("\n");

        //     /*
        //         It's not recommended to use the ArrayList class due to performance issue. 
        //         Instead, use List<object> to store heterogeneous objects. 
        //         To store data of same data type, use Generic List<T>.
        //     */

        //     /*
        //         ARRAYLIST PROPERTIES

        //         Properties	Description
        //         Capacity	Gets or sets the number of elements that the ArrayList can contain.
        //         Count	    Gets the number of elements actually contained in the ArrayList.
        //         IsFixedSize	Gets a value indicating whether the ArrayList has a fixed size.
        //         IsReadOnly	Gets a value indicating whether the ArrayList is readonly.
        //         Item	    Gets or sets the element at the specified index.
        //     */

        //     /*
        //         ARRAYLIST METHODS

        //         Methods	                Description
        //         Add()/AddRange()	    Add() method adds single elements at the end of ArrayList.
        //                                 AddRange() method adds all the elements from the specified collection into ArrayList.
        //         Insert()/InsertRange()	Insert() method insert a single elements at the specified index in ArrayList.
        //                                 InsertRange() method insert all the elements of the specified collection starting from specified index in ArrayList.
        //         Remove()/RemoveRange()  Remove() method removes the specified element from the ArrayList.
        //                                 RemoveRange() method removes a range of elements from the ArrayList.
        //         RemoveAt()	            Removes the element at the specified index from the ArrayList.
        //         Sort()	                Sorts entire elements of the ArrayList.
        //         Reverse()	            Reverses the order of the elements in the entire ArrayList.
        //         Contains	            Checks whether specified element exists in the ArrayList or not. Returns true if exists otherwise false.
        //         Clear	                Removes all the elements in ArrayList.
        //         CopyTo	                Copies all the elements or range of elements to compitible Array.
        //         GetRange	            Returns specified number of elements from specified index from ArrayList.
        //         IndexOf	                Search specified element and returns zero based index if found. Returns -1 if element not found.
        //         ToArray	                Returns compitible array from an ArrayList.
        //     */
        // }
    }
}