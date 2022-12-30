using nilnul.num.real.func_.unary.neighbored_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary.neighbored_.integrable
{
	/// <summary>
	///
	/// </summary>
	static public class _MeanX
	{
		static public double Mean(Integrable4dblI integrable)
		{
			return _IntegralX.Integrate(integrable) / integrable.neighbor.width;
		
		}
	}
}
