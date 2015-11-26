using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Utils
{
	public static class Square
	{	
		/// <summary>
		/// Расчет площади прямоуголного треугольника
		/// </summary>
		/// <param name="a">Сторона A</param>
		/// <param name="b">Сторона B</param>
		/// <param name="c">Сторона C</param>
		/// <returns></returns>
		public static double CalcRightTriangleSquare(double a, double b, double c)
		{
			List<double> sides = new List<double> { a, b, c };
			sides.Sort();

			if (!IsTriangle(sides) || !IsRightTriangle(sides))
				throw new InvalidRightTriangleException(a, b, c);

			return 0.5*sides[0]*sides[1];
		}

		private static bool IsTriangle(List<double> sides)
		{
			return sides[0] + sides[1] > sides[2] && 
				sides[0] + sides[2] > sides[1] && 
				sides[1] + sides[2] > sides[0];
		}

		private static bool IsRightTriangle(List<double> orderedSides)
		{
			return orderedSides[0]*orderedSides[0] + orderedSides[1]*orderedSides[1] ==
				orderedSides[2]*orderedSides[2];
		}
	}    
}
