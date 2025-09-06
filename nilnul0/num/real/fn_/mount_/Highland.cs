using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_.mount_
{
	static public class _HighlandX
	{
		public const double RADIUS = .5;
		static public double Highland(double x) {

			if (x>-RADIUS && x < RADIUS)
			{
				return 1;
			}
			return 0;
		}
	}
}
