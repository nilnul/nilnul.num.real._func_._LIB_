namespace nilnul.num.real.fn_
{
	/// <summary>
	/// the solvent of <see cref="fn_.IPolynomial"/>.
	/// that is, the fn:"y" can appear in the expression explicitly.
	/// eg:
	///		y^2* x + xy+x+y =1
	///	
	/// </summary>
	/// <remarks>
	/// this is defined as <see cref="fn_.IElementary"/>, <see cref="fn_.elemental_.basic_.IAlgebraic"/>.
	/// </remarks>
	/// vs:
	///		transcendental, when it's not algebraic
	///	vs:
	///		algebraic expression, algebraic fraction, rationale
	public interface IAlgebraic
		:IFn
	{
	}



}
