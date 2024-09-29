using POC_on_ENums.Models;

namespace POC_on_ENums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============POC on ENUMS==============");
            Console.WriteLine();
            Console.WriteLine("A Enums stands for Enumeration");

            //Enums is a user defined VALUE TYPE in C# which consists of a set of name constants
            //First we will see how declare a eum 

            Console.WriteLine("=============== 1. Declaration =============");
            Console.WriteLine();

            //We declare a enum is WeekDay class

            //Printing a single Value from enum
            WeekDay.Day today = WeekDay.Day.Friday;
            Console.WriteLine(today);

            //Printing that single value and converting into explicily int
            int DayNumber = (int) today;
            Console.WriteLine(DayNumber);
            Console.WriteLine();

            Console.WriteLine("Printing both days and its explicit value ");
            //used for loops to iterate the enum which consist of WeekDay and its int values
            foreach (WeekDay.Day day in Enum.GetValues(typeof(WeekDay.Day)))
            {
                Console.WriteLine(day + " " + (int)day);
            }
            Console.WriteLine();
            
            Console.WriteLine("============= 2. Customizing enum values =============");
            Console.WriteLine();

            //I can explicitly change the intger values of enus constant

            foreach(WeekDay.CustomDay day in Enum.GetValues(typeof (WeekDay.CustomDay)))
            {
                Console.WriteLine(day + " " + (int)day);
            }
            Console.WriteLine();

            Console.WriteLine("=============3. Using enum in method as switch =============");
            Console.WriteLine();


            // we have used the method and in that method we implemented a enum for a traffic signal
            SwicthMethod.ControlTraffic(SwicthMethod.TrafficLight.Red);
            SwicthMethod.ControlTraffic(SwicthMethod.TrafficLight.Yellow);
            SwicthMethod.ControlTraffic(SwicthMethod.TrafficLight.Green);
            Console.WriteLine();

            Console.WriteLine("============= 4. Flags Enum ==============");
            Console.WriteLine();


            // the Flag value represent a bit in enum 
            //where this acess is the or operation of both read and write which will give the value of 3
            //and in Enum the value of 3 is Execute
            FlagEnum.FileAccess access = FlagEnum.FileAccess.Read | FlagEnum.FileAccess.Write;

            Console.WriteLine(FlagEnum.FileAccess.Read);
            Console.WriteLine(FlagEnum.FileAccess.Write);
            Console.WriteLine(access);
            Console.WriteLine();

            Console.WriteLine("============== 5. Advantages and disadvantages ");
            Console.WriteLine();
            Console.WriteLine("Advantages:-");
            Console.WriteLine($"Improves Code Readability \n" +
                $"Prevents Magic Number\n" +
                $"Support Bitwise Operator\n" +
                $"Easy to Use in Switch");
            Console.WriteLine();
            Console.WriteLine("Disadvantages");
            Console.WriteLine($"Enum Values are Int-Based\n" +
                $"Not Suitable for Frequently changing Sets of Values");
            Console.WriteLine();







        }
    }
}
