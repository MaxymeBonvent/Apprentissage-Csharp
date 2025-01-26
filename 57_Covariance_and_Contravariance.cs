// 57. COVARIANCE AND CONTRAVARIANCE

namespace Lesson57
{
    class Program57
    {
        // public static void Main()
        // {
        //     /*
        //         Covariance and contravariance allow us to be flexible when dealing with class 
        //         hierarchy.

        //         Consider the following class hierarchy before we learn about covariance and 
        //         contravariance:

        //         public class Small
        //         { 

        //         }

        //         public class Big: Small
        //         {

        //         }

        //         public class Bigger : Big
        //         { 
                    
        //         }

        //         As per the above example classes, small is a base class for big and big is a
        //         base class for bigger. The point to remember here is that a derived class 
        //         will always have something more than a base class, so the base class is 
        //         relatively smaller than the derived class.

        //         Now, consider the following initialization:
        //     */

        //     Small small1 = new();
        //     Small small2 = new Big();
        //     Small small3 = new Bigger();
            
        //     Big big1 = new Bigger();

        //     /*
        //         Big big2 = new Small();
        //         Bigger bigger1 = new Big();

        //         Compiler Error CS0266 :
        //         Cannot implicitly convert type 'Small' to 'Big'. 
        //         An explicit conversion exists (are you missing a cast?)
        //     */

        //     /*
        //         As you can see above, a base class can hold a derived class but a derived 
        //         class cannot hold a base class. In other words, an instance can accept Big 
        //         even if it demands Small, but it cannot accept Small if it demands Big.

        //         Now, let's learn about covariance and contravariance.
        //     */

        //     /*
        //         COVARIANCE

        //         Covariance enables you to pass a derived type where a base type is expected. 
        //         Co-variance is like variance of the same kind. The base class and other 
        //         derived classes are considered to be the same kind of class that adds extra 
        //         functionalities to the base type. So covariance allows you to use a derived 
        //         class where a base class is expected (rule: can accept Big if Small is 
        //         expected).

        //         Covariance can be applied on delegate, generic, array, interface, etc.
        //     */

        //     /*
        //         COVARIANCE WITH DELEGATE

        //         Covariance in delegates allows flexiblity in the return type of delegate 
        //         methods.
        //     */

        //     covarianceDelegate covDel = Method1;

        //     Small small4 = covDel(new Big());

        //     covDel = Method2;

        //     Small small5 = covDel(new Big());

        //     Console.WriteLine("\n");

        //     /*
        //         As you can see in the above example, delegate expects a return type of small (base class) but we can still 
        //         assign Method1 that returns Big (derived class) and also Method2 that has same signature as delegate expects.

        //         Thus, covariance allows you to assign a method to the delegate that has a less derived return type.
        //     */

        //     /*
        //         CONTRAVARIANCE

        //         Contravariance is applied to parameters. Contravariance allows a method with the parameter of a base class to 
        //         be assigned to a delegate that expects the parameter of a derived class.

        //         Continuing with the example above, add Method3 that has a different parameter type from delegate:
        //     */


        //     covarianceDelegate covDel2 = Method1;
        //     covDel2 += Method2;
        //     covDel2 += Method3;

        //     Small small6 = covDel2(new Big());

        //     Console.WriteLine("\n");

        //     /*
        //         As you can see, Method3 has a parameter of Small class whereas delegate expects a parameter of Big class. 
        //         Still, you can use Method3 with the delegate.

        //         You can also use covariance and contravariance in the same method as shown below.
        //     */

        //     covarianceDelegate covDel3 = Method4;

        //     Small small7 = covDel3(new Big());
        // }

        // Delegate
        public delegate Small covarianceDelegate(Big bg);

        // Static method of the first derived class
        public static Big Method1(Big bg)
        {
            Console.WriteLine("Big Method1.");
        
            return new Big();
        }

        // Static method of the base class
        public static Small Method2(Big bg)
        {
            Console.WriteLine("Small Method2.");
        
            return new Small();
        }

        // Static method of the base class
        public static Small Method3(Small sml)
        {
            Console.WriteLine("Small Method3.");
            
            return new Small();
        }

        // Static method of the derived class
        public static Big Method4(Small sml)
        {
            Console.WriteLine("Big Method4.");
        
            return new Big();
        }
        
        public class Small
        { 

        }

        public class Big: Small
        {

        }

        public class Bigger: Big
        { 
            
        }
    }
}