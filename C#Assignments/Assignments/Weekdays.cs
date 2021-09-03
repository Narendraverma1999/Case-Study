using System;


namespace Assignments
{
    class Weekdays
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter the weekday number:");
            int x = int.Parse(Console.ReadLine());
            if (x > 0 && x <= 7 )
            {
                if (x > 1 && x <= 5)
                {
                    Console.WriteLine("Working Day");
                }

                else
                {
                    Console.WriteLine("Holiday");
                }
            }
        }
    }
}