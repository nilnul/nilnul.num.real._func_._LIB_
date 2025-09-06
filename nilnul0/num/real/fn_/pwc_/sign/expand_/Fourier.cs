using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace nilnul.num.real.convert_.pwc_.sign.sinHalf.expand_
{
	/// <summary>
	/// </summary>
	static public class _FourierX
	{
		static public IEnumerable<Func<double, double>> Funcs() {
			var i = 0;
			while (true)
			{
				yield return x => 4 / Math.PI * Sin(Math.PI);

			}
		}
	}
}
