using ShapesLibrary.Abstraction;

namespace ShapesLibrary.Shapes
{
	/// <summary>
	/// Представляет круг
	/// </summary>
	public class Circle : IShape
	{
		/// <summary>
		/// Создает объект круга
		/// </summary>
		/// <param name="radius">
		/// Радиус круга
		/// </param>
		public Circle(double radius)
		{
			if (IsRadiusValid(radius))
			{
				Radius = radius;
			}
		}

		/// <summary>
		/// Радиус круга
		/// </summary>
		public double Radius { get; set; }

		/// <summary>
		/// Метод подсчета площади круга
		/// </summary>
		/// <returns>
		/// Площадь по формуле S = π ⋅ R 2
		/// </returns>
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