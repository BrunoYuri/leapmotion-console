using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotionTest
{
    static class Reporter
    {
        internal static void PrintResult(Result result)
        {
            Console.WriteLine("Screen intersect x: {0}", result.XIntersect);
            Console.WriteLine("Screen intersect y: {0}", result.YIntersect);
            Console.WriteLine("Screen width: {0}", result.ScreenWidth);
            Console.WriteLine("Screen height: {0}", result.ScreenHeight);
            Console.WriteLine("\n");
            Console.WriteLine("X: {0}", result.X);
            Console.WriteLine("Y: {0}", result.Y);
            Console.WriteLine("\n");
            Console.WriteLine("Tip velocity: {0}", result.TipVelocity);

            Console.WriteLine("\n{0}\n", new string('=', 40));
        }
    }
}
