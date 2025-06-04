using System;

namespace GeometryStruct
{
    public struct RightTriangle
    {
        public double A { get; set; }
        public double B { get; set; }

        public double Hypotenuse
        {
            get => Math.Sqrt(A * A + B * B);
        }

        public RightTriangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Катеты должны быть положительными числами.");

            A = a;
            B = b;
        }

        public override string ToString() =>
            $"Прямоугольный треугольник с катетами {A:F4} см и {B:F4} см";

        public override bool Equals(object obj)
        {
            if (obj is RightTriangle other)
                return Math.Abs(A - other.A) < 1e-13 && Math.Abs(B - other.B) < 1e-13;

            throw new ArgumentException("Объект не является RightTriangle");
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int p = 23;
                int hash = 17;
                hash = hash * p + A.GetHashCode();
                hash = hash * p + B.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(RightTriangle left, RightTriangle right) => left.Equals(right);
        public static bool operator !=(RightTriangle left, RightTriangle right) => !left.Equals(right);

        public static RightTriangle operator *(double k, RightTriangle rt)
        {
            if (k <= 0)
                throw new ArgumentException("Коэффициент должен быть положительным.");

            return new RightTriangle(rt.A * k, rt.B * k);
        }

        public static RightTriangle operator *(RightTriangle rt, double k) => k * rt;
    }
}
