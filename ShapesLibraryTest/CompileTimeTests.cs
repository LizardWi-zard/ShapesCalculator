using ShapesLibrary.Abstraction;
using ShapesLibrary.Shapes;

namespace ShapesLibrary.Tests
{
	internal class CompileTimeTests
	{
		[Test]
		public void CompileTime()
		{
			var results = new List<double>();
			var shapes = new IShape[] { new Circle(3.0), 
										new Circle(82.3), 
										new Triangle(15.0, 21.3, 18.7),
										new Circle(82.3),
										new Triangle(15.0, 21.3, 18.7)
										};

			foreach (var shape in shapes)
			{
				results.Add(shape.GetArea());
			}

			Assert.IsTrue(results.All(x => x > 0));
		}
	}
}
