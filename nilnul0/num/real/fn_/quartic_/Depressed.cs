using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.quartic_
{
	static public class _DepressedX
	{

		/// <summary>
		/// of:
		///		x^4 + a x^3 + b x^2 + c x+ d
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		//static public (double a, double b, double c) OfStandard(
		//	double a, double b, double c,double d
		//) {
		//	return (

		//	);
		//}



		/// <summary>
		/// of:
		///		a x^4 + b x^3 + c x^2 + d x + e
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <param name="e"></param>
		/// <returns>
		///  y ^4 + a y^2 + b y + c
		/// </returns>
		static public (double a, double b, double c) _OfGeneral_0nonnil(
			double a, double b, double c,double d,double e
		) {
			var bSq = b * b;
			var bCubic = b * bSq;
			var bPow4 = b * bCubic;

			var _2aSq = 2 * a * a;
			var _4aSq = 2 * _2aSq;
			double _8aSq = 2*_4aSq;

			double _8aCubed = _8aSq * a;

			double _256_aPow4 = 32 *a * _8aCubed;

			return (
				-3* bSq / _8aSq + c/ a
				,

				bCubic / (_8aSq*a) - b*c /(_2aSq) + d/a
				,
				-3* bPow4 / _256_aPow4 + c*bSq / (_8aCubed *2 ) - b*d / (_4aSq) + e/a
			);
		}


	}


}
