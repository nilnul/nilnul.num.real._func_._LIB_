using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_
{

	/// maybe this is better defined in complex numbers, as there trigonometric/hyperbolic/exponential function can be expressed as polynomial and logarithm and exponential.
	/// eg:
	///		e^z = cos(z) + i sin(z)
	///
	///
	/// use +, and hyperoperations such as ,*, ** which is also ^, *** which is also called tetration as it's 4 pluses.
	/// <summary>
	/// recursively defined as <see cref="fn_.elemental_.IBasic"/> and <see cref="fn_.elemental_.INonbasic"/>
	/// </summary>
	/// <remarks>
	/// Ritt's theorem shows that no antiderivatives, no differentiation and no differential fields are needed for defining the Elementary functions.
	/// </remarks>
	/// alias:
	///		arithmetic
	///	<see cref="nilnul.num.real.fn_.IConstant"/>
	/// 
	public interface IElementary
		:
		IFn
		,
		func_.IUnary
		,
		func_.IElementary
	{

	}



}
