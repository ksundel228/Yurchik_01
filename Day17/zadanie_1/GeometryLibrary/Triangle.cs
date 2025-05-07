using System;

namespace GeometryLibrary
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public bool IsValid()
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public string TriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Равносторонний";
            if (SideA == SideB || SideA == SideC || SideB == SideC)
                return "Равнобедренный";
            return "Разносторонний";
        }
    }
}
