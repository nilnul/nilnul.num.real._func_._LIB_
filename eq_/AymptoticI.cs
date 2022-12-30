using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func.eq_
{
	/// <summary>
	/// f(x) / g(x) -> 1 as x -> inf
	/// or
	/// f(x) / g(x) -> 1 as x->a, where a is a preset real number.
	/// </summary>
	public interface AsymptoticI:IEqualityComparer<nilnul.num.RealI>
	{

	}


	public abstract class AsymptoticA : AsymptoticI
	{
		public abstract bool Equals(RealI x, RealI y);
		public abstract int GetHashCode(RealI obj);

		/// <summary>
		/// when f(x) is asymptotically Eq g(x), we can notate it as f(x) ~ g(x)
		/// </summary>
		public const char Symbol = '~';
	}
}
