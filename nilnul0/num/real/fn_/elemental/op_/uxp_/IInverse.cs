using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.elemental.op_.uxp_
{
	/// the inverse of some, not all, <see cref="fn_.IElementary"/>, such as "sin","x^2", "e^x", is still regarded as <see cref="fn_.IElementary"/>;
	/// in other words, <see cref="fn_.IElementary"/> is closed only under operation of these, not all;
	/// <summary>
	/// </summary>
	/// <remarks>
	///  a combination of different levels of hyper-operations (except addition) cannot be inverted. For example: <see cref="fn_.unelem_.ILambertDoubleau"/>
	/// </remarks>
	public interface IInverse
	{
	}
}
