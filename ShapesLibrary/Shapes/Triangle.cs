using ShapesLibrary.Abstraction;

namespace ShapesLibrary.Shapes
{
	/// <summary>
	/// Представляет  треугольник
	/// </summary>
	public class Triangle : IShape
	{
		/// <summary>
		/// Создаёт объект треугольник
		/// </summary>
		public Triangle(double sideA, double sideB, double sideC)
		{
			if (SidesAreValid(sideA, sideB, sideC) && TriangleIsValid(sideA, sideB, sideC))
			{
				SideA = sideA;
				SideB = sideB;
				SideC = sideC;
			}
		}

		public double SideA { get; set; }

		public double SideB { get; set; }

		public double SideC { get; set; }

		/// <summary>
		/// Метод подсчета площади
		/// </summary>
		/// <returns>
		/// Площадь по формуле Герона
		/// </returns>
		public double GetArea()
		{
			var halfPerimeter = (SideA + SideB + SideC) / 2;

			return Math.Sqrt(
				halfPerimeter *
				(halfPerimeter - SideA) *
				(halfPerimeter - SideB) *
				(halfPerimeter - SideC)
				);
		}

		/// <summary>
		/// Проверка на прямоугольный треугольник
		/// </summary>
		/// <returns></returns>
		public bool TriangleIsRight()
		{
			var sides = new[] { SideA, SideB, SideC };

			sides.Order();

			if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
			{
				return true;
			}

			return false;
		}

		private bool SidesAreValid(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0 || sideB <= 0 || sideC <= 0)
			{
				throw new ArgumentException("Sides should not be negative or zero.");
			}

			return true;
		}

		private bool TriangleIsValid(double sideA, double sideB, double sideC)
		{
			if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideC + sideB <= sideA)
			{
				throw new ArgumentException("The length of any side of a triangle is less than the length of the other two sides.");
			}

			return true;
		}
	}
}