using System;

namespace day8
{
    class Program
    {
        public static float LineLength (int a,int b,int c,int d)
        {
            int x = (int)Math.Pow(c - a, 2);
            int y = (int)Math.Pow(d - b, 2);
            float l = (float)Math.Sqrt(x + y);
            Console.WriteLine("Length of line is :" + l);
            return l;
            
        }

        public static void LineCompare (float l1, float l2)
        {
            if (l1 == l2)
            {
                Console.WriteLine("both lines are equal");
            }
            else if (l1 > l2)
            {
                Console.WriteLine("line 1 is greater than line 2");
            }
            else
            {
                Console.WriteLine("line 1 is lesser than line 2");
            }
        }
        static void Main(string[] args)
        {
            float a = LineLength(5, 6, 7, 5);
            float b = LineLength(3, 4, 7, 5);
            LineCompare(a, b);
        }
    }
}
