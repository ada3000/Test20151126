using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Company.Utils;

namespace Company.Utils.Tests
{
	[TestClass]
	public class TestSquare
	{
		private const string TestError = "error";
		/// <summary>
		/// Test triangle data: a,b,c,result
		/// </summary>
		private object[] testTriangleData = new object[]
			{
				new object[]{0.0, 1.0, 2.0, TestError},
				new object[]{-3.0, -4.0, -5.0, TestError},
				new object[]{10.0, 1.0, 2.0, TestError},
				new object[]{5.0, 4.0, 5.0, TestError},
				new object[]{3.0, 4.0, 5.0, 6.0},				
				//new object[]{2.0,1.0,2.0,TestError}, //test error				
				//new object[]{3.0,4.0,5.0,26.0}, //test error
			};

		[TestMethod]
		public void CalcTriangleSquare()
		{
			for (int i = 0; i < testTriangleData.Length; i++)
			{
				var data = (object[])testTriangleData[i];

				object actualResult = TestTriangle((double)data[0],
					(double)data[1],
					(double)data[2]);

				Assert.AreEqual(data[3], actualResult);
			}
		}

		private object TestTriangle(double a, double b, double c)
		{
			try
			{
				return Square.CalcRightTriangleSquare(a, b, c);
			}
			catch (InvalidRightTriangleException)
			{
				return TestError;
			}
		}
	}
}
