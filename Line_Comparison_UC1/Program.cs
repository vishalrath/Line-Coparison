using System;

namespace Line_Comparison_UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            double  x1, y1, x2, y2;
            double len, length;
            double point1, point2;

            Console.WriteLine("enter the value point x1  :" );
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y1  :");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point x2  :");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y2  :");
            y2 = Convert.ToInt32(Console.ReadLine());


            point1 = Math.Pow((x2 - x1), 2);
            point2 = Math.Pow((y2 - y1), 2);
            len = point1 + point2;
            length = Math.Sqrt(len);
            Console.ReadLine();
        }
    }
}
