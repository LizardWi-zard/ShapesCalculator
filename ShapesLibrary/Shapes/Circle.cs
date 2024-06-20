using ShapesLibrary.Abstraction;

namespace ShapesLibrary.Shapes
{
	public class Circle : IShape
	{
		public Circle(double radius)
		{
			if (IsRadiusValid(radius))
			{
				Radius = radius;
			}
		}

		public double Radius { get; set; }

		public double GetArea()
		{
			return Math.Pow(Radius, 2) * Math.PI;
		}

		private bool IsRadiusValid(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException($"Radius should not be negative or zero.");
			}

			return true;
		}
	}
}