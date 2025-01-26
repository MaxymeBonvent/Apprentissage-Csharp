// 43. STACK

namespace Lesson43
{
    class Program43
    {
        // public static void Main()
        // {
        //     /*
        //         Stack is a special type of collection that stores elements in LIFO style 
        //         (Last In First Out). C# includes the generic Stack<T> and non-generic Stack 
        //         collection classes. It is recommended to use the generic Stack<T> collection.

        //         Stack is useful to store temporary data in LIFO style, and you might want to 
        //         delete an element after retrieving its value.
        //     */

        //     /*
        //         STACK<T> CHARACTERISTICS

        //         Stack<T> is Last In First Out collection.

        //         It comes under System.Collection.Generic namespace.

        //         Stack<T> can contain elements of the specified type. 
        //         It provides compile-time type checking and doesn't perform boxing-unboxing 
        //         because it is generic.

        //         Elements can be added using the Push() method. 
        //         Cannot use collection-initializer syntax.

        //         Elements can be retrieved using the Pop() and the Peek() methods. 
        //         It does not support an indexer.
        //     */

        //     /*
        //         CREATING A STACK

        //         You can create an object of the Stack<T> by specifying a type parameter for 
        //         the type of elements it can store. The following example creates and adds 
        //         elements in the Stack<T> using the Push() method. Stack allows null 
        //         (for reference types) and duplicate values.
        //     */

        //     Stack<int> stack = new Stack<int>();
        //     stack.Push(1);
        //     stack.Push(2);
        //     stack.Push(3);
        //     stack.Push(4);

        //     foreach (int item in stack)
        //     {
        //         Console.WriteLine($"item in stack == {item}.");
        //     }

        //     Console.WriteLine("\n");

        //     // You can also create a Stack from an array, as shown below.

        //     int[] arr = new int[]{5, 6, 7, 8};

        //     Stack<int> stack2 = new Stack<int>(arr);

        //     foreach (int item in stack2)
        //     {
        //         Console.WriteLine($"item in stack2 == {item}.");
        //     }

        //     Console.WriteLine("\n");

        //     /*
        //         STACK<T> PROPERTIES AND METHODS:

        //         Property	    Usage
        //         Count	        Returns the total count of elements in the Stack.

        //         Method	        Usage
        //         Push(T)	        Inserts an item at the top of the stack.
        //         Peek()	        Returns the top item from the stack.
        //         Pop()	        Removes and returns items from the top of the stack.
        //         Contains(T)	    Checks whether an item exists in the stack or not.
        //         Clear()	        Removes all items from the stack.
        //     */

        //     /*
        //         POP()

        //         The Pop() method returns the last element and removes it from a stack. 
        //         If a stack is empty, then it will throw the InvalidOperationException. 
        //         So, always check for the number of elements in a stack before calling the 
        //         Pop() method.
        //     */

        //     Stack<int> stack3 = new Stack<int>();
        //     stack3.Push(1);
        //     stack3.Push(2);
        //     stack3.Push(3);
        //     stack3.Push(4);

        //     Console.WriteLine($"Count of stack3 == {stack3.Count}.");
        //     Console.WriteLine("\n");

        //     while (stack3.Count > 0)
        //     {
        //         Console.WriteLine($"stack3.Pop() == {stack3.Pop()}.");
        //     }
        //     Console.WriteLine("\n");

        //     Console.WriteLine($"Count of stack3 == {stack3.Count}.");
        //     Console.WriteLine("\n");

        //     /*
        //         PEEK()

        //         The Peek() method returns the lastly added value from the stack but does not 
        //         remove it. Calling the Peek() method on an empty stack will throw the 
        //         InvalidOperationException. So, always check for elements in the stack before 
        //         retrieving elements using the Peek() method.
        //     */

        //     Stack<int> stack4 = new Stack<int>();
        //     stack4.Push(9);
        //     stack4.Push(10);
        //     stack4.Push(11);
        //     stack4.Push(12);

        //     Console.WriteLine($"Count of stack4 == {stack4.Count}.");
        //     Console.WriteLine("\n");

        //     if(stack4.Count > 0)
        //     {
        //         Console.WriteLine($"stack4.Peek() == {stack4.Peek()}.");
        //     }
        //     Console.WriteLine("\n");

        //     Console.WriteLine($"Count of stack4 == {stack4.Count}.");
        //     Console.WriteLine("\n");

        //     /*
        //         CONTAINS()

        //         The Contains() method checks whether the specified element exists in a Stack 
        //         collection or not. It returns true if it exists, false otherwise.
        //     */

        //     Stack<int> stack5 = new Stack<int>();
        //     stack5.Push(14);
        //     stack5.Push(16);
        //     stack5.Push(17);
        //     stack5.Push(18);

        //     Console.WriteLine($"stack5.Contains(14) == {stack5.Contains(14)}.");
        //     Console.WriteLine($"stack5.Contains(10) == {stack5.Contains(10)}.");
        // }
    }
}