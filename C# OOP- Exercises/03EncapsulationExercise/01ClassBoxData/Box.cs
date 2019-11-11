using System;

namespace _01ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        { 
            get => length;
            private set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new Exception("Length cannot be zero or negative.");
                }
            }
        }

        public double Width
        { 
            get => width;
            private set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new Exception("Width cannot be zero or negative.");
                }
            }
        }

        public double Height
        { 
            get => height;
            private set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Height cannot be zero or negative.");
                }
            }
        }

        public double Area()
        {
            return (length * height + width * height + length * width) * 2;
        }

        public double LateralSurface()
        {
            return (length * height + width * height) * 2;
        }

        public double Volume()
        {
            return length * width * height;
        }
    }
}
