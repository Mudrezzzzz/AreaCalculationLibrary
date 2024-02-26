using System;

namespace GeometryLibrary
{
    /// <summary>
    /// Определение интерфейса IShape (Фигура)
    /// </summary>
    public interface IShape
    {
        double CalculateArea();
    }
    
    /// <summary>
    /// Класс для представления круга, реализующий интерфейс IShape
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Поле для хранения радиуса круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор класса, принимающий радиус круга
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius; 
        }
    }

    /// <summary>
    /// Класс для представления треугольника, реализующий интерфейс IShape
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Поля для хранения длин сторон треугольника
        /// </summary>
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <summary>
        /// Конструктор класса, принимающий длины сторон треугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Метод для вычисления площади треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            
            double s = (SideA + SideB + SideC) / 2;
            
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Метод для проверки, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightAngled()
        {
            
            double sideASqr = SideA * SideA;
            double sideBSqr = SideB * SideB;
            double sideCSqr = SideC * SideC;

            return sideASqr + sideBSqr == sideCSqr ||
                   sideASqr + sideCSqr == sideBSqr ||
                   sideBSqr + sideCSqr == sideASqr;
        }
    }
}
