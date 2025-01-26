// 20. INTERFACE

namespace Lesson20
{
    class Program20
    {
        // public static void Main()
        // {
        //     /*
        //         In the human world, a contract between the two or more humans binds them to 
        //         act as per the contract. In the same way, an interface includes the 
        //         declarations of related functionalities. The entities that implement the 
        //         interface must provide the implementation of declared functionalities.

        //         In C#, an interface can be defined using the interface keyword. 
        //         An interface can contain declarations of methods, properties, indexers, and 
        //         events. However, it cannot contain instance fields.

        //         The following interface declares some basic functionalities for the file 
        //         operations.
        //     */

        //     /*
        //         The below declares an interface named IFile. It's recommended to start an 
        //         interface name with the letter "I" at the beginning its name so we know
        //         this is an interface and not a class. The IFile interface contains two 
        //         methods, ReadFile() and WriteFile(string).

        //         An interface can contain declarations of methods, properties, indexers, and 
        //         events.
        //         Default interface methods with implementation body are supported from 
        //         C# 8.0 (2019).
        //         An interface cannot contain constructors and fields.
        //         Interface members are by default abstract and public.

        //         You cannot apply access modifiers to interface members. Although, from C# 8.0 
        //         onwards, you may use private, protected, internal, public, virtual, abstract, 
        //         sealed, static, extern, and partial modifiers on certain conditions.
        //     */   

        //     /*
        //         IMPLEMENTING AN INTERFACE

        //         A class or a struct can implement one or more interfaces using colon (:). 
        //         When implenting an interface, you must override all members of an 
        //         interface.

        //         For example, the following FileInfo class implements the IFile interface, so 
        //         it should override all members of IFile.
        //     */

        //     /*
        //         In the below example, the FileInfo class implements the IFile interface. 
        //         It overrides all members of the IFile interface with the public access 
        //         modifier. The FileInfo class can also contain members other than interface 
        //         members.

        //         Interface members must be implemented with the public modifier, else the 
        //         compiler will give compile-time errors.

        //         You can create an object of the class and assign it to a variable of 
        //         interface type, as shown below.
        //     */

        //     IFile2 file = new FileInfo();
        //     Console.WriteLine($"file = {file}.");

        //     FileInfo file2 = new();
        //     Console.WriteLine($"file2 = {file2}.");

        //     file.ReadFile();
        //     file.WriteFile("Writing to folder.");

        //     Console.WriteLine("\n");

        //     file2.ReadFile();
        //     file2.WriteFile("Writing to folder 2.");

        //     Console.WriteLine("\n");

        //     /*
        //         Above, we created objects of the FileInfo class and assign it to IFile type 
        //         variable and FileInfo type variable. When interface implemented implicitly, 
        //         you can access IFile members with the IFile type variables as well as 
        //         FileInfo type variable.
        //     */

        //     /*
        //         EXPLICIT IMPLEMENTATION

        //         An interface can be implemented explicitly using <InterfaceName>.<MemberName>. 
        //         Explicit implementation is useful when a class is implementing multiple interfaces, 
        //         thereby, it is more readable and eliminates confusion. 
        //         It is also useful if interfaces have the same method name.

        //         Do not use the public access modifier with an explicit implementation. 
        //         It will give a compile-time error.

        //         When you implement an interface explicitly, you can access interface members 
        //         only through an instance of an interface type.
        //     */

        //     /*
        //         IMPLEMENTING MULTIPLE INTERFACES

        //         A class or struct can implement multiple interfaces. 
        //         It must provide the implementation of all members of all interfaces.
        //     */

        //     InterfaceA multiI_A = new ClassMultI();
        //     Console.WriteLine($"multiI_A = {multiI_A}.");
        //     multiI_A.ReadFile();

        //     Console.WriteLine("\n");

        //     InterfaceB multiI_B = new ClassMultI();
        //     Console.WriteLine($"multiI_B = {multiI_B}.");
        //     multiI_B.WriteFile("Writing.");

        //     Console.WriteLine("\n");

        //     /*
        //         Below, ClassMultI implements two interfaces InterfaceA and InterfaceB 
        //         explicitly. It's recommended to implement interfaces explicitly when 
        //         implementing multiple interfaces to avoid confusion and improve readability.
        //     */

        //     /*
        //         DEFAULT INTERFACE METHODS

        //         Until now, we learned that interfaces can only contain method declarations. 
        //         C# 8.0 (2019) added support for virtual extension methods in interfaces with 
        //         concrete implementations.

        //         Virtual interface methods are also called default interface methods and 
        //         do not need to be implemented in a class or struct.
        //     */

        //     /*
        //         In the below InterfaceC interface, ShowName() is the default method. 
        //         Implementation will be the same for all the classes that implement the 
        //         InterfaceC. Note that a class does not inherit default methods from its 
        //         interfaces, so you cannot access them using a class instance.
        //     */

        //     ClassC objC = new ClassC();
        //     Console.WriteLine($"objC = {objC}.");

        //     objC.ReadFile();
        //     objC.WriteFile("Writing.");
        //     objC.ShowName();

        //     /*
        //         MODIFIERS IN INTERFACES

        //         C# 8.0 (2019) allows private, protected, internal, public, virtual, abstract, 
        //         sealed, static, extern, and partial modifiers in an interface.

        //         The default access level for all interface members is public.

        //         An interface member whose declaration includes a body is a virtual member 
        //         unless the sealed or private modifier is used.

        //         A private or sealed function member of an interface must have an 
        //         implementation body. 
        //         Interfaces may declare static members which can be accessed by interface name.
        //     */
        // }

        interface InterfaceC
        {
            void ReadFile();
            void WriteFile(string txt);

            void ShowName()
            {
                Console.WriteLine("I am InterfaceC.");
            }
        }

        // A class must implement all methods of the interface it's using
        class ClassC : InterfaceC
        {
            // Methods that come from interfaces must be public
            public void ReadFile()
            {
                Console.WriteLine("Reading file.");
            }

            // Methods that come from interfaces must be public
            public void WriteFile(string txt)
            {
                Console.WriteLine(txt);
            }

            // Methods that come from interfaces must be public
            public void ShowName()
            {
                Console.WriteLine("I am InterfaceC.");
            }
        }

        interface InterfaceA
        {
            void ReadFile();
        }

        interface InterfaceB
        {
            void WriteFile(string txt);
        }

        class ClassMultI : InterfaceA, InterfaceB
        {
            void InterfaceA.ReadFile()
            {
                Console.WriteLine("Reading file.");
            }

            void InterfaceB.WriteFile(string txt)
            {
                Console.WriteLine(txt);
            }
        }

        // Interfaces must be declared outside of Main()
        interface IFile
        {
            void ReadFile();
            void WriteFile(string text);
        }

        interface IFile2
        {
            void ReadFile(); // Interface member
            void WriteFile(string text); // Interface member
        }

        // Class FileInfo implements interface IFile2
        class FileInfo : IFile2
        {
            public void ReadFile()
            {
                Console.WriteLine("Reading file.");
            }

            public void WriteFile(string text)
            {
                Console.WriteLine(text);
            }
        }

        // Interface
        interface InterfaceName
        {

        }

        // Class with an interface
        class ClassName : InterfaceName
        {

        }
    }
}