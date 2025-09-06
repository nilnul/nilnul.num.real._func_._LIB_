using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.elemental_
{
	///math.stackexchange.com/questions/118113/what-makes-elementary-functions-elementary
	///
	/// goblin GONE Commented Nov 4, 2013 at 3:40:
	/// there's no reason to have a fixed, unchanging notion of "elementary function."
	///
	/// <see cref="nilnul.num.complex.fn_."/> for a more reasonable definition.
	/// 
	/// <summary>
	/// the base cases for this recursively defined concept;
	/// </summary>
	/// <remarks>
	/// there is some discent in mathematicians about whether some should be included, such as:
	///		absolute
	///		,
	/// </remarks>
	/// alias:
	///		basic
	///		primitive
	public interface IBasic:fn_.IElementary
	{
	}
}
