using System;
using System.Linq.Expressions;

namespace nilnul.num.real.func_.unary.neighbored_._integrable_
{
	public interface Antiderivative4dblI {
		Expression<Func<double, double>> antiderivative { get; }

	}
}
