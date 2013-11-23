using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapMotionTest
{
    class Result
    {
        internal int X { get; set; }
        internal int Y { get; set; }
        internal float XIntersect { get; set; }
        internal float YIntersect { get; set; }
        internal int ScreenWidth { get; set; }
        internal int ScreenHeight { get; set; }
        internal float TipVelocity { get; set; }
    }
}
