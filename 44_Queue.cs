// 44. QUEUE

namespace Lesson44
{
    class Program44
    {
        // public static void Main()
        // {
        //     /*
        //         Queue is a special type of collection that stores the elements in FIFO style 
        //         (First In First Out), exactly opposite of the Stack<T> collection. 
        //         It contains the elements in the order they were added. 
        //         C# includes generic Queue<T> and non-generic Queue collection. 
        //         It is recommended to use the generic Queue<T> collection.
        //     */

        //     /*
        //         QUEUE<T> CHARACTERISTICS

        //         Queue<T> is FIFO (First In First Out) collection.

        //         It comes under System.Collection.Generic namespace.

        //         Queue<T> can contain elements of the specified type. 
        //         It provides compile-time type checking and doesn't perform boxing-unboxing 
        //         because it is generic.

        //         Elements can be added using the Enqueue() method. 
        //         Cannot use collection-initializer syntax.

        //         Elements can be retrieved using the Dequeue() and the Peek() methods. 
        //         It does not support an indexer.
        //     */

        //     /*
        //         CREATING A QUEUE

        //         You can create an object of the Queue<T> by specifying a type parameter for 
        //         the type of elements it can store. The following example creates and adds 
        //         elements in the Queue<T> using the Enqueue() method. A Queue collection 
        //         allows null (for reference types) and duplicate values.
        //     */

        //     Queue<int> callIDs = new Queue<int>();
        //     callIDs.Enqueue(1);
        //     callIDs.Enqueue(2);
        //     callIDs.Enqueue(3);
        //     callIDs.Enqueue(4);

        //     foreach(int id in callIDs)
        //     {
        //         Console.WriteLine($"id in callIDs == {id}.");
        //     }
        //     Console.WriteLine("\n");

        //     /*
        //         QUEUE<T> PROPERTIES AND METHODS:

        //         Property	Usage
        //         Count	    Returns the total count of elements in the Queue.

        //         Method	    Usage
        //         Enqueue(T)	Adds an item into the queue.
        //         Dequeue	    Returns an item from the start of the queue and removes it.
        //         Peek()	    Returns an first item from the queue without removing it.
        //         Contains(T)	Checks whether an item is in the queue or not
        //         Clear()	    Removes all the items from the queue.
        //     */

        //     /*
        //         RETRIEVE ELEMENTS FROM A QUEUE

        //         The Dequeue() and the Peek() method is used to retrieve the first element in 
        //         a queue collection. The Dequeue() removes and returns the first element from 
        //         a queue because the queue stores elements in FIFO order. 
        //         Calling the Dequeue() method on an empty queue will throw the 
        //         InvalidOperation exception. So, always check that the total count of a queue 
        //         is greater than zero before calling it.
        //     */

        //     Queue<string> strQ = new Queue<string>();
        //     strQ.Enqueue("H");
        //     strQ.Enqueue("e");
        //     strQ.Enqueue("l");
        //     strQ.Enqueue("l");
        //     strQ.Enqueue("o");

        //     Console.WriteLine($"strQ.Count == {strQ.Count}.");

        //     while (strQ.Count > 0)
        //     {
        //         Console.WriteLine($"strQ.Dequeue() == {strQ.Dequeue()}.");
        //     }
                
        //     Console.WriteLine($"strQ.Count == {strQ.Count}.");
        //     Console.WriteLine("\n");

        //     /*
        //         The Peek() method always returns the first item from a queue collection 
        //         without removing it from the queue. Calling the Peek() method on an empty 
        //         queue will throw a run-time exception InvalidOperationException.
        //     */

        //     Queue<string> strQ2 = new Queue<string>();
        //     strQ2.Enqueue("G");
        //     strQ2.Enqueue("o");
        //     strQ2.Enqueue("o");
        //     strQ2.Enqueue("d");
        //     strQ2.Enqueue("b");
        //     strQ2.Enqueue("y");
        //     strQ2.Enqueue("e");

        //     Console.WriteLine($"strQ2.Count == {strQ2.Count}.");

        //     if(strQ2.Count > 0)
        //     {
        //         Console.WriteLine($"strQ2.Peek() == {strQ2.Peek()}.");
        //         Console.WriteLine($"strQ2.Peek() == {strQ2.Peek()}.");
        //     }

        //     Console.WriteLine($"strQ2.Count == {strQ2.Count}.");
        //     Console.WriteLine("\n");

        //     /*
        //         CONTAINS()

        //         The Contains() method checks whether an item exists in a queue or not. 
        //         It returns true if the specified item exists, otherwise returns false.

        //         Contains() Signature: bool Contains(object obj);
        //     */

        //     Queue<int> callIDs2 = new Queue<int>();
        //     callIDs2.Enqueue(26);
        //     callIDs2.Enqueue(27);
        //     callIDs2.Enqueue(28);
        //     callIDs2.Enqueue(29);

        //     Console.WriteLine($"callIDs2.Contains(28) == {callIDs2.Contains(28)}.");
        //     Console.WriteLine($"callIDs2.Contains(21) == {callIDs2.Contains(21)}.");
        // }   
    }
}