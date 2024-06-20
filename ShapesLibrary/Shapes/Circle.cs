using ShapesLibrary.Abstraction;

namespace ShapesLibrary.Shapes
{
	public class Circle : IShape
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			if (IsRadiusValid(radius))
			{
				Radius = radius;
			}
		}

		public double GetArea()
		{
			var area = Math.Pow(Radius, 2) * Math.PI;

			return area;
		}

		public bool IsRadiusValid(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException($"Radius should not be negative or zero.");
			}

			return true;
		}
	}
}