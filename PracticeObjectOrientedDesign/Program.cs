using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    enum ShapeType
    {
        Circle,
        Square
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(2);
            IShape square = new Square(15);
            IShape triangle = new Triangle(5,10);

            Console.WriteLine("円の面積: " + circle.CalculateArea());
            Console.WriteLine("正方形の面積: " + square.CalculateArea());
            Console.WriteLine("三角形の面積:" +  triangle.CalculateArea());
        }
    }
}
