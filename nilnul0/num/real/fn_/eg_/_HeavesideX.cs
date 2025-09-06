using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.eg_
{
	/// en.wikipedia.org/wiki/Heaviside_step_function
	///
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="_SignX"/>
	/// </remarks>
    static public class _HeavesideX
    {
		/// <summary>
		/// 0, 0.5, 1
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double Op(double x) {
			return x < 0 ? 0 :( x > 0 ? 1 : .5 );
		}
    }


}
