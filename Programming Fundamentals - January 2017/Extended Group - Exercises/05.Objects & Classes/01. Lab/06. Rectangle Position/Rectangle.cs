﻿namespace _06.Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle
    {
        public double Top { get; set; }

        public double Left { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Bottom => Top - Height;

        public double Right => Left + Width;
    }
}