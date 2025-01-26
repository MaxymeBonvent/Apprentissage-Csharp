// 13. STRUCT

namespace Lesson13
{
    class Program13
    {
        // Structs must be declared outside of Main()
        struct Coordinate
        {
            // Fields
            public int x;
            public int y;

            // Auto-implemented property
            public int z {get; set;}

            // Method
            public void SetOrigin()
            {
                this.x = 0;
                this.y = 0;
            }

            // Static method
            public static Coordinate GetOrigin()
            {
                return new Coordinate();
            }

            // Constructor
            public Coordinate()
            {

            }
        }

        // Struct with an event
        struct CoordinateEvent
        {
            // Fields
            private int _x, _y;

            public int x 
            {
                get
                {
                    return _x;
                }

                set
                {
                    _x = value;
                    CoordinatesChanged(_x);
                }
            }

            public int y
            {
                get
                {
                    return _y;
                }

                set
                {
                    _y = value;
                    CoordinatesChanged(_y);
                }
            }

            // If integers x or y are changed, an event is declared
            public event Action<int> CoordinatesChanged;
        }

        // public static void Main()
        // {
        //     /*
        //         In C#, struct is the value type data type that represents data structures. 
        //         It can contain a parameterized constructor, static constructor, constants, 
        //         fields, methods, properties, indexers, operators, events, and nested types.

        //         struct can be used to hold small data values that do not require inheritance, 
        //         like coordinate points, key-value pairs, and complex data structures.

        //         STRUCTURE DECLARATION

        //         A structure is declared using struct keyword. The default modifier is 
        //         internal for the struct and its members.

        //         The following example declares a structure Coordinate for a graph.
        //     */

        //     // Console.WriteLine(Coordinate);

        //     /*
        //         Compiler Error CS0119 : 
        //         'construct1_name' is a 'construct1', which is not valid in the given context.
        //     */

        //     /*
        //         A struct object can be created with or without the "new" operator, same as 
        //         primitive type variables.
        //     */

        //     Coordinate point = new();
        //     Console.WriteLine($"point.x = {point.x}, point.y = {point.y}.");

        //     /*
        //         Above, an object of the Coordinate structure is created using the new keyword. 
        //         It calls the default parameterless constructor of the struct, which 
        //         initializes all the members to their default value of the specified data type.

        //         If you declare a variable of struct type without using new keyword, it does 
        //         not call any constructor, so all the members remain unassigned. Therefore, you 
        //         must assign values to each member before accessing them, otherwise, it will 
        //         give a compile time error.
        //     */

        //     Coordinate point2;
        //     // Console.WriteLine($"point2.x = {point2.x}, point2.y = {point2.y}.");
        //     /*
        //         Compile Error CS0170 : Use of possibly unassigned field 'field'
        //     */

        //     point2.x = 10;
        //     point2.y = 20;
        //     Console.WriteLine($"point2.x = {point2.x}, point2.y = {point2.y}");

        //     /*
        //         METHODS AND PROPERTIES IN STRUCTURES

        //         A struct can contain properties, auto-implemented properties, methods, 
        //         etc., like classes.
        //     */

        //     Coordinate point3 = new Coordinate();
        //     point3.SetOrigin();
        //     Console.WriteLine($"point3.x = {point3.x}, point3.y = {point3.y}");

        //     // The following (line 8) struct includes a static method.

        //     Coordinate point4 = Coordinate.GetOrigin();
        //     Console.WriteLine($"point4.x = {point4.x}, point4.y = {point4.y}");

        //     /*
        //         EVENTS IN STRUCTURES

        //         A struct can contain events to notify subscribers about some action. 
        //         The following (line 38) struct contains an event.

        //         The above structure contains CoordinatesChanged event, which will be raised 
        //         when x or y changes. The following example demonstrates the 
        //         handling of the CoordinatesChanged event :
        //     */

        //     // New point of the cooridnate struct with an event
        //     CoordinateEvent point5 = new CoordinateEvent();
        
        //     point5.CoordinatesChanged += StructEventHandler;

        //     // Coordinates
        //     point5.x = 10;
        //     point5.y = 20;

        //     // Method to signal that an event happened
        //     static void StructEventHandler(int point)
        //     {
        //         Console.WriteLine("Coordinate changed to {0}.", point);
        //     }

        //     /*
        //         struct is a value type, so it is faster than a class object. Use struct 
        //         whenever you want to just store the data. Generally, structs are good for 
        //         game programming. However, it is easier to transfer a class object than a 
        //         struct. So do not use struct when you are passing data across the wire or to 
        //         other classes.
        //     */

        //     /*
        //         SUMMARY

        //         struct can include constructors, constants, fields, methods, properties, 
        //         indexers, operators, events & nested types.

        //         struct cannot include a parameterless constructor or a destructor.

        //         struct can implement interfaces, same as class.

        //         struct cannot inherit another structure or class, and it cannot be the 
        //         base of a class.

        //         struct members cannot be specified as abstract, sealed, virtual, or protected.
        //     */
        // }
    }
}