using System;
using Leap;

namespace LeapMotionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportingListener listener = new ReportingListener(new Reporter());
            Controller controller = new Controller();
            controller.AddListener(listener);

            Console.WriteLine("Listening! Press any key when you're finished to exit.");
            Console.ReadKey();

            controller.RemoveListener(listener);
            controller.Dispose();
        }
    }
}