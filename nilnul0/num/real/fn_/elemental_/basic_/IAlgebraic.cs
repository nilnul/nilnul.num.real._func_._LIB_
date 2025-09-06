using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.elemental_.basic_
{
	/// <summary>
	/// <see cref="real.fn_.IAlgebraic"/> is defined as <see cref="IElementary"/> even though it might be with no closed form;
	/// </summary>
	public interface IAlgebraic
		:
		elemental_.IBasic
		,
		num.real.fn_.IAlgebraic
	{
	}
}
