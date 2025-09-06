using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.convert.seq_.orthonorm_.complete
{
	/// <summary>
	/// the expansion converges in L^2 sense;
	/// </summary>
	internal class ExpandPiecewiseContinuous
	{
		static public IEnumerable<Expression<Func<double, double>>> Terms4series(
			IEnumerable<Func<double,double>> orthonorms
			,
			Func<double,double >x
		) {
			return orthonorms.Select(
				b=>(Expression<Func<double, double>>)(
					(double r)
					=>
					b(r) * convert.co.innerProd_.RetXpn.InnerProd(
						b,x
					)
				)
			);
		}
	}
}
