using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_5
{
    abstract class Figure
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public abstract void Area();        
    }

    class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x,y)
        { }
        public override void Area()
        {
            Console.WriteLine((X+Y)*4);
        }
    }

    class Triangle : Figure
    {
        public Triangle(int x, int y) : base(x,y)
        { }
        public override void Area()
        {
            Console.WriteLine(X * Y / 2);
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = { new Triangle(1, 2), new Rectangle(2, 3) };

            Console.ReadLine();

        }
    }
}
