// 18. NULLABLE TYPES

namespace Lesson18
{
    class Program18
    {
        // public static void Main()
        // {
        //     /*
        //         A value type cannot be assigned a null value. 
        //         For example, int i = null will give you a compile time error.

        //         C# 2.0 (2005) introduced nullable types that allow you to assign null to 
        //         value type variables. You can declare nullable types using Nullable<T> 
        //         where T is a type.  
        //     */

        //     /*
        //         int i = null; 
        //         Compiler Error CS0037 : Cannot convert null to 'type' because 'type' is a 
        //         non-nullable value type.
        //     */

        //     Nullable<int> i = null;
        //     Console.WriteLine($"i = {i}.");

        //     /*
        //         A nullable type can represent the correct range of values for its underlying 
        //         value type, plus an additional null value. For example, Nullable<int> can be 
        //         assigned any value from -2 147 483 648 to 2 147 483 647, or a null value.

        //         The Nullable types are instances of System.Nullable<T> struct. 
        //         Think it as something like the following structure (after Main() as comments) :
        //     */

        //     /*
        //         A nullable of type int is the same as an ordinary int plus a flag that says 
        //         whether the int has a value or not (is null or not). The rest is compiler 
        //         operations that treat "null" as a valid value.
        //     */

        //     Nullable<int> nb = null;

        //     if (nb != null)
        //     {
        //         Console.WriteLine($"nb = {nb}.");
        //     }

        //     else
        //     {
        //         Console.WriteLine("nb is null.");
        //     }

        //     /*
        //         Use the GetValueOrDefault() method to get an actual value if it's not null 
        //         and the default value if it is. For example :
        //     */

        //     Nullable<int> nb2 = null;

        //     Console.WriteLine($"nb2.GetValueOrDefault() = {nb2.GetValueOrDefault()}.");

        //     /*
        //         SHORTHAND SYNTAX FOR NULLABLE TYPES

        //         You can use the '?' operator to shorthand the syntax like int?, long? instead 
        //         of using Nullable<T>.
        //     */ 

        //     int? nb3 = null;
        //     Console.WriteLine($"nb3 = {nb3}.");

        //     double? db = null;
        //     Console.WriteLine($"db = {db}.");

        //     /*
        //         ??  OPERATOR

        //         Use the ?? operator to assign a nullable type to a non-nullable type.
        //     */

        //     int? nb4 = null;
            
        //     int nb5 = nb4 ?? 10;

        //     Console.WriteLine($"nb5 = {nb5}.");

        //     /*
        //         In the above example, nb4 is a nullable int and if you assign it to the 
        //         non-nullable int nb5, it will throw a runtime exception if nb4 is null. 
        //         To mitigate the risk of an exception, we use the ?? operator to 
        //         specify that if nb4 is null, assign 0 to nb5.
        //     */

        //     /*
        //         ASSIGNEMENT RULES

        //         A nullable type has the same assignment rules as a value type. 
        //         It must be assigned a value before using it if nullable types are declared in 
        //         a function as local variables. If it's a field of any class, it will have 
        //         a null value by default.

        //         For example, the following nullable int is declared and used without 
        //         having value. The compiler will give "Use of unassigned local variable 
        //         'nb6'" error :
        //     */

        //     // Nullable<int> nb7;
        //     // Console.WriteLine($"nb7 = {nb7}.");
        //     // Compiler Error CS0165 : Use of unassigned local variable 'nb7'.

        //     /*
        //         In the following example, a nullable int is a field of a class (after Main()), 
        //         so it will not give any error.
        //     */


        //     MyClass obj = new();

        //     if(obj.id == null)
        //     {
        //         Console.WriteLine("ID of MyClass object is null.");
        //     }    

        //     else
        //     {
        //         Console.WriteLine($"id = {obj.id}.");
        //     }    

        //     /*
        //         NULLABLE HELPER CLASS

        //         Null is considered to be less than any value. So comparison operators won't 
        //         work against null. Consider the following example where i is neither less 
        //         than j, greater than j nor equal to j:
        //     */

        //     int? nb8 = null;
        //     int nb9 = 1;


        //     if (nb8 < nb9)
        //     {
        //         Console.WriteLine("nb8 < nb9");
        //     }

        //     else if(nb8 > nb9)
        //     {
        //         Console.WriteLine("nb8 > nb9");
        //     }
                
        //     else if(nb8 == nb9)
        //     {
        //         Console.WriteLine("nb8 == nb9");
        //     }
                
        //     else
        //     {
        //         Console.WriteLine("Could not compare nb8 and nb9.");
        //     }

        //     /*
        //         Nullable static class is a helper class for Nullable types. 
        //         It provides a compare method to compare nullable types. It also has a 
        //         GetUnderlyingType method that returns the underlying type argument of 
        //         nullable types.
        //     */

        //     int? nb10 = null;
        //     int nb11 = 1;

        //     if(Nullable.Compare<int>(nb10, nb11) < 0)
        //     {
        //         Console.WriteLine("nb10 < nb11");
        //     }
                
        //     else if(Nullable.Compare<int>(nb10, nb11) > 0)
        //     {
        //         Console.WriteLine("nb10 > nb11");
        //     }
                
        //     else
        //     {
        //         Console.WriteLine("nb10 = nb11");
        //     }

        //     /*
        //         CHARACTERISTICS OF NULLABLE TYPES

        //         1. Nullable types can only be used with value types.

        //         2. The Value property will throw an InvalidOperationException if value is null; 
        //         otherwise it will return the value.

        //         3. The HasValue property returns true if the variable contains a value, or 
        //         false if it is null.

        //         4. You can only use == and != operators with a nullable type. For other 
        //         comparison use the Nullable static class.

        //         5. Nested nullable types are not allowed. Nullable<Nullable<int>> i; will 
        //         give a compile time error.
        //     */
        // }

        public class MyClass
        {
            public Nullable<int> id = null;
        }

        // [Serializable]
        // public struct Nullable<T> where T : struct
        // {        
        //     public bool HasValue {get;}
            
        //     public T Value {get;}
        // }
    }
}