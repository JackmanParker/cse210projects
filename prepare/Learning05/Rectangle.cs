using System;

namespace Learning5{

    public class Rectangle: Shape{
        private double _length;
        private double _width;

        public Rectangle(string color, double width, double length) : base(color){
            _length = length;
            _width = width;
        }
        
        public void SetLength(double sideLength){
            _length = sideLength;
        }
        public void SetWidth(double sideLength){
            _width = sideLength;
        }

        public override double GetArea()
        {
            return _length * _width;
        }
    }
}