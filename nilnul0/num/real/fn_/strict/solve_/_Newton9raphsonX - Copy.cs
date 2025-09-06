using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.strict.solve_
{
	/// <summary>
	/// The Newton-Raphson method (also known as Newton's method) is a way to quickly find a good approximation for the root of a real-valued function f ( x ) = 0 . It uses the idea that a continuous and differentiable function can be approximated by a straight line tangent to it.
	/// </summary>
	/// <remarks>
	///Newton's method may not work if there are points of inflection, local maxima or minima around initial or the root.
	/// </remarks>
	/// vs:
	///		<see cref="real.xt.fn_.confined_.some2inf_.grow.solve_._BinarySearchX"/>
	///		<see cref="real.fn_.monotone_.strict"/>
	///		<see cref="real.fn_.monotone.ISolve"/>
	static public  class _Newton9raphsonX
	{

		static public double _Newton9raphson_0strict_1deriv_3accuracy(
			Func<double, double> _monotoneStrict
			,
			Func<double, double> _deriv,
			double initial,
			double _accuracy
		)
		{
			var decrement = _monotoneStrict(initial)
				/
				_deriv(initial)
			;

			while (Math.Abs(decrement) > _accuracy)
			{
				initial -= decrement;///Geometrically, (x1, 0) is the intersection of the x-axis and the tangent of the graph of f at (x0, f(x0))
				decrement = _monotoneStrict(initial) / _deriv(initial);
			}

			return initial;
		}

	}
}
