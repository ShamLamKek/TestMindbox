using System;
using System.Collections.Generic;
using System.Text;
using TestMindbox.Abstract;

namespace TestMindbox.Models
{
    public class Triangle : Figure, ICalculateArea, ICheckTriangle
    {
        private double sideone;
        private double sidetwo;
        private double sidethree;
        public override double SideOne { 
            get { return sideone; } 
            set {
                if (value < 0)
                {
                    throw new Exception("Сторона должна быть положительной");
                }
                else
                {
                    sideone = value;
                }
            } 
        }
        public double SideTwo
        {
            get { return sidetwo; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона должна быть положительной");
                }
                else
                {
                    sidetwo= value;
                }
            }
        }
        public double SideThree
        {
            get { return sidethree; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона должна быть положительной");
                }
                else
                {
                    sidethree = value;
                }
            }
        }
        public Triangle(double sideone, double sidetwo, double sidethree)
        {
            SideOne = sideone;
            SideTwo = sidetwo;
            SideThree = sidethree;
        }

        public double CalculateArea()
        {
            double sideOne = SideOne;
            double sideTwo = SideTwo;
            double sideThree = SideThree;
            double p = (sideOne + sideTwo + sideThree)/2;
            double s = Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree));
            return s;
        }

        public bool Check()
        {
            if ((SideOne * SideOne + SideTwo * SideTwo == SideThree * SideThree) || (SideOne * SideOne + SideThree * SideThree == SideTwo * SideTwo) || (SideTwo * SideTwo + SideThree * SideThree) == SideOne * SideOne)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
