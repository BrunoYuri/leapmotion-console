using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace LeapMotionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var listener = new MyListener();
            var controller = new Controller();
            controller.AddListener(listener);

            Console.WriteLine("Listening...");            

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            controller.RemoveListener(listener);
            controller.Dispose();
        }
    }
}
