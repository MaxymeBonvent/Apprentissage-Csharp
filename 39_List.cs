// 39. LIST<T>

namespace Lesson39
{
    class Program39
    {
        // public static void Main()
        // {
        //     /*
        //         The List<T> is a collection of strongly typed objects that can be accessed by 
        //         index and having methods for sorting, searching, and modifying list. 
        //         It is the generic version of the ArrayList that comes under 
        //         System.Collections.Generic namespace.
        //     */

        //     /*
        //         LIST<T> CHARACTERISTICS

        //         List<T> equivalent of the ArrayList, which implements IList<T>.

        //         It comes under System.Collections.Generic namespace.

        //         List<T> can contain elements of the specified type. 
        //         It provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.

        //         Elements can be added using the Add(), AddRange() methods or 
        //         collection-initializer syntax.

        //         Elements can be accessed by passing an index e.g. myList[0]. 
        //         Indexes start from zero.

        //         List<T> performs faster and less error-prone than the ArrayList.
        //     */

        //     /*
        //         CREATING A LIST 

        //         The List<T> is a generic collection, so you need to specify a type parameter 
        //         for the type of data it can store. The following example shows how to create 
        //         list and add elements.
        //     */

        //     List<int> primeNbs = new List<int>();

        //     // Adding elements using Add() method
        //     primeNbs.Add(2); 
        //     primeNbs.Add(3);
        //     primeNbs.Add(5);
        //     primeNbs.Add(7);

        //     var cities = new List<string?>();
        //     cities.Add("New York");
        //     cities.Add("London");
        //     cities.Add("Mumbai");
        //     cities.Add("Chicago");
        //     cities.Add(null); // Nulls are allowed for reference type list

        //     // Adding elements using collection-initializer syntax
        //     var cities2 = new List<string?>()
        //     {
        //         "New York",
        //         "London",
        //         "Mumbai",
        //         "Chicago"                    
        //     };

        //     /*
        //         In the above example, List<int> primeNumbers = new List<int>(); creates a 
        //         list of int type. In the same way, cities and bigCities are string type list. 
        //         You can then add elements in a list using the Add() method or the 
        //         collection-initializer syntax.

        //         You can also add elements of the custom classes using the 
        //         collection-initializer syntax. 
        //         The following adds objects of the Student class in the List<Student>.
        //     */

        //     var students = new List<Student>() 
        //     { 
        //         new (){ID = 1, Name = "Bill"},
        //         new (){ID = 2, Name = "Steve"},
        //         new (){ID = 3, Name = "Leo"},
        //         new (){ID = 4, Name = "Celeste"}
        //     };

        //     /*
        //         ADDING AN ARRAY IN A LIST

        //         Use the AddRange() method to add all the elements from an array or another 
        //         collection to List.

        //         AddRange() syntax: void AddRange(IEnumerable<T> collection)
        //     */

        //     string[] cities3 = new string[3]{ "Mumbai", "London", "New York" };

        //     var popularCities = new List<string>();

        //     // Adding an array in a List
        //     popularCities.AddRange(cities3);

        //     var favouriteCities = new List<string>();

        //     // Adding a List 
        //     favouriteCities.AddRange(popularCities);

        //     /*
        //         ACCESSING A LIST

        //         A list can be accessed by an index, a for/foreach loop, and using LINQ queries. 
        //         Indexes of a list start from zero. 
        //         Pass an index in the square brackets to access individual list items, same as 
        //         array. Use a foreach or for loop to iterate a List<T> collection.
        //     */

        //     List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6};

        //     Console.WriteLine($"numbers[{0}] = {numbers[0]}." );
        //     Console.WriteLine($"numbers[{1}] = {numbers[1]}.");
        //     Console.WriteLine($"numbers[{2}] = {numbers[2]}.");
        //     Console.WriteLine($"numbers[{3}] = {numbers[3]}.");

        //     Console.WriteLine("\n");

        //     // Using a foreach LINQ method
        //     numbers.ForEach(num => Console.WriteLine("num = " + num));

        //     Console.WriteLine("\n");

        //     // Using a for loop
        //     for(int i = 0; i < numbers.Count; i++)
        //     {
        //         Console.WriteLine($"numbers[{i}] = {numbers[i]}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         ACCESSING A LIST USING LINQ

        //         The List<T> implements the IEnumerable interface. 
        //         So we can query a list using LINQ query syntax or method syntax, 
        //         as shown below.
        //     */

        //     var students2 = new List<Student>() 
        //     { 
        //         new(){ID = 1, Name = "Bill"},
        //         new(){ID = 2, Name = "Steve"},
        //         new(){ID = 3, Name = "John"},
        //         new(){ID = 4, Name = "Lily"}
        //     };

        //     // Get all students whose name is Bill
        //     var result = from s in students2
        //     where s.Name == "Bill"
        //     select s;
                    
        //     foreach(var stud in result)
        //     {
        //         Console.WriteLine($"Student ID : {stud.ID}. Student Name: {stud.Name}.");
        //     }

        //     /*
        //         INSERT ELEMENTS IN A LIST

        //         Use the Insert() method inserts an element into the List<T> collection at the 
        //         specified index.

        //         Insert() syntax: void Insert(int index, T item);
        //     */

        //     var numbers2 = new List<int>(){10, 20, 30, 40};

        //     numbers2.Insert(1, 11);

        //     foreach(var num in numbers2)
        //     {
        //         Console.WriteLine($"num in numbers2 = {num}");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         REMOVE ELEMENTS FROM A LIST

        //         Use the Remove() method to remove the first occurrence of the specified 
        //         element in the List<T> collection. 
        //         Use the RemoveAt() method to remove an element from the specified index. 
        //         If no element at the specified index, then the ArgumentOutOfRangeException 
        //         will be thrown.

        //         Remove() syntax: bool Remove(T item)
        //         RemoveAt() syntax: void RemoveAt(int index)
        //     */

        //     var numbers3 = new List<int>(){20, 21, 22, 23, 24};

        //     numbers3.Remove(21); // removes the first 10 from a list

        //     numbers3.RemoveAt(2); //removes the 3rd element (index starts from 0)

        //     //numbers3.RemoveAt(10); //throws ArgumentOutOfRangeException

        //     foreach (int nb in numbers3)
        //     {
        //         Console.WriteLine($"nb in numbers3 = {nb}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         CHECK ELEMENTS IN A LIST

        //         Use the Contains() method to determine whether an element is in the List<T> 
        //         or not.
        //     */

        //     var numbers4 = new List<int>(){40, 41, 42, 43, 44};
        //     Console.WriteLine($"numbers4.Contains(40) = {numbers4.Contains(40)}."); 
        //     Console.WriteLine($"numbers4.Contains(41) = {numbers4.Contains(41)}.");
        //     Console.WriteLine($"numbers4.Contains(22) = {numbers4.Contains(22)}.");

        //     Console.WriteLine("\n");

        //     /*
        //         LIST<T> CLASS PROPERTIES AND METHODS

        //         The following tables lists the important properties and methods of List<T> class:

        //         Property	Usage
        //         Items	    Gets or sets the element at the specified index
        //         Count	    Returns the total number of elements exists in the List<T>


        //         Method	        Usage
        //         Add	            Adds an element at the end of a List<T>.
        //         AddRange	    Adds elements of the specified collection at the end of a List<T>.
        //         BinarySearch	Search the element and returns an index of the element.
        //         Clear	        Removes all the elements from a List<T>.
        //         Contains	    Checks whether the specified element exists or not in a List<T>.
        //         Find	        Finds the first element based on the specified predicate function.
        //         Foreach	        Iterates through a List<T>.
        //         Insert	        Inserts an element at the specified index in a List<T>.
        //         InsertRange	    Inserts elements of another collection at the specified index.
        //         Remove	        Removes the first occurrence of the specified element.
        //         RemoveAt	    Removes the element at the specified index.
        //         RemoveRange	    Removes all the elements that match the supplied predicate function.
        //         Sort	        Sorts all the elements.
        //         TrimExcess	    Sets the capacity to the actual number of elements.
        //         TrueForAll	    Determines whether every element in the List<T> matches the conditions defined by the specified predicate.
        //     */
        // }

        class Student
        {
            public int ID {get; set;}
            public string? Name {get; set;}
        }
    }
}