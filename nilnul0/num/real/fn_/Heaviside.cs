using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_
{

	public class Heaviside
		:
		nilnul.num.real.of_.Unary4dblI
	{
		public double op(double x)
		{
			var sign = x == 0 ? (bool?)null : x > 0;
			switch (sign)
			{
				case null:
					return .5;
				case true:
					return 1;

				default:
					return 0;
			}



		}
	}
}
