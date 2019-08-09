using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectArithmetic
{
    class Program
    {
        static double RectangleArea(double length, double width)
        {
            return length * width;
        }
        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static double TriangleArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
        static void CalculateTotalCost()
        {
            double trianglePart = TriangleArea(500, 750);
            double halfCirclePart = CircleArea(375) / 2;
            double rectanglePart = RectangleArea(1500, 2500);
            double totalArea = trianglePart + halfCirclePart + rectanglePart;
            double totalCost = Math.Round(totalArea * 180, 2);
            Console.WriteLine($"Total cost is calculated at {totalCost} Mexican pessos.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RectangleArea(4,5));
            Console.WriteLine(CircleArea(4));
            Console.WriteLine(TriangleArea(10,9));
            CalculateTotalCost();
            Console.ReadKey();

        }
    }
}
