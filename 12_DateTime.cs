// 12. DATETIME

namespace Lesson12
{
    class Program12
    {
        // public static void Main()
        // {
        //     /*
        //         C# includes DateTime struct to work with dates and times.

        //         To work with date and time in C#, create an object of the DateTime struct 
        //         using the new keyword. The following creates a DateTime object with the 
        //         default value.
        //     */

        //     DateTime dt = new DateTime();
        //     Console.WriteLine("dt = " + dt);

        //     /*
        //         The default and the lowest value of a DateTime object is 
        //         January 1, 0001 00:00:00 (midnight). 
        //         The maximum value can be December 31, 9999 11:59:59 P.M.

        //         Use different constructors of the DateTime struct to assign an initial value 
        //         to a DateTime object.
        //     */

        //     //Assigns default value 01/01/0001 00:00:00
        //     DateTime dt1 = new DateTime(); 
        //     Console.WriteLine($"dt1 = {dt1}");

        //     //Assigns year, month, day
        //     DateTime dt2 = new DateTime(2015, 12, 31); 
        //     Console.WriteLine($"dt2 = {dt2}");

        //     //Assigns year, month, day, hour, min, seconds
        //     DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
        //     Console.WriteLine($"dt3 = {dt3}");
            
        //     //Assigns year, month, day, hour, min, seconds, UTC timezone
        //     DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
        //     Console.WriteLine($"dt4 = {dt4}");

        //     /*
        //         In the above example, we specified a year, a month, and a day in the 
        //         constructor. The year can be from 0001 to 9999, and the Month can be from 
        //         1 to 12, and the day can be from 1 to 31. Setting any other value out of 
        //         these ranges will result in a run-time exception.
        //     */

        //     // DateTime dt5 = new DateTime(2015, 12, 32); // Exception
        //     // Console.WriteLine($"dt5 = {dt5}");

        //     /*
        //         Use different DateTime constructors to set date, time, time zone, 
        //         calendar and culture.

        //         TICKS

        //         Ticks is a date and time expressed in the number of 100-nanosecond intervals 
        //         that have elapsed since January 1, 0001, at 00:00:00.000 in the Gregorian 
        //         calendar. The following initializes a DateTime object with the number of ticks.
        //     */

        //     DateTime dt7 = new DateTime(31553789759); 
        //     Console.WriteLine($"dt7 = {dt7}");

        //     Console.WriteLine($"DateTime.MaxValue.Ticks = {DateTime.MaxValue.Ticks}");
        //     Console.WriteLine($"DateTime.MinValue.Ticks = {DateTime.MinValue.Ticks}");

        //     /*
        //         DATETIME STATIC FIELDS
                
        //         The DateTime struct includes static fields, properties, and methods. 
        //         The following example demonstrates important static fields and properties.
        //     */

        //     DateTime currentDateTime = DateTime.Now;
        //     Console.WriteLine($"currentDateTime = {currentDateTime}");

        //     DateTime todaysDate = DateTime.Today;
        //     Console.WriteLine($"todaysDate = {todaysDate}");

        //     DateTime currentDateTimeUTC = DateTime.UtcNow;
        //     Console.WriteLine($"currentDateTimeUTC = {currentDateTimeUTC}");

        //     /*
        //         TIMESPAN

        //         TimeSpan is a struct that is used to represent time in days, hour, minutes, 
        //         seconds, and milliseconds.
        //     */

        //     DateTime dt8 = new DateTime(2015, 12, 31);
        //     Console.WriteLine($"dt8 = {dt8}");
           
        //     TimeSpan ts = new TimeSpan(25,20,55);
        //     Console.WriteLine($"ts = {ts}");
            
        //     DateTime newDate = dt8.Add(ts);
        //     Console.WriteLine($"newDate = {newDate}");

        //     // Subtraction of two dates results in TimeSpan.

        //     DateTime dt9 = new DateTime(2015, 12, 31); 
        //     DateTime dt10 = new DateTime(2016, 2, 2);

        //     TimeSpan result = dt10.Subtract(dt9);
        //     Console.WriteLine($"result = {result}");

        //     /*
        //         OPERATORS

        //         The DateTime struct overloads +, -, ==, !=, >, <, <=, >= operators to ease 
        //         out addition, subtraction, and comparison of dates. These make it easy to 
        //         work with dates.
        //     */

        //     DateTime dt11 = new DateTime(2015, 12, 20);
        //     DateTime dt12 = new DateTime(2016, 12, 31, 5, 10, 20); 

        //     TimeSpan time = new TimeSpan(10, 5, 25, 50);

        //     Console.WriteLine($"dt12 + time = {dt12 + time}");
        //     Console.WriteLine($"dt12 - dt11 = {dt12 - dt11}");
        //     Console.WriteLine($"dt11 == dt12 = {dt11 == dt12}");
        //     Console.WriteLine($"dt11 != dt12 = {dt11 != dt12}");
        //     Console.WriteLine($"dt11 > dt12 = {dt11 > dt12}");
        //     Console.WriteLine($"dt11 < dt12 = {dt11 < dt12}");
        //     Console.WriteLine($"dt11 >= dt12 = {dt11 >= dt12}"); 
        //     Console.WriteLine($"dt11 <= dt12 = {dt11 <= dt12}");

        //     /*
        //         CONVERT STRING TO DATETIME

        //         A valid date and time string can be converted to a DateTime object using 
        //         Parse(), ParseExact(), TryParse() and TryParseExact() methods.

        //         The Parse() and ParseExact() methods will throw an exception if the specified 
        //         string is not a valid representation of a date and time. So, it's recommended 
        //         to use TryParse() or TryParseExact() method because they return false if a 
        //         string is not valid.
        //     */

        //     var str = "5/12/2020";
        //     DateTime dt14;
                        
        //     var isDateValid = DateTime.TryParse(str, out dt14);
        //     Console.WriteLine($"isDateValid = {isDateValid}");

        //     if(isDateValid)
        //     {
        //         Console.WriteLine($"dt14 = {dt14}");
        //     }
                
        //     else
        //     {
        //         Console.WriteLine($"{str} is not a valid date string.");
        //     }
        // }
    }
}