using Shape.Models;

namespace Shape
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { Rectangle, Circle, Triangle, Square };
            Console.WriteLine("L'aire totale est de : " + TotalArea(shapes) + Rectangle.Area());
        }

        public static double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }
}
