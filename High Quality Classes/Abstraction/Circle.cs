﻿using System;

namespace Abstraction
{
    public class Circle : IFiguresGeometryMethods
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public virtual double Radius 
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The circle radius must be a positive value");
                }

                this.radius = value;
            }
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
