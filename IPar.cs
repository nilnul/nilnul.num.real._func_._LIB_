using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func
{
	/// <summary>
	/// eg:
	///		(x+y)=>xyz, where x,y is par, z is not par; x,y,z are all vars; z is nonpar var;
	/// </summary>
	/// vs:
	///		var|<see cref="nilnul.obj.expr_.IVar"/>, which is a concept for <see cref="nilnul.obj.IExpr"/> whileas some vars are not pars|<see cref="nilnul.obj._func_.ParsI{T}"/>, and we can abstract a par that is not in the vars of an expr like in eg: x-> y, where y is variable, and x is parameter;
	public interface IPar
	{
	}
}
