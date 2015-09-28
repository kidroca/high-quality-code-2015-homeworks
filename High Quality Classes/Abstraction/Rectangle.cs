namespace Abstraction
{
    using System;

   public class Rectangle : IFiguresGeometryMethods
    {
        private double width;

        private double height;

        public Rectangle(double side)
        {
            this.Width = side;
            this.Height = side;
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width 
        {
            get
            {
                return this.width;
            }

            set
            {
                ValidateSide(value, "Width");
                this.width = value;
            }
        }

        public virtual double Height 
        {
            get
            {
                return this.height;
            }

            set
            {
                ValidateSide(value, "Height");
                this.height = value;
            }
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

       private void ValidateSide(double side, string name) 
       {
           if (side <= 0)
           {
               throw new ArgumentException(name + " must be greater than zero");
           }
       }
    }
}
