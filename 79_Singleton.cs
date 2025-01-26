// 79. SINGLETON

namespace Lesson79
{
    class Program79
    {
        // public static void Main()
        // {
        //     /*
        //         The singleton design pattern is a creational design pattern.
        //     */

        //     /*
        //         PURPOSE

        //         The purpose of the singleton design pattern is to ensure that a class only 
        //         has one instance and provide a global point of access to it throughout the 
        //         life of an application. Access of one instance is preferred to avoid 
        //         unexpected results.
        //     */

        //     /*
        //         USAGE

        //         There might be some functionality where you want to do some synchronous 
        //         activity. For example, you want to take a user's vote on something wherein 
        //         you don't want double counting and also missed any counting of the vote. 
        //         Here, you can use the singleton pattern with a Vote class to make sure only
        //         one instance of the Vote class is created and used to count each user's vote.

        //         There are other scenarios where you can use the singleton pattern. 
        //         For example, you can implement logging functionality in your application 
        //         using the singleton pattern where one global instance of the logger class is 
        //         used to log all information throughout the application.
        //     */

        //     /*
        //         SINGLETON CLASS STRUCTURE

        //         A class should have the following structure for singleton pattern:

        //         Should have a private or protected constructor. No public and parameterized 
        //         constructors.

        //         Should have a static property (with a private backing field) to return an 
        //         instance of a class. A static method can also be used to return an instance.

        //         At least have one non-static public method for a singleton operation.

        //         The following is the basic structure of the singleton class in C#.
        //     */

        //     /*
        //         The below singleton class uses the static property to return an instance of 
        //         the class. It has a private parameterless constructor which will restrict the 
        //         creation of an object using the new keyword. You must use the Instance 
        //         property to get its object. You can make the constructor protected if you 
        //         want to allow it to be inherited in a subclass.

        //         The following checks whether the below Singleton class returns a single 
        //         instance every time.
        //     */

        //     Singleton s1 = Singleton.Instance;
        //     Singleton s2 = Singleton.Instance;

        //     Console.WriteLine($"\"s1 == s2\" == {s1 == s2}.");

        //     /*
        //         In the above example, s1 and s2 are the same instances. However, the above 
        //         Singleton class is not thread-safe. It may give a wrong result in a 
        //         multi-threaded application.
        //     */

        //     /*
        //         REAL-LIFE SINGLETON CLASS

        //         Let's see a real-life scenario where you can implement the singleton design 
        //         pattern.

        //         Assume that you are taking a user's vote on something in your application. 
        //         Multiple users register their votes from different pages. For this, you can 
        //         use the singleton design pattern, as shown below.
        //     */

        //     /*
        //         The above VoteMachine class is a singleton class where its constructor is 
        //         private and the Instance property returns the same instance every time. 
        //         The RegisterVote() method increases the vote count by 1. The TotalVotes 
        //         property returns the total registered votes.

        //         Let's test the above VoteMachine class in the console app, as shown below.
        //     */

        //     VoteMachine vm1 = VoteMachine.Instance;
        //     VoteMachine vm2 = VoteMachine.Instance;
        //     VoteMachine vm3 = VoteMachine.Instance;

        //     vm1.RegisterVote();
        //     vm2.RegisterVote();
        //     vm3.RegisterVote();

        //     Console.WriteLine("\n");

        //     Console.WriteLine($"vm1.TotalVotes == {vm1.TotalVotes}.");
        //     Console.WriteLine($"vm2.TotalVotes == {vm2.TotalVotes}.");
        //     Console.WriteLine($"vm3.TotalVotes == {vm3.TotalVotes}.\n");

        //     /*
        //         The VoteMachine singleton class will work perfectly in the synchronous calls 
        //         where each user will register their vote one by one.

        //         Wait a minute, if each user is going to register their vote one by one then 
        //         why do we need a singleton class?

        //         In a real-life scenario, there might be multiple users registering their vote 
        //         asynchronously unknowingly. Let's see how the VoteMachine class behaves in 
        //         parallel voting (multi-threading environment).

        //         The following demonstrates the testing of the VoteMachine class in the 
        //         multi-threaded environment using the Parallel class.
        //     */

        //     var numbers = Enumerable.Range(0, 10);
        //     Console.WriteLine($"numbers == {numbers}.");
            
        //     Parallel.ForEach(numbers, i =>
        //     {                
        //         var vm = VoteMachine.Instance;
        //         vm.RegisterVote();
        //     });
        
        //     Console.WriteLine($"VoteMachine.Instance.TotalVotes == {VoteMachine.Instance.TotalVotes}.");
        //     Console.WriteLine("\n");

        //     /*
        //         The above code executes 10 parallel calls to the RegisterVote() function. 
        //         The output will depend on your local machine. The output may be different 
        //         each time you run it. The output returns the wrong result in the 
        //         multi-threaded calls.

        //         Let's see how to create a thread-safe singleton class.
        //     */

        //     /*
        //         THREAD-SAFE SINGLETON CLASS

        //         Use thread lock before creating an object of a singleton class to make it 
        //         thread-safe.
        //     */

        //     /*
        //         In the above VoteMachine class, we lock the code that creates an instance of 
        //         the VoteMachine class. It means only one thread can enter in the lock and 
        //         execute the code and create an instance. Note that the performance degrades 
        //         as a lock is acquired every time the instance is requested.

        //         Now, let's test the above VoteMachine class in the multi-threaded scenario, 
        //         as shown below.
        //     */

        //     var numbersA = Enumerable.Range(0, 10);
        //     Console.WriteLine($"numbersA == {numbersA}.");
            
        //     Parallel.ForEach(numbers, i =>
        //     {                
        //         var vm = VoteMachine.Instance;
        //         vm.RegisterVote();
        //     });

        //     Console.WriteLine($"VoteMachine.Instance.TotalVotes == {VoteMachine.Instance.TotalVotes}.");
        //     Console.WriteLine("\n");

        //     /*
        //         The output may vary but it will show the correct total votes. Try to run it 
        //         multiple times to ensure the total votes are correct.

        //         To improve the performance, we can double check _instance == null before and 
        //         after lock, as shown below.
        //     */

        //     /*
        //         The below code (if-lock-of) has some issues with the ECMA CLI specification 
        //         without any memory barrier.
        //     */

        //     /*
        //        SINGLETON CLASS USING A STATIC CONSTRUCTOR

        //        You can create a singleton class by using a static constructor. A static 
        //        constructor runs only once per app domain when any static member of a class is 
        //        accessed.
        //     */

        //     /*
        //         The above VoteMachine is a singleton class with a static constructor. 
        //         The private constructor prevents the creation of an instance using the "new" 
        //         keyword.

        //         The above class creates an instance as soon as we access any static property 
        //         or method. If there are multiple static properties or methods for some reason 
        //         then an instance will be created immediately even if we don't intend to use it. 
        //         We need lazy instantiation that will create instances only when necessary.
        //     */

        //     /*
        //         SINGLETON CLASS LAZY INSTANTIATION

        //         If you use .NET 4 (2010) or higher, use Lazy<T> to create an instance only 
        //         when needed.

        //         The code above implicitly uses LazyThreadSafetyMode.ExecutionAndPublication 
        //         as the thread safety mode for the Lazy<VoteMachine>>. The Lazy<T> make the 
        //         lazy instantiation simple and performs well. It also allows you to check 
        //         whether or not the instance has been created yet with the IsValueCreated 
        //         property.
        //     */
        // }

        // Vote Singleton
        public class VoteMachine
        {
            // Lazy instantiation
            // private static readonly Lazy<VoteMachine> _instance = new Lazy<VoteMachine>(() => new VoteMachine());

            // Static constructor
            // private static readonly VoteMachine _instance = new VoteMachine();

            private static VoteMachine? _instance = null;
            private int _totalVotes = 0;

            private static readonly object lockObj = new();
                
            // Parameterless constructor
            private VoteMachine()
            {

            }

            public static VoteMachine Instance
            {
                get
                {
                    // Check that instance is null before locking
                    if(_instance == null)
                    {
                        // Making the instance thread-safe
                        lock(lockObj)
                        {
                            // Check that instance is null after locking
                            if (_instance == null) 
                            {
                                    
                                _instance = new VoteMachine();
                            }
                        }
                    }

                    return _instance;
                }
            }

            public void RegisterVote()
            {
                _totalVotes++;
                Console.WriteLine($"Registered Vote #{_totalVotes}.");
            }

            public int TotalVotes
            {
                get
                {
                    return _totalVotes;
                }
            }
        }   

        // Single Design Pattern Example
        public class Singleton
        {
            private static Singleton? _instance;

            // Parameterless constructor
            private Singleton()
            {
                
            }

            public static Singleton Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }

                    return _instance;
                }
            }

            public void DoSingletonOperation()
            {
                Console.WriteLine("Singleton operation.\n");
            }
        }
    }
}
