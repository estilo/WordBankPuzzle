using System;
using System.Drawing;

namespace WordSearchGenerator
{
    public class Letter
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char _Letter { get; set; }
        public Letter(char letter, Point p )
        {
            this._Letter = letter;
            this.X = p.X;
            this.Y = p.Y;
        }
    }
}
