// 80. ABSTRACT FACTORY

namespace Lesson80
{
    class Program80
    {
        // public static void Main()
        // {
        //     /*
        //       In this article, you will learn about the Abstract Factory design pattern, its 
        //       components, and a real-world example in C# to understand how it can be used in 
        //       practical scenarios.  
        //     */

        //     /*
        //         ABSTRACT FACTORY DEFINITION

        //         The Abstract Factory design pattern is a creational pattern that provides an 
        //         interface for creating families of related or dependent objects without 
        //         specifying their concrete classes. It allows the client code to create 
        //         objects of different types that belong to the same family.

        //         Here, related or dependent objects means a group of objects that are designed 
        //         to be used together to achieve a common goal. It emphasizes the idea that 
        //         certain objects should be created together as a cohesive group. The abstract 
        //         factory provides an abstract class or an interface for creating these 
        //         objects, and concrete factories implement this abstract class or interface to 
        //         produce specific families of related or dependent objects.
        //     */

        //     /*
        //         ABSTRACT FACTORY COMPONENTS

        //         The following are the components of the Abstract Factory design pattern:  

        //         1. Abstract Factory: This can be an abstract class or an interface that 
        //         declares the methods for creating the objects of the related abstract products.

        //         2. Concrete Factories: These are the classes that implement the Abstract 
        //         Factory interface or abstract class and provide the implementation for 
        //         creating the objects of abstract products.

        //         3. Abstract Products: These are the abstract classes or interfaces that 
        //         define the common behavior for the related or dependent products that the 
        //         abstract factory can create.

        //         4. Concrete Product: These are the classes that implement the Abstract 
        //         Product interfaces or abstract classes and provide the implementation for 
        //         abstract products. The concrete factories will create and return objects of 
        //         these classes.

        //         5. Client: This is a class that uses the Abstract Factory to create the 
        //         objects of the products. It does not create objects of concrete products 
        //         using the "new" keyword instead it uses abstract factory objects to get the 
        //         objects of the concrete products.

        //         The following diagram shows the abstract factory components and relation 
        //         between them.

        //         Let's start with creating abstract product interfaces and concrete product 
        //         classes. Remember that concrete products should be related or dependent 
        //         classes to implement a common functionality.
        //     */

        //     /*
        //         In the above code, the abstract products IAbstractProductA and 
        //         IAbstractProductB are interfaces that define the methods that the concrete 
        //         products must implement. Note that IAbstractProductB contains a method that 
        //         communicates with IAbstractProductA just to showcase they are dependent or 
        //         related products.

        //         The concrete products ConcreteProductA1, ConcreteProductA2, 
        //         ConcreteProductB1, and ConcreteProductB2 implement the respective abstract 
        //         product interfaces. They provide the specific implementations of the 
        //         operations defined in the interfaces.

        //         So, these are our related product implementations to achieve some 
        //         functionality. Now, let's create an Abstract Factory and concrete factory 
        //         that creates and returns objects of the above concrete products, as shown 
        //         below.
        //     */

        //     /*
        //         In the above code, the IAbstractFactory interface represents an abstract 
        //         factory, which defines the methods CreateProductA() and CreateProductB() to 
        //         create instances of IAbstractProductA and IAbstractProductB, respectively. 
        //         Note that you may take an Abstract Class instead of an interface depending on 
        //         your requirements.

        //         The concrete factories ConcreteFactory1 and ConcreteFactory2 implement the 
        //         IAbstractFactory interface and override the methods to create two concrete 
        //         products.

        //         Now, let's see how the client class uses this abstract factory to get the 
        //         objects of the concrete products.
        //     */

        //     /*
        //         The Client class receives an instance of the abstract factory in its 
        //         constructor. It then uses the factory to create instances of the abstract 
        //         products (IAbstractProductA and IAbstractProductB). The client can execute 
        //         operations on the created products.
        //     */

        //     Console.WriteLine("Using factory1");
        //     IAbstractFactory factory1 = new ConcreteFactory1();
        //     Client client1 = new(factory1);
        //     client1.Execute();

        //     Console.WriteLine("\n");
            
        //     Console.WriteLine("Using factory2");
        //     IAbstractFactory factory2 = new ConcreteFactory2();
        //     Client client2 = new(factory2);
        //     client2.Execute();

        //     Console.WriteLine("\n");

        //     /*
        //         The Main method demonstrates the usage of the abstract factory pattern by 
        //         creating instances of different factories (ConcreteFactory1 and 
        //         ConcreteFactory2) and passing them to the Client constructor. The client then 
        //         uses these factories to create and execute the products.

        //         Now, let's create a new example of DBConnectionFactory based on the abstract 
        //         factory pattern.
        //     */

        //     /*
        //         REAL-WORLD EXAMPLE:

        //         Let's consider a real-world example wherein you access multiple databases in 
        //         your application. Assume that you need to connect to two databases SQL Server, 
        //         and PostgreSQL databases to save or retrieve some data in your application. 
        //         We can use the Abstract Factory design pattern to create the database 
        //         factories and other components in this scenario.
        //     */

        //     Console.WriteLine("Using SQL Server Factory");
		//     IDBFactory sqlServerFactory = new SQLServerFactory();
		//     DBQueryClient sqlServerClient = new(sqlServerFactory);
		//     sqlServerClient.ExecuteQuery("SELECT * FROM Customers");

        //     Console.WriteLine("\n");

		//     Console.WriteLine("Using PostgreSQL Factory");
		//     IDBFactory postgreFactory = new PostGreSQLFactory();
		//     DBQueryClient postgreClient = new(postgreFactory);
		//     postgreClient.ExecuteQuery("SELECT * FROM Customers");

        //     Console.WriteLine("\n");

        //     /*
        //         In the above example, we have defined two abstract product interfaces: 
        //         IDBConnection and IDBCommand. The IDBConnection defines methods to connect 
        //         with the database and IDBCommand defines methods to execute queries to the 
        //         database. These are dependent abstract products because the IDBCommand would 
        //         need an IDBConnection object to execute the query.

        //         Next, the SQLServerDBConnection and PostgreDBConnection are concrete product 
        //         classes that implement the IDBConnection interface. Both classes implement 
        //         the Connect method to establish a connection to the corresponding database.

        //         Similarly, the SQLServerDBCommand and PostgreDBCommand are concrete product 
        //         classes that implement the IDBCommand interface. These classes implement the 
        //         Execute method to execute queries on the respective databases.

        //         An abstract factory interface named IDBFactory. This interface defines the 
        //         factory methods responsible for creating instances of IDBConnection and 
        //         IDBCommand.

        //         The SQLServerFactory and PostGreSQLFactory are concrete factories that 
        //         implement the CreateConnection and CreateCommand methods to create instances 
        //         of the corresponding concrete product classes.

        //         Now, the DBQueryClient is the client class that queries the database 
        //         depending upon the factory class that is passed. This class accepts an 
        //         instance of the abstract factory in its constructor and uses it to create 
        //         concrete product instances. The DBQueryClient then utilizes the created 
        //         IDBConnection and IDBCommand objects to execute queries on the database.

        //         Finally, in the Main method, the code demonstrates the usage of the abstract 
        //         factory and created objects. It creates a client using the SQLServerFactory, 
        //         executes a query using the created objects, and then repeats the process with 
        //         the PostgreSQLFactory.

        //         Through this implementation, the Abstract Factory pattern provides an 
        //         interface for creating families of related objects without specifying their 
        //         concrete classes, allowing the client to use any of the available families 
        //         interchangeably.

        //         Thus, the Abstract Factory design pattern provides a way to create families 
        //         of related or dependent objects without specifying their concrete classes. 
        //         It promotes loose coupling and allows for easy extensibility and flexibility 
        //         in creating objects. By using the Abstract Factory pattern, you can easily 
        //         switch between different families of objects in your application without 
        //         affecting the client code.
        //     */
        // }

        //Abstract Product
        interface IDBConnection
        {
            void Connect();
        }

        //Concrete Product
        class SQLServerDBConnection : IDBConnection
        {
            public void Connect()
            {
                Console.WriteLine("Connected to SQL Server database...");
            }
        }

        //Concrete Product
        class PostgreDBConnection : IDBConnection
        {
            public void Connect()
            {
                Console.WriteLine("Connected to PostGre database.");
            }
        }

        //Abstract Product
        interface IDBCommand
        {
            void Execute(string query, IDBConnection con);
        }

        //Concrete Product
        class SQLServerDBCommand : IDBCommand
        {
            public void Execute(string query, IDBConnection con)
            {
                con.Connect();
                Console.WriteLine("Executing SQL Server query: " + query);
            }
        }

        //Concrete Product
        class PostgreDBCommand : IDBCommand
        {
            public void Execute(string query, IDBConnection con)
            {
                con.Connect();
                Console.WriteLine("Executing PostGreSQL Server query: " + query);
            }
        }

        //Abstract Factory
        interface IDBFactory
        {
            IDBConnection CreateConnection();
            IDBCommand CreateCommand();
        }

        //Concrete Factory for SQL Server
        class SQLServerFactory : IDBFactory
        {
            public IDBConnection CreateConnection()
            {
                return new SQLServerDBConnection();
            }

            public IDBCommand CreateCommand()
            {
                return new SQLServerDBCommand();
            }
        }

        // Concrete Factory for PostgreSQL
        class PostGreSQLFactory : IDBFactory
        {
            public IDBConnection CreateConnection()
            {
                return new PostgreDBConnection();
            }

            public IDBCommand CreateCommand()
            {
                return new PostgreDBCommand();
            }
        }

        //Client
        class DBQueryClient
        {
            private IDBConnection _connection;
            private IDBCommand _command;

            public DBQueryClient(IDBFactory factory)
            {
                _connection = factory.CreateConnection();
                _command = factory.CreateCommand();
            }

            public void ExecuteQuery(string query)
            {		
                _command.Execute(query, _connection);
            }
        }


        // Client
        class Client
        {
            private readonly IAbstractProductA _productA;
            private readonly IAbstractProductB _productB;

            // Constructor
            public Client(IAbstractFactory factory)
            {
                _productA = factory.CreateProductA();
                _productB = factory.CreateProductB();
            }

            // Method
            public void Execute()
            {
                _productA.ExecuteProductA();
                _productB.ExecuteProductB(_productA);
            }
        }

        // Abstract Factory
        interface IAbstractFactory
        {
            IAbstractProductA CreateProductA();
            IAbstractProductB CreateProductB();
        }

        // Concrete Factory 1
        class ConcreteFactory1 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            {
                return new ConcreteProductA1();
            }

            public IAbstractProductB CreateProductB()
            {
                return new ConcreteProductB1();
            }
        }

        // Concrete Factory 2
        class ConcreteFactory2 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            {
                return new ConcreteProductA2();
            }

            public IAbstractProductB CreateProductB()
            {
                return new ConcreteProductB2();
            }
        }

        // Abstract Product A
        interface IAbstractProductA
        {
            void ExecuteProductA();
        }

        // Concrete Product A1
        class ConcreteProductA1 : IAbstractProductA
        {
            public void ExecuteProductA()
            {
                Console.WriteLine("Executing ConcreteProductA1.");
            }
        }

        // Concrete Product A2
        class ConcreteProductA2 : IAbstractProductA
        {
            public void ExecuteProductA()
            {
                Console.WriteLine("Executing ConcreteProductA2.");
            }
        }

        // Abstract Product B
        interface IAbstractProductB
        {
            void ExecuteProductB(IAbstractProductA prodA);
        }

        // Concrete Product B1
        class ConcreteProductB1 : IAbstractProductB
        {
            public void ExecuteProductB(IAbstractProductA prodA)
            {
                Console.WriteLine("Inside ConcreteProductB1.");
                prodA.ExecuteProductA();
            }
        }

        // Concrete Product B2
        class ConcreteProductB2 : IAbstractProductB
        {
            public void ExecuteProductB(IAbstractProductA prodA)
            {
                Console.WriteLine("Inside ConcreteProductB2.");
                prodA.ExecuteProductA();
            }
        }
    }
}