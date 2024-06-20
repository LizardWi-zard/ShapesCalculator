using ShapesLibrary.Shapes;

namespace ShapesLibrary.Tests
{
	internal class TriangleTests
	{
		[Test]
		public void GetArea_AreaIsCorrect()
		{
			var expectedHalfPerimeter = (5.0 + 4.0 + 7.0) / 2;
			var expectedArea = Math.Sqrt(expectedHalfPerimeter *
					  (expectedHalfPerimeter - 5.0) *
					  (expectedHalfPerimeter - 4.0) *
					  (expectedHalfPerimeter - 7.0));
			var target = new Triangle(5.0, 4.0, 7.0);

			var result = target.GetArea();

			Assert.AreEqual(expectedArea, result);
		}

		[Test]
		public void TriangleIsRight_Correct()
		{
			var target = new Triangle(3.0, 4.0, 5.0);

			var result = target.TriangleIsRight();

			Assert.IsTrue(result);
		}

		[Test]
		public void TriangleIsRight_NotCorrect()
		{
			var target = new Triangle(4.0, 4.0, 5.0);

			var result = target.TriangleIsRight();

			Assert.IsFalse(result);
		}

		[Test]
		public void InvalidSides_Exception()
		{
			var result = Assert.Throws<ArgumentException>(() => new Triangle(1.0, 2.0, 3.0));

			Assert.AreEqual(result.Message, "The length of any side of a triangle is less than the length of the other two sides.");

		}

		[Test]
		public void ZeroSides_Exception()
		{
			var result = Assert.Throws<ArgumentException>(() => new Triangle(0.0, 2.0, 3.0));

			Assert.AreEqual(result.Message, "Sides should not be negative or zero.");

		}

		[Test]
		public void NegativeSides_Exception()
		{
			var result = Assert.Throws<ArgumentException>(() => new Triangle(1.0, -2.0, 3.0));

			Assert.AreEqual(result.Message, "Sides should not be negative or zero.");

		}

		[SetUp]
		public void Setup()
		{
		}
	}
}
