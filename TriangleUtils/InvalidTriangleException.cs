using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Utils
{
	public class InvalidRightTriangleException: Exception
	{
		public InvalidRightTriangleException(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;			
		}

		public double A { get; private set; }
		public double B { get; private set; }
		public double C { get; private set; }

		public override string ToString()
		{
			return string.Format("InvalidTriangle A:{0}, B:{1}, C:{2}", A,B,C);
		}
	}
}
