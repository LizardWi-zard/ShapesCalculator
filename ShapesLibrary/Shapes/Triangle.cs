using ShapesLibrary.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Shapes
{
	internal class Triangle : IShape
	{
		public double SideA {get;set;}
		public double SideB {get;set;}
		public double SideC { get; set; }

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0 || sideB <= 0 || sideC <= 0)
			{
				throw new ArgumentException();
			} 
			else if(sideA + sideB <= sideC || sideA + sideC <= sideB || sideC + sideB <= sideA)
			{
				throw new ArgumentException();
			}

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public double GetArea()
		{
			var halfPerimeter = (SideA + SideB + SideC) / 2;

			var area = Math.Sqrt(halfPerimeter * 
								(halfPerimeter - SideA) * 
								(halfPerimeter - SideB) * 
								(halfPerimeter - SideC));

			return area;

		}
	}
}
