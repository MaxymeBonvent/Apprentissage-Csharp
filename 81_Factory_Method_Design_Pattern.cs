// 81. FACTORY METHOD DESIGN PATTERN

namespace Lesson81
{
    class Program81
    {
        // public static void Main()
        // {
        //     /*
        //         You will learn about the Factory Method design pattern and its implementation 
        //         in C# along with real-world example to understand how you can use this 
        //         pattern in your application.

        //         Factory method pattern is a creational design pattern that provides an 
        //         interface for creating objects but allows subclasses to decide which class to 
        //         instantiate. By using this pattern, you can encapsulate object creation logic 
        //         in a separate method of a subclass. This can be useful in situations where 
        //         the type of object that needs to be created may vary depending on certain 
        //         conditions.
        //     */

        //     /*
        //         STRUCTURE OF THE FACTORY METHOD DESIGN PATTERN

        //         The Factory Method pattern consists of the following components:

        //         1. Creator: This is an abstract class or interface that declares the factory 
        //         method. It also provides an interface for creating products.

        //         2. Concrete Creator: This is a class that extends the Creator and implements 
        //         the factory method. It decides which concrete class to create.

        //         3. Product: This is an abstract class or interface that defines the interface 
        //         of the objects created by the factory.

        //         4. Concrete Product: These are the classes that implement the Product 
        //         interface.
        //     */

        //     /*
        //         IMPLEMENTING THE FACTORY METHOD DESIGN PATTERN

        //         To implement the Factory Method pattern in C#, you need to create an abstract 
        //         class or interface for the Creator and Product. Then, you can create concrete 
        //         classes that inherit from these abstract classes or implement the interface.

        //         In the Creator class, you define the factory method which must be abstract 
        //         method that returns an instance of the Product. Each subclass of the Creator 
        //         can override this method to return a different ConcreteProduct.

        //         The following example demonstrates how to implement the Factory Method 
        //         pattern in C#:
        //     */

        //     Creator creator = new ConcreteCreator1();
		//     creator.UseProduct();

        //     Console.WriteLine("\n");

		//     Creator creator2 = new ConcreteCreator2();
		//     creator2.UseProduct();

        //     Console.WriteLine("\n");

        //     /*
        //         In the above code, we have defined the IProduct interface and two concrete 
        //         product classes, ConcreteProduct1 and ConcreteProduct2. The Creator is an 
        //         abstract class that declares the abstract method FactoryMethod(), which needs 
        //         to be implemented by a class that inherit the Creator class.

        //         The ConcreteCreator1 and ConcreteCreator2 classes extend the Creator class 
        //         and implement the factory method to create ConcreteProduct1 and 
        //         ConcreteProduct2 instances, respectively.

        //         Finally, inside the Main(), the client code creates instances of 
        //         ConcreteCreator1 and ConcreteCreator2 and calls UseProduct() method which 
        //         internally calls the FactoryMethod() to create an instances of 
        //         ConcreteProduct1 and ConcreteProduct2 respectively and then calls the 
        //         Execute() method on them.

        //         The abstract creator class doesn't directly handle the product creation logic, 
        //         it calls the factory method to create concrete products. Therefore, the 
        //         client code is decoupled from the actual objects it works with, allowing for 
        //         flexibility in the types of objects that are created.

        //         Now, let's see how the Factory Method pattern can be applied in a real-world 
        //         example.
        //     */

        //     /*
        //         REAL-WORLD EXAMPLE OF THE FACTORY METHOD DESIGN PATTERN

        //         Consider a scenario where you are developing a Data Analysis Engine for an 
        //         application. The engine needs to process data from different databases, such 
        //         as SQL Server and Oracle. Instead of tightly coupling the engine with 
        //         specific database implementations, you can use the Factory Method pattern to 
        //         create the appropriate database objects based on the user's configuration.
        //     */

        //     DataAnalysisEngine dbEngine1 = new SqlServerDataAnalysisEngine();
        //     dbEngine1.ProcessData("Query to process data.");

        //     Console.WriteLine("\n");
		
        //     DataAnalysisEngine dbEngine2 = new OracleDataAnalysisEngine();
        //     dbEngine2.ProcessData("Query to process data.");

        //     Console.WriteLine("\n");

        //     /*
        //         In the above code, we have defined a product interface IDatabase and two 
        //         concrete product classes: SqlServerDatabase and OracleDatabase. 
        //         The DataAnalysisEngine is an abstract class that declares the factory method 
        //         CreateDatabase(), which returns an instance of the IDatabase interface. 
        //         The SqlServerDataAnalysisEngine and OracleDataAnalysisEngine are concrete 
        //         creator classes that extend the creator class DataAnalysisEngine and 
        //         implement the factory method to create the respective database objects.

        //         Now, when you want to process data using the Data Analysis Engine, you can 
        //         create an instance of the appropriate concrete creator based on the user's 
        //         configuration. The engine will then use the factory method to create the 
        //         corresponding database object and perform the required operations.
        //     */

        //     /*
        //         ADVANTAGES OF USING THE FACTORY METHOD DESIGN PATTERN

        //         It provides a way to delegate the object creation to subclasses, ensuring 
        //         that the Creator class does not have to know the exact class of the objects 
        //         it creates.

        //         It allows for easy extensibility, as new subclasses of the Creator can be 
        //         created without modifying the existing code.

        //         It promotes code reusability, as the client code can work with different 
        //         instances of the Product interface without being aware of their specific 
        //         implementations.

        //         It promotes loose coupling between classes, making it easier to substitute 
        //         different concrete implementations of the Product without affecting the 
        //         client code.

        //         It follows the Open/Closed Principle, allowing for easy addition of new types 
        //         of objects without modifying existing code.

        //         It improves code maintainability and readability by separating object 
        //         creation logic from the client code.

        //         In conclusion, the Factory Method design pattern is a powerful tool for 
        //         decoupling object creation logic from the client code. It allows subclasses 
        //         to decide which class to instantiate, providing flexibility and extensibility 
        //         to the application. By understanding the components and real-world examples 
        //         of the Factory Method pattern, you can effectively apply it in your C# 
        //         projects to improve code maintainability and scalability.
        //     */
        // }

        // Product
        public interface IDatabase
        {
            void Connect();
            void ExecuteQuery(string query);
        }

        // Concrete Product: SQL Server
        public class SqlServerDatabase : IDatabase
        {
            public void Connect()
            {
                Console.WriteLine("Connecting to SQL Server database...");
            }

            public void ExecuteQuery(string query)
            {
                Console.WriteLine("Executing query in SQL Server database: " + query);
            }
        }

        // Concrete Product: Oracle
        public class OracleDatabase : IDatabase
        {
            public void Connect()
            {
                Console.WriteLine("Connecting to Oracle database...");
            }

            public void ExecuteQuery(string query)
            {
                Console.WriteLine("Executing query in Oracle database: " + query);
            }
        }


        // Creator
        public abstract class DataAnalysisEngine
        {
            public abstract IDatabase CreateDatabase();

            public void ProcessData(string query)
            {
                IDatabase database = CreateDatabase();
                database.Connect();
                database.ExecuteQuery(query);
            }
        }

        // Concrete Creator: SQL Server
        public class SqlServerDataAnalysisEngine : DataAnalysisEngine
        {
            public override IDatabase CreateDatabase()
            {
                return new SqlServerDatabase();
            }
        }

        // Concrete Creator: Oracle
        public class OracleDataAnalysisEngine : DataAnalysisEngine
        {
            public override IDatabase CreateDatabase()
            {
                return new OracleDatabase();
            }
        }

        // Product
        public interface IProduct
        {
            void Execute();
        }

        // Concrete Product 1
        public class ConcreteProduct1 : IProduct
        {
            public void Execute()
            {
                Console.WriteLine("Executing ConcreteProduct1.");
            }
        }

        // Concrete Product 2
        public class ConcreteProduct2 : IProduct
        {
            public void Execute()
            {
                Console.WriteLine("Executing ConcreteProduct2.");
            }
        }

        // Creator
        public abstract class Creator
        {
            public abstract IProduct FactoryMethod();
            public void UseProduct()
            {
                IProduct product = FactoryMethod();
                product.Execute();
            }
        }

        // Concrete Creator 1
        public class ConcreteCreator1 : Creator
        {
            public override IProduct FactoryMethod()
            {
                Console.WriteLine("Creating ConcreteProduct1 object from the subclass ConcreteProduct1");
                return new ConcreteProduct1();
            }
        }

        // Concrete Creator 2
        public class ConcreteCreator2 : Creator
        {
            public override IProduct FactoryMethod()
            {
                Console.WriteLine("Creating ConcreteProduct2 object from the subclass ConcreteProduct2");
                return new ConcreteProduct2();
            }
        }
    }
}