using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.unelem_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		lambert, but lambertW means its inverse.
	///
	static public class _LambertBeforeInverse
	{
		/// <summary>
		///  the derivative is:
		///		ln(a) a^x +b
		///	;
		///	 when b is positive or nil, it's an upward function. f(-inf) = -inf, f(inf) =inf.
		///	
		///	when b is negative,  the 2nd derivative is:
		///		ln(a)ln(a) a^x
		///	, hence it's a convex function.
		///	, f(-inf) = f(inf) =inf; there is a min point: ln(a, -b/ln(a) )
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		static public Expression<Func<double,double>> LambertBeforeInverse(double a, double b, double c) {
			return x => Math.Pow(a, x) + b * x + c;
		}

	}
}
