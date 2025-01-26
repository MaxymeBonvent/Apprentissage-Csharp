// 35. GENERICS

namespace Lesson35
{
    class Program35
    {
        // public static void Main()
        // {
        //     /*
        //         Generic means the general form, not specific. In C#, generic means not 
        //         specific to a particular data type.

        //         C# allows you to define generic classes, interfaces, abstract classes, 
        //         fields, methods, static methods, properties, events, delegates, and operators 
        //         using the type parameter and without the specific data type. A type parameter 
        //         is a placeholder for a particular type specified when creating an instance of 
        //         the generic type.

        //         A generic type is declared by specifying a type parameter in an angle brackets 
        //         after a type name, e.g. TypeName<T> where T is a type parameter.
        //     */

        //     /*
        //         GENERIC CLASS

        //         Generic classes are defined using a type parameter in an angle brackets after 
        //         the class name. The following defines a generic class.
        //     */

        //     /*
        //         Below, DataStore<T> is a generic class. T is called type parameter, which 
        //         can be used as a type of field, property, method parameter, return type, 
        //         and delegate in the DataStore class. For example, Data is a generic property 
        //         because we have used a type parameter T as its type instead of a specific 
        //         data type.

        //         It is not required to use T as a type parameter.
        //         You can give any name to a type parameter. Generally, T is used when there 
        //         is only one type parameter. It is recommended to use a more readable type 
        //         parameter name as per requirement like TSession, TKey, TValue etc.

        //         You can also define multiple type parameters separated by a comma.
        //     */

        //     /*
        //         INSTANTIATING A GENERIC CLASS

        //         You can create an instance of generic classes by specifying an actual type in 
        //         angle brackets. The following creates an instance of the generic class 
        //         DataStore.
        //     */

        //     DataStore<string> store = new DataStore<string>();
        //     Console.WriteLine($"store = {store}.");

        //     /*
        //         Above, we specified the string type in the angle brackets while creating an 
        //         instance. So, T will be replaced with a string type wherever T is used in the 
        //         entire class at compile-time. Therefore, the type of Data property would be a 
        //         string.
        //     */

        //     /*
        //         You can assign a string value to the Data property. 
        //         Trying to assign values other than string will result in a compile-time error.
        //     */

        //     store.Data = "Hello";
        //     Console.WriteLine($"store.Data = {store.Data}.");

        //     Console.WriteLine("\n");


        //     DataStore<string> store2 = new DataStore<string>();
        //     /*
        //         store2.Data = 0; 
        //         Compile Error CS0029 : Cannot implicitly convert type 'type' to 'type'.
        //     */

        //     /*
        //         You can specify different data types for different objects, 
        //         as shown below.
        //     */        

        //     DataStore<string> strStore = new DataStore<string>();
        //     strStore.Data = "Hello World!";
        //     //strStore.Data = 123; // compile-time error
        //     Console.WriteLine($"strStore.Data = {strStore.Data}.");


        //     DataStore<int> intStore = new DataStore<int>();
        //     intStore.Data = 100;
        //     //intStore.Data = "Hello World!"; // compile-time error
        //     Console.WriteLine($"intStore.Data = {intStore.Data}.");


        //     KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
        //     kvp1.Key = 100;
        //     kvp1.Value = "Hundred";
        //     Console.WriteLine($"kvp1.Key = {kvp1.Key}, kvp1.Value = {kvp1.Value}");


        //     KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
        //     kvp2.Key = "IT";
        //     kvp2.Value = "Information Technology";
        //     Console.WriteLine($"kvp2.Key = {kvp2.Key}, kvp2.Value = {kvp2.Value}");

        //     Console.WriteLine("\n");

        //     /*
        //         GENERIC CLASS CHARACTERISTICS

        //         A generic class increases the reusability. 
        //         The more type parameters mean more reusable it becomes. 
        //         However, too much generalization makes code difficult to understand and
        //         maintain.

        //         A generic class can be a base class to other generic or non-generic classes 
        //         or abstract classes.

        //         A generic class can be derived from other generic or non-generic interfaces, 
        //         classes, or abstract classes.
        //     */

        //     /*
        //         GENERIC FIELDS

        //         A generic class can include generic fields. 
        //         However, it cannot be initialized.
        //     */

        //     // The following declares a generic array.

        //     /*
        //         GENERIC METHODS

        //         A method declared with the type parameters for its return type or parameters 
        //         is called a generic method.
        //     */

        //     /*
        //         Below, the AddOrUpdate() and GetData() methods are generic methods. 
        //         The actual data type of the item parameter will be specified at the time of 
        //         instantiating the DataStore<T> class, as shown below.
        //     */

        //     DataStoreD<string> cities = new DataStoreD<string>();
        //     cities.AddOrUpdate(0, "Mumbai");
        //     cities.AddOrUpdate(1, "Chicago");
        //     cities.AddOrUpdate(2, "London");

        //     DataStoreD<int> empIds = new DataStoreD<int>();
        //     empIds.AddOrUpdate(0, 50);
        //     empIds.AddOrUpdate(1, 65);
        //     empIds.AddOrUpdate(2, 89);

        //     /*
        //         The generic parameter type can be used with multiple parameters with or 
        //         without non-generic parameters and return type. The followings 
        //         (commented methods in DataStoreD) are valid generic method overloading.
        //     */

        //     /*
        //         A non-generic class can include generic methods by specifying a type 
        //         parameter in angle brackets with the method name, as shown below.
        //     */

        //     Printer printer = new ();

        //     printer.Print<int>(100);
        //     printer.Print(200);
        //     printer.Print<string>("Hello");
        //     printer.Print("World.");

        //     Console.WriteLine("\n");

        //     /*
        //         ADVANTAGES OF GENERICS

        //         1. Generics increase the reusability of the code. You don't need to write 
        //         code to handle different data types.

        //         2. Generics are type-safe. You get compile-time errors if you try to use a 
        //         different data type than the one specified in the definition.

        //         3. Generic has a performance advantage because it removes the possibilities 
        //         of boxing and unboxing.
        //     */
        // }

        // Non-generic class
        class Printer
        {
            // Generic method
            public void Print<T>(T? data)
            {
                Console.WriteLine(data);
            }
        }

        // Generic class D
        class DataStoreD<T>
        {
            private T[] _data = new T[10];
            
            // Generic method
            public void AddOrUpdate(int index, T item)
            {
                if(index >= 0 && index < 10)
                {
                    _data[index] = item;
                }
            }

            // Generic method
            public T? GetData(int index)
            {
                if(index >= 0 && index < 10)
                {
                    return _data[index];
                }
                    
                else
                {
                    return default(T);
                }
            }

            /*
                public void AddOrUpdate(int index, T data) {}
                public void AddOrUpdate(T data1, T data2) {}
                public void AddOrUpdate<U>(T data1, U data2) {}
                public void AddOrUpdate(T data) {}
            */
        }

        // Generic class C
        class DataStoreC<T>
        {
            // Generic array
            public T[]? data = new T[10];
        }

        // Generic class B
        class DataStoreB<T>
        {
            // Generic field
            public T? data = default;
        }

        // Generic class with multiple type parameters
        class KeyValuePair<TKey, TValue>
        {
            public TKey? Key {get; set;}
            public TValue? Value {get; set;}
        }

        // Generic class
        class DataStore<T>
        {
            // Generic property
            public T? Data {get; set;}
        }
    }
}