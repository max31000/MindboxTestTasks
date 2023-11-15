using FigureAreaCalculator;

namespace FigureAreaTests;

public class Tests
{
    [TestFixture]
    public class ShapeAreaCalculatorTests
    {
        [Test]
        public void CalculateArea_Circle_ReturnsCorrectArea()
        {
            var circle = new Circle(radius: 5);
            var calculator = new ShapeAreaCalculator();

            var result = calculator.CalculateArea(circle);

            Assert.That(result, Is.EqualTo(Math.PI * Math.Pow(5, 2)).Within(Epsilon));
        }

        [Test]
        public void CalculateArea_Triangle_ReturnsCorrectArea()
        {
            var triangle = new Triangle(sideA: 3, sideB: 4, sideC: 5);
            var calculator = new ShapeAreaCalculator();

            var result = calculator.CalculateArea(triangle);

            Assert.That(result, Is.EqualTo(6).Within(Epsilon));
        }

        [Test]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(sideA: 3, sideB: 4, sideC: 5);

            var result = triangle.IsRightAngled();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsRightAngled_NonRightAngledTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(sideA: 2, sideB: 3, sideC: 4);

            var result = triangle.IsRightAngled();

            Assert.That(result, Is.False);
        }

        private static double Epsilon { get; set; } = 0.001;
    }
}