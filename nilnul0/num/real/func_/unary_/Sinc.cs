using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_
{
	static public class _SincX
	{
		static public double Sinc(double x) {
			if (x==0)
			{
				return 1;
			}
			return Math.Sin(x) / x;
		}
	}
}
