namespace nilnul.num.real.fn_
{
	/// <summary>
	/// in a domain of <see cref="nilnul.num.real.borel.be_.IContinuous"/>, the range is also continuous.
	/// including:
	///		<see cref="num.real.borel_.interval_.ISpanned"/> to continuous value.
	/// excluding:
	///		uncontinous domained
	///		, such as single point.
	///
	///		
	/// </summary>
	/// <remarks>
	/// defined on: <see cref="nilnul.num.real.borel_.IContinuous"/>, and is: <see cref="nilnul.num.real.fn_.IContinuous"/>
	/// </remarks>
	/// vs:
	///		curve, which excludes point that is continuous, but the range is not continuous (but a single point)
	///		
	public interface IContinuous:IBorel
	{
	}



}
