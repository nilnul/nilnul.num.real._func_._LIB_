using System;
using System.Linq.Expressions;

namespace nilnul.num.real.func_.unary_._derivable_
{

	public interface Derivative4dblI {
		Expression<Func<double, double>> derivative { get; }
	}
}
