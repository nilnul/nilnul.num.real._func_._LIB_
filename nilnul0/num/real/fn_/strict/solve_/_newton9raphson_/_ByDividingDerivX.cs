using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.strict.solve_.newton9raphson_
{
	static public  class _ByDividingDerivX
	{

		/// <summary>
		/// use the <see cref="convert.of_.unary_._StepX"/> as the decrease for each iteration;
		/// </summary>
		/// <param name="_funcDividingDeriv">
		/// this is called step function, as f(x[i]) is the value of the function thus ( f(x[i])-0 ) /  f'(x[i]) is a step towards x such that f(x) =0
		/// </param>
		/// <param name="initial"></param>
		/// <param name="_accuracy"></param>
		/// <returns></returns>
		static public double _Newton9raphson_0strictDivideDeriv_2accuracy(
			Func<double, double> _funcDividingDeriv
			,
			double initial,
			double _accuracy
		)
		{
			var decrement = _funcDividingDeriv(initial)
				
			;

			while (Math.Abs(decrement) > _accuracy)
			{
				initial -= decrement;///Geometrically, (x1, 0) is the intersection of the x-axis and the tangent of the graph of f at (x0, f(x0))
				decrement = _funcDividingDeriv(initial) ;
			}

			return initial;
		}

	}
}
