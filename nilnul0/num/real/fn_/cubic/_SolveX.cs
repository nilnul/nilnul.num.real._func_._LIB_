using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.cubic
{
	static public class _SolveX
	{

		/// <summary>
		/// a x^3 + b x^2 + c x + d
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		static public double Discriminant(double a, double b, double c,double d) {
			//var bc = b * c;
			var ac = a * c;
			var bd = b * d;
			var bSq = b * b;
			var cSq = c * c;

			var ad = a * d;

			return 18 * ac * bd - 4 * bSq * bd + bSq * cSq - 4 * ac * cSq - 27 * ad * ad;


			//var aSq = a * a;
			//return (
			//	4 * nilnul.num.real.op_._CubicX.Cubic(bSq - 3 * ac)
			//	-
			//	nilnul.num.real.op_.Square.Singleton.op(
			//		2 * bSq * b - 9 * ac * b + 27 * aSq * d
			//	)
			//)
			///
			//(27 * aSq);
		}


	}
}
