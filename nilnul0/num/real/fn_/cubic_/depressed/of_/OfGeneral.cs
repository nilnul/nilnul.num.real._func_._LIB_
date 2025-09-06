using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.cubic_.depressed.of_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _OfGeneralX
	{
		static public Depressed _OfGeneral_0nonnil(double a, double b, double c, double d) {



			double bSq = b * b;
			var aSq = a * a;
			var ac = a * c;


			//var x =   (double t )=> t - b / (3 * a);
			//var t =  (double x )=> x + b / (3 * a);

			return new Depressed(
				(3* ac - bSq ) / (3* aSq)
				,
				(2*bSq*b - 9 *ac*b + 27*aSq*d ) / (27*aSq*a)
			);
		}
	}
}
