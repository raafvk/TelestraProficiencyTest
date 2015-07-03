using System;

namespace TelestraTest
{
	public class MathUtils
	{
		/// <summary>
		/// Find the average of two numbers
		/// </summary>
		/// <param name="a">First number.</param>
		/// <param name="b">Second Number.</param>
		public static double Average(int a, int b)
		{
			return (double) (a + b) / 2; //here double cast operator has precedence over division, so (a+b) first converted to type double and divide by 2 results in a double value
		}
	}
}

