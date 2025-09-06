using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_._polynomial
{
	/// <summary>
	/// a single term;
	/// eg:
	///		x^2
	///		3x
	///		x^0
	///		3x^0
	///		2*x^0
	///		2*1
	///		2
	///		1
	///		5xy^2
	///	exclude:
	///		
	///		0*x
	///		0*x^0
	///		0, as 0 is the coefficient of 0*1, and we don't count 0-coeffient terms when we define monomial, binomial, trimonial, etc;
	/// </summary>
	/// <remarks>
	/// any polynomial is a linear combination of them, so they form a basis of the vector space of all polynomials, called the monomial basis 
	/// </remarks>
	/// alias:
	///		monomial, where mono, like "bi-" in binomail, doesnot mean the coef, but the count of terms.
	///			,some would require the coef to be 1;
	///		power product
	///		primitive monomial
	/// <see cref="fn_.polynomial_.IMonomial"/>
	/// <see cref="fn_.IPolynomial"/>
	public interface IMonomial
	{
	}
}
