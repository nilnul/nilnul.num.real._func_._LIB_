using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.xt.fn_.eg_
{
    class Dirac8dbl
		:nilnul.num.real.xt.IOp4dbl
    {
		public double op(double x) {
			if (x==0)
			{
				return double.PositiveInfinity;
			}
			return 0;

		}
    }
}
