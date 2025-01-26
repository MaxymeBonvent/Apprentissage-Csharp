// 36. GENERIC CONSTRAINTS

namespace Lesson36
{
    class Program36
    {
        // public static void Main()
        // {
        //     /*
        //         C# allows you to use constraints to restrict client code to specify certain 
        //         types while instantiating generic types. It will give a compile-time error if 
        //         you try to instantiate a generic type using a type that is not allowed by the 
        //         specified constraints.

        //         You can specify one or more constraints on the generic type using the "where" 
        //         clause after the generic type name.

        //         Syntax:

        //         GenericTypeName<T> where T  : contraint1, constraint2

        //         The following example demonstrates a generic class with a constraint to 
        //         reference types when instantiating the generic class.

        //         Above, we applied the class constraint, which means only a reference type can 
        //         be passed as an argument while creating the DataStore class object. So, you 
        //         can pass reference types such as class, interface, delegate, or array type. 
        //         Passing value types will give a compile-time error, so we cannot pass 
        //         primitive data types or struct types.
        //     */

        //     DataStore<string> store = new();
        //     Console.WriteLine($"store = {store}.");

        //     Console.WriteLine("\n");

        //     // DataStore<MyClass> store2 = new DataStore<MyClass>();
        //     // DataStore<IMyInterface> store3 = new DataStore<IMyInterface>();
        //     // DataStore<IEnumerable> store4 = new DataStore<IMyInterface>();
        //     // DataStore<ArrayList> store5 = new DataStore<ArrayList>();

        //     //DataStore<int> store = new DataStore<int>(); // compile-time error

        //     // The following table lists the types of generic constraints:

        //     /*
        //         Constraint	        Description
        //         class	            The type argument must be a class, interface, delegate, or array type.
        //         class?	            The type argument must be a nullable or non-nullable class, interface, delegate, or array type.
        //         struct	            The type argument must be non-nullable value types such as primitive data types int, char, bool, float, etc.
        //         new()	            The type argument must be a reference type which has a public parameterless constructor. It cannot be combined with struct and unmanaged constraints.
        //         notnull	            Available from C# 8.0 (2019) onwards. The type argument can be non-nullable reference types or value types. If not, then the compiler generates a warning instead of an error.
        //         unmanaged	        The type argument must be non-nullable unmanaged types.
        //         base class name	    The type argument must be or derive from the specified base class. The Object, Array, ValueType classes are disallowed as a base class constraint. The Enum, Delegate, MulticastDelegate are disallowed as base class constraint before C# 7.3.
        //         <base class name>?	The type argument must be or derive from the specified nullable or non-nullable base class.
        //         <interface name>	The type argument must be or implement the specified interface.
        //         <interface name>?	The type argument must be or implement the specified interface. It may be a nullable reference type, a non-nullable reference type, or a value type.
        //         where T: U	        The type argument supplied for T must be or derive from the argument supplied for U.
        //     */

        //     /*
        //         WHERE T : STRUCT

        //         The following example demonstrates the struct constraint that restricts type 
        //         argument to be non-nullable value type only.
        //     */

        //     DataStoreB<int> store2 = new();
        //     Console.WriteLine($"store2 = {store2}.");

        //     DataStoreB<char> store3 = new();
        //     Console.WriteLine($"store3 = {store3}.");

        //     Console.WriteLine("\n");

        //     //DataStore<string> store = new();
        //     //DataStore<IMyInterface> store = new DataStore<IMyInterface>();
        //     //DataStore<ArrayList> store = new DataStore<ArrayList>();

        //     /*
        //         WHERE T : NEW()

        //         The following example demonstrates the struct constraint that restricts type 
        //         argument to be non-nullable value type only.
        //     */

        //     /*
        //         WHERE T : BASECLASS

        //         The following example demonstrates the base class constraint that restricts 
        //         type argument to be a derived class of the specified class, abstract class, 
        //         or an interface.
        //     */
        // }

        // Generic class with a derived class constraint
        // class DataStoreD<T> where T : IEnumerable
        // {
        //     public T? Data {get; set;}
        // }

        // Generic class with a value type constraint
        class DataStoreC<T> where T : class, new()
        {
            public T? Data {get; set;}
        }

        // Generic class with a struct constraint
        class DataStoreB<T> where T : struct
        {
            public T Data {get; set;}
        }

        // Generic class with a constraint
        class DataStore<T> where T : class
        {
            public T? Data {get; set;}
        }
    }
}