using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    interface IShape
    {
        double CalculateArea();
    }

   class Circle : IShape
    {
        double radius;
        public Circle(double num)
        {
            radius = num;
        }

        public double CalculateArea()
        {
            return (radius * radius * Math.PI);
        }
    }

    class Square:IShape
    {
        double sidelength;
        public Square(double num)
        {
            sidelength = num;
        }
        public double CalculateArea()
        {
            return (sidelength * sidelength);
        }
    }

    class Triangle:IShape
    {
        double height;
        double bottom;
        public Triangle(double num,double num2)
        {
            height = num;
            bottom = num2;
        }
      
        public double CalculateArea()
        {
            return (height * bottom);
        }
    }
}
