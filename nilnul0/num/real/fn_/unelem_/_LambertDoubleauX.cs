using System;

namespace nilnul.num.real.fn_.unelem_
{
	static public class _LambertDoubleauX
	{
		static public readonly double NegExpInv= -Math.Exp(-1);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// 
		/// </param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public static double LambertDoubleau(double x)
		{
			// LambertW is not defined in this section
			if (x < NegExpInv)
				throw new ArgumentOutOfRangeException("The LambertW-function is not defined for " + x + ".");

			if (x ==NegExpInv)
			{
				return -1;
			}
			if (x<0)
			{
				throw new ArgumentOutOfRangeException("The LambertW-function is bivalence when " + x + " is in (-1/e, 0);");

			}

			
			return _LambertDoubleau_0nonneg(x);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static double _LambertDoubleau_0nonneg(double x)
		{
			/// https://stackoverflow.com/questions/60211021/lambert-w-function-in-c-sharp
			/// answered Feb 13, 2020 at 15:14
			/// Pixel_95

			// computes the first branch for real values only

			// amount of iterations (empirically found)
			int amountOfIterations = Math.Max(4, (int)Math.Ceiling(Math.Log10(x) / 3));

			// initial guess is based on 0 < ln(a) < 3
			double w = 3 * Math.Log(x + 1) / 4;

			// Halley's method via eqn (5.9) in Corless et al (1996)
			for (int i = 0; i < amountOfIterations; i++)
				w = w - (w * Math.Exp(w) - x) / (Math.Exp(w) * (w + 1) - (w + 2) * (w * Math.Exp(w) - x) / (2 * w + 2));

			return w;

			/// https://en.wikipedia.org/wiki/Lambert_W_function
			/// http://www.meta-numerics.net/documentation/html/bf8aa951-348f-67ec-e2a4-3c1d5faf08dc.htm
		}
	}
}
