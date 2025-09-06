using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.claspy.be_
{
	/// <summary>
	/// differentiable on open interval (a,b)
	/// </summary>
	/// <remarks>
	/// approaching to the extrem, the derivative might oscillate too much. So the inside derivative might be nonexistent.
	/// </remarks>
	/// alias:
	///		InnerDifferentiable
	/// vs:
	///		<see cref="d"/>
	public interface ISlopy8inner:IContinuous
	{
	}

}
