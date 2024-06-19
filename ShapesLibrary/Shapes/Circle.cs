using ShapesLibrary.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Shapes
{
	internal class Circle : IShape
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException();
			}

			Radius = radius;
		}

		public double GetArea()
		{
			var area = Math.Pow(Radius, 2) * Math.PI;

			return area;
		}
	}
}
