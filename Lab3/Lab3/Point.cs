using System.Diagnostics.Contracts;
using System.Drawing;

namespace Lab3
{
    internal class Point2D 
    {
        private double x, y;
        private Color color;

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public Color Color {get {return color;}}


        public Point2D() {
            x = 0;
            y = 0;
            color = Color.White;
        }
        public Point2D(double x, double y) {
            this.x = x;
            this.y = y;
            color = Color.White;
        }
        public Point2D(double x, double y, Color color)  {
            this.x = x;
            this.y = y;
            this.color = color;
        }
   
        public void PrintPointCoordinates(string title) {
            Console.WriteLine($"Point coordinates {title}: ({x}, {y})");
        }
        public double GetMagnitude() {
            return Math.Sqrt(x * x + y * y);
        }
        public void SetCoordinates(double x, double y) {
            this.x = x;
            this.y = y;
        }
        public void SetCoordinates(Point2D point) {
            this.x = point.x;
            this.y = point.y;
        }
        
    }
}