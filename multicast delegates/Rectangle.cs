using System;

namespace Multiplecast_Delegates
{
    public delegate void RectangleDelegate(double Width, double Height);
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rectangle: " + Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of rectangle: " + 2 * (Width * Height));
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            RectangleDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;                                       //binding 
            obj(12, 20);                                                    // all the methods will execute with same values 
        }
    }
}

