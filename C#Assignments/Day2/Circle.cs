using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    class Circle
    {
        double Radius;
        public Circle() { }
        public Circle(double Radius)
        {
            this.Radius=Radius;
        }
       
        public double GetRadius()
        {
             return Radius;
        }
        public void SetRadius(double Radius)
        {
           this.Radius= Radius;
        }
        public double calcDiameter()
        {
            return Radius*2;
        }
        public double calcArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
    class CircleTest
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter Circle Radius: ");
            float radius = float.Parse(Console.ReadLine());
            Circle circle1 = new Circle();
            circle1.SetRadius(radius);
            Console.WriteLine($"Radius: {circle1.GetRadius()}");

         
            Console.WriteLine($"Diameter:{circle1.calcDiameter()}");

           
            Console.WriteLine($"Area:{ circle1.calcArea()}");

        }
    }
}
