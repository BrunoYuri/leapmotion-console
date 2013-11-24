using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapMotionTest
{
    public class Result
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float XIntersect { get; set; }
        public float YIntersect { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public float TipVelocity { get; set; }
    }
}
