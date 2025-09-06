using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.quadratic
{
	static public class _SolveX
	{
		/// <summary>
		/// the x coordinate for the min or max point, or the apex|peak point;
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		static public double ExtremalAt(double a, double b, double c) {
			return -  b / (2*a) ;
		}

		static public double Discriminant(double a, double b, double c) {
			return b * b - 4 * a * c;
		}

		/// <summary>
		/// radius
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		static public double Delta(double a, double b, double c) {
			return Discriminant(a,b,c) / (2*a);
		}


		static public (double p, double q) _Solve_0nonnil(double a, double b, double c) {
			var discriminant = Discriminant(a,b,c);
			if (discriminant<0)
			{
				throw new ArgumentException("Delta is negative, hence there is no real solvent;");
				/// for complex solvent, see <see cref="nilnul.num.complex.fn"/>
			}

			var twoA = 2 * a;
			var extremalAt = -b/twoA;

			/// radius
			var delta = Math.Sqrt( discriminant) / twoA;

			return (
				extremalAt - delta
				,
				extremalAt + delta
			);
		}
	}
}
