using System;
using System.Collections.Generic;
using System.Text;
using TestMindbox.Abstract;

namespace TestMindbox.Models
{
    public class Circle : Figure, ICalculateArea
    {
        private double sideone;
        public override double SideOne
        {
            get { return sideone; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Радиус должен быть положительным");
                }
                else
                {
                    sideone = value;
                }
            }
        }
        public Circle(double sideone) 
        {
            SideOne = sideone;
        }

        public double CalculateArea()
        {
            double radius = SideOne;
            return PI * radius * radius;
        }
    }
}
