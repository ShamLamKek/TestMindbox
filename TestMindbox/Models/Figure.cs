using System;

namespace TestMindbox
{
    //у каждой фигуры есть хотя бы одна сторона,
    //но для круга вместо радиуса я все равно реишл использовать то же самое поле
    public abstract class Figure
    {
        public const double PI = 3.14;
       
        public abstract double SideOne { get ; set; }
        
    }
}
