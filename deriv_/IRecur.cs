using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func.deriv_
{
	/// recur is a subtype, not extension. So it's put under the namespace of <see cref="deriv_"/>, not <see cref="deriv"/>
	///
	/// <summary>
	/// 
	/// derive of <see cref="func.IDerivative"/>
	/// </summary>
    public interface IRecur:func.IDerivative
    {
    }
}
