using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_.eg_
{
	/// <summary>
	/// Λ(n)
	/// </summary>
	internal class VonMangoldt
		: nilnul.obj.OfI1<double, uint>
	{
		/// <summary>
		/// if <paramref name="par"/> is p^k, when k is positive num, p is prime, then the returned value is ln(p);
		/// otherwise, the returned value is 0.
		/// </summary>
		/// <param name="par"></param>
		/// <returns>
		/// 0, 0, ln(2), ln(3), ln(5), 0, ln(7), ln(2), ln(3), ...
		/// </returns>
		/// <exception cref="NotImplementedException"></exception>
		public double op(uint par)
		{

			throw new NotImplementedException();
		}
	}
}
