using System;
using System.Linq.Expressions;

namespace nilnul.num.real.func_.unary
{
	public interface Spanned4dblI
		:_neighbored_.Neighbor4dblI
		
	{
		Expression<Func<double, double>> func { get; }
	}
}
