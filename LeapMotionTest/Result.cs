using System;

namespace LeapMotionTest
{
    public class Result
    {
        public int X { get; set; } //Fingertip's X position in pixels
        public int Y { get; set; } //Fingertip's Y position in pixels
        public float XIntersect { get; set; } //Decimal of the finger's X position in relation to the screen
        public float YIntersect { get; set; } //Decimal of the finger's Y position in relation to the screen
        public int ScreenWidth { get; set; } 
        public int ScreenHeight { get; set; }
        public float TipVelocity { get; set; } //Speed at which the fingertip is moving
    }
}