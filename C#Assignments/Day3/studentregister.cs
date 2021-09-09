using System;

namespace studentregister
{
    interface IStudent
    {
        string LibCardNumber
        {
            get;
            set;
        }
        int Year
        {
            get;
            set;
        }
        void Register();
        void PostCourseWork(string work);
    }
    class PartTimeStudent : IStudent
    {
        string name;
        int year;
        public string LibCardNumber
        {
            get => name;
            set => name = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }

        public void Register()
        {
            Console.Write("\nEnter your LibCardNumber:");
            string LibCardNumber = Console.ReadLine();
            Console.Write("\nEnter Year:");
            int Year = int.Parse(Console.ReadLine());
            Console.Write("\nYour Details are:");
            Console.WriteLine($"Librarycardnumber:{LibCardNumber}, Year{ Year}");
        }

        public void PostCourseWork(string work)
        {
            Console.WriteLine("\nYour status is:" + work);
        }
    }
    class EmployeeDetails
    {
        public static void Main()
        {
            PartTimeStudent e = new PartTimeStudent();
            Console.WriteLine("\nEnter Your Details");
            e.Register();
            Console.Write("\nEnter Post Course Work:");
            string PostCourseworkString = Console.ReadLine();
            e.PostCourseWork(PostCourseworkString);
          
        }

    }
}
