using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_
{
	public class Sigmoid
	{

		static public double Eval(double x) {
			return 1.0 / (1 + Math.Log(-x));
		}
	}
}
