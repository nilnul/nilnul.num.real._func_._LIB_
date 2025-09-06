using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func.src.deriv1st_
{
	/// <summary>
	/// nabla :
	///		f(x + hv) -f(x)
	///		/
	///		h
	///		, as h -> 0
	///		,where v is the directional(unnil) vector.
	/// </summary>
	/// alias:
	///		der_.dir
    public interface IDirectional:src.IDerivative1st
    {
    }
}
