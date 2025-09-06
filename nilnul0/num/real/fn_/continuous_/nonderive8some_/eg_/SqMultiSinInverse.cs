using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.continuous_.nonderive8some_.eg_
{
	internal class SqMultiSinInverse
	{
		/// <summary>
		/// it's continuous, as x->0, op(x) -> 0
		/// </summary>
		/// <remarks>
		/// f'(x) = 2x * Sin(1/x) + x^2 * cos(1/x) / -x^2 = 2x * sin(1/x) -cos(1/x) 
		/// </remarks>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double Op(double x) {
			return x==0?0: num.real.op_.Square.Singleton.op(x) * Math.Sin(1 / x);
		}
	}
}
