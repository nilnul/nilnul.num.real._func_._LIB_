using nilnul.obj;
using System.Numerics;

namespace nilnul.num.real.fn_
{
	/// mathoverflow.net/questions/373513/invertibility-of-specific-function/373653#373653
	/// 
	/// a closed form depends of course on one's definition. One plausible definition is that a closed-form function is a function that lies in a so-called Liouvillian extension of C(x), the field of rational functions of x  with complex coefficients.I won't give the exact definition of a Liouvillian extension, but suffice it to say that any function that you can get via a finite number of applications of addition, subtraction, multiplication, division, taking nth roots, exponentiation, and taking logarithms is going to be a closed-form function in this sense.Note that since we're working over the complex numbers, we get trig functions and their inverses as well. So this covers everything that most everyone would agree is "closed form." (Liouvillian extensions also include algebraic functions that aren't expressible using radicals; not everyone would consider such functions to be expressible in "closed form," but since we're going to show that a certain function is not expressible in closed form, it doesn't hurt to include extra functions in our class of "closed-form functions.")
	/// <summary>
	/// <see cref="fn_.algebraic_.IClosedForm"/>
	/// </summary>
	/// <remarks>
	/// <see cref="IOpenForm"/> which contains open form like infinite loops such as stream, series, limits, integrals
	/// </remarks>
	/// alias:
	///		cloform
	public interface IClosedForm:IFn
	{
	}


}
