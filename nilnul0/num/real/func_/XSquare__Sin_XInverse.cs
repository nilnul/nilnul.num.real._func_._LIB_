using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.func_
{
	/// <summary>
	///  Though the derivative of a differentiable function never has a jump discontinuity, it is possible for the derivative to have an essential discontinuity. For example, the function
	/// </summary>
	public class XSquare__Multi__Sin_XInverse
	{
		static public R Eval(R x) {
			return nilnul.num.real.op_.binary_.Multi.Singleton.op(
				nilnul.num.real.op_.unary_.Square.Singleton.op(x)
				,
				nilnul.num.real.op_.unary_.Sin.Singleton.op(
					nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(x)	
				)	
			);
		}
	}
}
