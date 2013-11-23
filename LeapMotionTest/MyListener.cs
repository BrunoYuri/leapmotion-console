using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace LeapMotionTest
{
    class MyListener : Listener
    {
        private long currentTime,
                     previousTime,
                     timeChange;

        public override void OnInit(Controller ctrl)
        {
            base.OnConnect(ctrl);
            Console.WriteLine("Device initialised");
        }

        public override void OnConnect(Controller ctrl)
        {
            base.OnConnect(ctrl);
            Console.WriteLine("Connected");
        }


        public override void OnDisconnect(Controller ctrl)
        {
            base.OnDisconnect(ctrl);
            Console.WriteLine("Disconnected");
        }

        public override void OnExit(Controller ctrl)
        {
            base.OnExit(ctrl);
            Console.WriteLine("Exited");
        }

        public override void OnFrame(Controller ctrl)
        {
            //Get the current frame
            Frame currentFrame = ctrl.Frame();

            this.currentTime = currentFrame.Timestamp;
            this.timeChange = currentTime - previousTime;

            if (this.timeChange < 1000 || currentFrame.Hands.IsEmpty)
                return;
                
            //Get the first finger
            Finger finger = currentFrame.Fingers[0];

            //Get the closest screen that intercepts a ray projected from the finger
            Screen screen = ctrl.LocatedScreens.ClosestScreenHit(finger);

            //Get finger tip's velocity
            float tipVelocity = (int)finger.TipVelocity.Magnitude;

            /*only print info when velocity exceeds a certain threshold,
              so that the slightest movements won't continuously output
              data to the screen*/
            if (screen == null || !screen.IsValid || tipVelocity <= 25)
                return;

            float xScreenIntersect = screen.Intersect(finger, true).x;
            float yScreenIntersect = screen.Intersect(finger, true).y;

            if (xScreenIntersect.ToString() == "NaN")
                return;

            float x = xScreenIntersect * screen.WidthPixels;
            float y = screen.HeightPixels - (yScreenIntersect * screen.HeightPixels);

            Result result = new Result
            {
                X = (int)x,
                Y = (int)y,
                XIntersect = xScreenIntersect,
                YIntersect = yScreenIntersect,
                ScreenWidth = screen.WidthPixels,
                ScreenHeight = screen.HeightPixels,
                TipVelocity = tipVelocity
            };

            Reporter.PrintResult(result);
            previousTime = currentTime;
        }
    }
}
