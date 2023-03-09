using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    abstract class Figure
    {
        public double height, width, radius;
        public const float pi = 3.14f;
        public abstract double AreaOf();
    }
     class Rectangle : Figure
    {
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double AreaOf()
        {
            return height * width;
        }
    }

    class Triangle : Figure
    {
        public Triangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double AreaOf()
        {
            return 0.5*height * width;

        }
    }
    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double AreaOf()
        {
            return pi*radius*radius;

        }
    }
    class Area
    {
        static void Main()
        {
            Rectangle r = new Rectangle(10, 20);
            Triangle t = new Triangle(10, 20);
            Circle c = new Circle(10);
            Console.WriteLine(c.AreaOf());
            Console.WriteLine(t.AreaOf());
            Console.WriteLine(r.AreaOf());
        }
    }
}
