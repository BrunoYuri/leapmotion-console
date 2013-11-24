using System;

namespace LeapMotionTest
{
    public class Reporter
    {
        public void PrintResult(Result result)
        {
            Console.WriteLine("Screen intersect x: {0}", result.XIntersect);
            Console.WriteLine("Screen intersect y: {0}", result.YIntersect);
            Console.WriteLine("\n");
            Console.WriteLine("X: {0}/{1}px", result.X, result.ScreenWidth);
            Console.WriteLine("Y: {0}/{1}px", result.Y, result.ScreenHeight);
            Console.WriteLine("\n");
            Console.WriteLine("Tip velocity: {0}", result.TipVelocity);
        }
    }
}
