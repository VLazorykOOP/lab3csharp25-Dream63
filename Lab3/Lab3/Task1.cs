using System.Drawing;

namespace Lab3
{
    internal class Task1
    {

        Point2D point1 = new();
        Point2D point2 = new(1, 5);
        Point2D point3 = new(5, 12, Color.Brown);

        public void Task() {
            Console.WriteLine(">>> Task1");
            Point2D[] pointArray = { point1, point2, point3 };
            double avgDistanceFromCenter = (point1.GetMagnitude() + point2.GetMagnitude() + point3.GetMagnitude()) / 3;
            Point2D selectedVector = new (6,  6);
            selectedVector.PrintPointCoordinates("Selected");

            foreach (Point2D point in pointArray) {
                point.PrintPointCoordinates("Until");
                if (point.GetMagnitude() > avgDistanceFromCenter)
                    point.SetCoordinates(selectedVector);       
                point.PrintPointCoordinates("After");
            }
        }
    }
}