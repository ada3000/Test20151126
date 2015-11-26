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
		/// Calculate triangle square by 3 sides
		/// </summary>
		/// <param name="a">triangle side A</param>
		/// <param name="b">triangle side B</param>
		/// <param name="c">triangle side C</param>
		/// <returns></returns>
		public static double CalcTriangleSquare(double a, double b, double c)
		{
			if (!IsValidTriangle(a, b, c))
				throw new InvalidTriangleException(a, b, c);

			double p = (a + b + c) / 2;

			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		private static bool IsValidTriangle(double a, double b, double c)
		{
			return a + b > c && a + c > b && b + c > a;
		}
	}    
}
