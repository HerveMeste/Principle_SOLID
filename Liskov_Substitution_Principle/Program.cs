using System;

namespace Liskov_Substitution_Principle
{
    class MainClass
    {
        public virtual void Main(string[] args)
        {
            Polygone square = new Square { };
            Polygone rectangle = new Rectangle { _height = 10, _width = 5 };
            double areaRectangle =  rectangle.Area();
            double areaSquare = square.Area();

            Console.WriteLine((areaSquare, areaRectangle));
        }
    }
    public abstract class Polygone
    {
        protected double _height { get; set; }
        protected double _width { get; set; }
        public abstract double Area();

    }
    public class Rectangle : Polygone
    {
        public override double Area()
        {
            return this._width * this._height;
        }
    }
    public class Square : Polygone
    {
        
        public override double Area()
        {
            this._height = this._width;
            return _height * _width; ;
        }
    }

}
