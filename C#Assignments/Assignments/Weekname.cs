using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Weekname
    {
        enum week { sunday=0, monday=1,tuesday=2,wednesday=3,thursday=4,friday=5,saturday=6};
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the weekday number:");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 0: string s = Enum.GetName(typeof(week), 0);
                    Console.WriteLine(s + " " + " 0 holiday day");
                    break;
                   case 1: string s1 = Enum.GetName(typeof(week), 1);
                    Console.WriteLine(s1 + " " + " 1 Working day");
                    break;
                case 2: string s2 = Enum.GetName(typeof(week), 2);
                    Console.WriteLine(s2 + " " + "2 Working day");
                    break;
                case 3:
                    string s3 = Enum.GetName(typeof(week), 3);
                    Console.WriteLine(s3 + " " + "3 Working day");
                    break;
                case 4:
                    string s4 = Enum.GetName(typeof(week), 4);
                    Console.WriteLine(s4 + " " + "4 Working day");
                    break;


                case 5:
                    string s5 = Enum.GetName(typeof(week), 5);
                    Console.WriteLine(s5 + " " + "5 working day");
                    break;
                case 6:
                    string s6 = Enum.GetName(typeof(week), 6);
                    Console.WriteLine(s6 + " " + "6 Holiday");
                    break;
                default :
                    Console.WriteLine("Enter Valid input");
                    break;

            }
         
        }
    }
}
