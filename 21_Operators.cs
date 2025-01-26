// 21. OPERATORS

namespace Lesson21
{
    class Program21
    {
        // public static void Main()
        // {
        //     /*
        //        Operators in C# are some special symbols that perform actions on operands. 
        //        In mathematics, the plus symbol (+) does the sum of the left and right numbers. 
        //        Similarly, C# includes various operators for different types of operations.

        //         The following example demonstrates the + operator in C#. 
        //     */

        //     int x = 5 + 5;
        //     int y = 10 + x;
        //     int z = x + y;
        //     Console.WriteLine($"z = {z}.");
        //     Console.WriteLine("\n");

        //     /*
        //         In the above example, + operator adds two number literals and assign the 
        //         result to a variable. It also adds the values of two int variables and 
        //         assigns the result to a variable.

        //         Some operators behave differently based on the type of the operands. 
        //         For example, + operator concatenates two strings.
        //     */

        //     string greet1 = "Hello " + "World!";
        //     Console.WriteLine($"greet1 = {greet1}");

        //     string msg = "Hi";
        //     string name = " Pikachu.";

        //     string greet2 = msg + name;
        //     Console.WriteLine($"greet2 = {greet2}");

        //     Console.WriteLine("\n");

        //     /*
        //         There are three types of operators in C# : unary, binary and ternary operators. 
        //         Unary operators act on single operands, binary operators act on two 
        //         operands and ternary operators act on three operands.
        //     */

        //     /*
        //         C# includes the following types of operators:

        //         1. Arithmetic
        //         2. Assignment
        //         3. Comparison
        //         4. Equality
        //         5. Boolean
        //         6. Bitwise and shift
        //         7. Member access
        //         8. Type-cast
        //         9. Pointer related
        //     */

        //     /*
        //         1. ARITHMETIC OPERATORS

        //         he arithmetic operators perform arithmetic operations on all the numeric type 
        //         operands such as sbyte, byte, short, ushort, int, uint, long, ulong, float, 
        //         double, and decimal.

        //         Operator    Name	        Description	                                                       Example	
        //         +	        Addition	    Computes the sum of left and right operands.	                   int x = 5 + 5;
        //         -	        Subtraction	    Subtract the right operand from the left operand	               int x = 5 - 1;
        //         *	        Multiplication	Multiply left and right operand	                                   int x = 5 * 2;
        //         /	        Division	    Divides the left operand by the right operand	                   int x = 10 / 2;
        //         %	        Remainder	    Computes the remainder from dividing right operand by left operand int x = 3 % 2;
        //         ++	        Unary increment Operator increases its operand by 1	                               x++
        //         --	        Unary decrement	Operator decreases its operand by 1	                               x--
        //         +	        Unary plus	    Returns the absolute value of operand	                           +5
        //         -	        Unary minus	    Computes the numeric negation of its operand.	                   -5
        //     */

        //     /*
        //         2. ASSIGNEMENT OPERATORS

        //         The assignment operator , =, assigns its right hand value to its left-hand 
        //         variable, property, or indexer. It can also be used with other arithmetic, 
        //         boolean, and bitwise operators.

        //         Operator    Name                        Description	                                                                            Example	
        //         =	        Assignment	                Assigns its right had value to its left-hand variable, property or indexer.	            x = 10;
        //         x op= y	    Compound assignment	        Short form of x =x op y where op = any arithmetic, boolean, and bitwise operator.	    x += 5;
        //         ??=	        Null-coalescing assignment  C# 8 onwards, ??= assigns value of the right operand only if the left operand is null   x ??= 5;
        //     */

        //     /*
        //         3. COMPARISON OPERATORS

        //         Comparison operators compare two numeric operands and return true or false.

        //         Operator    Name	                    Description	                                                                    Example
        //         <           Less than                   Returns true if the left operand is less than the right operand	                x < y;
        //         >           Greater than                Returns true if the left operand is greater than the right operand	            x > y;
        //         <=          Less than or equal to       Returns true if the left operand is less than or equal to the right operand	    x <= y;
        //         >=          Greater than or equal to    Returns true if the left operand is greater than or equal to the right operand  x >= y;
        //     */

        //     /*
        //         4. EQUALITY OPERATORS

        //         Equality operators check whether two operands are equal or not.

        //         Operator    Name	        Description	                                            Example	
        //         ==          Equal to	    Returns true if operands are equal otherwise false.	    x == y;
        //         !=          Different from	Returns true if operands are different otherwise false. x != y;
        //     */

        //     /*
        //         5. BOOLEAN OPERATORS

        //         Boolean operators perform a logical operation on bool operands.

        //         Operator    Name    Description	                                                                                            Example	
        //         !           Not	    Reverses the result of a bool expression.	                                                            !false
        //         &&          And	    Computes the logical AND of its bool operands. Returns true if both are true, false otherwise.	        x && y;
        //         ||	        Or      Computes the logical OR of its bool operands. Returns true if any one operand is true, false otherwise. x || y;
        //     */

        //     /*
        //         OPERATOR EVALUATION AND PRECEDENCE

        //         Evaluation of the operands in an expression starts from left to right. 
        //         If multiple operators are used in an expression, then the operators with 
        //         higher priority are evaluated before the operators with lower priority.

        //         The following table lists operators starting with the higher precedence 
        //         operators to lower precedence operators :

        //         Operators	                                                                                                                    Category
        //         x.y, x?.y, x?[y], f(x), a[i], x++, x--, new, typeof, checked, unchecked, default, nameof, delegate, sizeof, stackalloc, x->y    Primary
        //         +x, -x, !x, ~x, ++x, --x, ^x, (T)x, await, &x, *x, true and false	                                                            Unary
        //         x..y	                                                                                                                        Range
        //         x * y, x / y, x % y	                                                                                                            Multiplicative
        //         x + y, x - y	                                                                                                                Additive
        //         x << y, x >> y	                                                                                                                Shift
        //         x < y, x > y, x <= y, x >= y, is, as	                                                                                        Relational and type-testing
        //         x == y, x != y	                                                                                                                Equality
        //         x & y	                                                                                                                        Boolean AND
        //         x ^ y	                                                                                                                        Boolean  XOR
        //         x | y	                                                                                                                        Boolean OR
        //         x && y	                                                                                                                        Conditional AND
        //         x || y	                                                                                                                        Conditional OR
        //         x ?? y	                                                                                                                        Null-coalescing operator
        //         c ? t : f	                                                                                                                    Conditional operator
        //         x = y, x += y, x -= y, x *= y, x /= y, x %= y, x &= y, x |= y, x ^= y, x <<= y, x >>= y, x ??= y, =>	                        Assignment and lambda declaration
        //     */

        //     // The following example demonstrates operator precedence:

        //     int a = 5 + 3 * 3;
        //     Console.WriteLine($"a = {a}.");

        //     int b = 5 + 3 * 3 /  2; 
        //     Console.WriteLine($"b = {b}.");

        //     int c = (5 + 3) * 3 /  2; 
        //     Console.WriteLine($"c = {c}.");

        //     int d = (3 * 3) * (3 / 3 + 5);
        //     Console.WriteLine($"d = {d}.");
        // }
    }
}