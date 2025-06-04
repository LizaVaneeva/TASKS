using NUnit.Framework;
using GeometryStruct;
using System;

namespace GeometryStruct.UnitTests
{
    [TestFixture]
    public class RightTriangleTests
    {
        [Test]
        public void Constructor_ValidInputs_PropertiesSet()
        {
            var rt = new RightTriangle(3.0, 4.0);
            Assert.That(rt.A, Is.EqualTo(3.0));
            Assert.That(rt.B, Is.EqualTo(4.0));
        }

        [TestCase(-1, 2)]
        [TestCase(3, -2)]
        [TestCase(0, 5)]
        public void Constructor_InvalidInput_Throws(double a, double b)
        {
            Assert.That(() => new RightTriangle(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Hypotenuse_CorrectValue()
        {
            var rt = new RightTriangle(3, 4);
            Assert.That(rt.Hypotenuse, Is.EqualTo(5).Within(1e-13));
        }

        [Test]
        public void ToString_ReturnsCorrectString()
        {
            var rt = new RightTriangle(2.3451, 1.002);
            Assert.That(rt.ToString(), Is.EqualTo("Прямоугольный треугольник с катетами 2,3451 см и 1,0020 см"));
        }

        [Test]
        public void Equals_IdenticalTriangles_True()
        {
            var rt1 = new RightTriangle(3, 4);
            var rt2 = new RightTriangle(3, 4);
            Assert.That(rt1 == rt2, Is.True);
        }

        [Test]
        public void Equals_DifferentTriangles_False()
        {
            var rt1 = new RightTriangle(3, 4);
            var rt2 = new RightTriangle(3, 5);
            Assert.That(rt1 == rt2, Is.False);
        }

        [Test]
        public void HashCode_SameForEqualObjects()
        {
            var rt1 = new RightTriangle(5, 12);
            var rt2 = new RightTriangle(5, 12);
            Assert.That(rt1.GetHashCode(), Is.EqualTo(rt2.GetHashCode()));
        }

        [Test]
        public void ScaleOperator_ValidInput_ScaledCorrectly()
        {
            var rt = new RightTriangle(3, 4);
            var scaled = 2.0 * rt;
            Assert.That(scaled.A, Is.EqualTo(6));
            Assert.That(scaled.B, Is.EqualTo(8));
        }

        [Test]
        public void ScaleOperator_InvalidScale_Throws()
        {
            var rt = new RightTriangle(3, 4);
            Assert.That(() => rt * 0, Throws.ArgumentException);
        }
    }
}
