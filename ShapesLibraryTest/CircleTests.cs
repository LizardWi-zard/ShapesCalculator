using ShapesLibrary.Shapes;

namespace ShapesLibrary.Tests
{
	public class CircleTests
	{
		[Test]
		public void GetArea_Correct()
		{
			var radius = 5.0;
			var expectedArea = Math.Pow(radius, 2) * Math.PI;
			Circle circle = new Circle(radius);

			var result = circle.GetArea();

			Assert.AreEqual(expectedArea, result);
		}

		[Test]
		public void ZeroRadius_Exception()
		{
			var radius = 0.0;

			var result = Assert.Throws<ArgumentException>(() => new Circle(radius));

			Assert.AreEqual(result.Message, "Radius should not be negative or zero.");
		}

		[Test]
		public void NegativeRadius_Exception()
		{
			var radius = -10.0;

			var result = Assert.Throws<ArgumentException>(() => new Circle(radius));

			Assert.AreEqual(result.Message, "Radius should not be negative or zero.");
		}

		[SetUp]
		public void Setup()
		{
		}
	}
}