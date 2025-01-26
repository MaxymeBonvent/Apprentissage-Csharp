// 75. SO[L]ID: LISKOV SUBSTITUTION PRINCIPLE

namespace Lesson75
{
    class Program75
    {
        // public static void Main()
        // {
        //     /*
        //         Liskov Substitution Principle was introduced by Barbara Liskov in 1987. 
        //         She described this principle in mathematical terms as below:

        //         Let φ(x) be a property provable about objects x of type T. 
        //         Then φ(y) should also be true for objects y of type S where S is a subtype of 
        //         T.

        //         LSP guides how to use inheritance in object-oriented programming. 
        //         It is about subtyping, and how to correctly derive a type from a base type. 
        //         Robert Martin explains LSP as below:

        //         Subtypes must be substitutable for their base type.
        //     */

        //     /*
        //         Here, the type can be interface, class, or abstract class in C#.

        //         Let's simplify it further. A derived class must be correctly substitutable 
        //         for its base class. When you derived a class from a base class then the 
        //         derived class should correctly implement all the methods of the base class. 
        //         It should not remove some methods by throwing NotImplementedException.

        //         Consider the following IMyCollection interface which can be implemented to 
        //         create any type of collection class.
        //     */

        //     /*
        //         The above example violates the Liskov Substitution principle because the 
        //         MyReadOnlyCollection class implements the IMyCollection interface but it 
        //         throws NotImplementedException for two methods Add() and Remove() because the 
        //         MyReadOnlyCollection class is for the read-only collection so you cannot add 
        //         or remove any item. LSP suggests that the subtype must be substitutable for 
        //         the base class or base interface. In the above example, we should create 
        //         another interface for read-only collection without Add() and Remove() methods.
        //     */

        //     /*
        //         Let's understand what is the meaning of "A derived class should correctly 
        //         implement methods of a base class".

        //         Consider the following Rectangle class:
        //     */

        //     /*
        //         Mathematically, a square is the same as a rectangle that has four equal sides. 
        //         We can use inheritance "is-a" relationship here. A square is a rectangle. 
        //         The Square class can inherit the Rectangle class with equal width and height, 
        //         as shown below.
        //     */

        //     // Now, the following returns the wrong results:

        //     Rectangle sqr1 = new Square()
        //     {
        //         Width = 8,
        //         Height = 6
        //     };
            
                    
        //     Rectangle sqr2 = new Square()
        //     {
        //         Width = 6,
        //         Height = 8
        //     };
            
        //     Console.WriteLine(AreaCalculator.RectangleArea(sqr1));
        //     Console.WriteLine(AreaCalculator.RectangleArea(sqr2));

        //     /*
        //         LSP says that the derived class should correctly implement the base class 
        //         methods. Here, the square class is not a subtype of the rectangle class 
        //         because it has equal sides. So, only one property is needed instead of two 
        //         properties, height, and width. It creates confusion for the users of the class 
        //         and might give the wrong result.
        //     */
        // }

        public class Rectangle 
        {
            public virtual int Width {get; set;}
            public virtual int Height {get; set;}
        }

        class Square : Rectangle
        {
            private int _width;
            private int _height;

            public override int Width
            {
                get {return _width;}

                set
                {
                    _width = value;
                    _height = value;
                }
            }

            public override int Height
            {
                get {return _height;}

                set 
                {
                    _height = value; 
                    _width = value;
                }
            }
        }

        // The following calculates the area of a rectangle:
        public class AreaCalculator
        {
            public static int RectangleArea(Rectangle rect)
            { 
                return rect.Width * rect.Height; 
            }
        }

        public interface IMyCollection
        { 
            void Add(int item);
            void Remove(int item);
            int Get(int idex);
        }

        public class MyReadOnlyCollection : IMyCollection
        {
            private readonly IList<int> _collection;

            public MyReadOnlyCollection(IList<int> col)
            {
                _collection = col;
            }

            public void Add(int item)
            {
                throw new NotImplementedException();
            }

            public void Remove(int item)
            {
                throw new NotImplementedException();
            }

            public int Get(int index)
            {
                return _collection[index];
            }
        }
    }
}