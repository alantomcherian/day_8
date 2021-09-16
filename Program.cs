using System;

namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter coordinates of line (x1) ::");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line (y1) ::");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line (x2) ::");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line (y2) ::");
            int y2 = int.Parse(Console.ReadLine());
            float l1 = (float)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(l1);
        }
    }
}
