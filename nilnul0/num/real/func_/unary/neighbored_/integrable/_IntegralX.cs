using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary.neighbored_.integrable
{
	/// <summary>
	/// definite integral
	/// </summary>
	static public class _IntegralX
	{
		static public double Integrate(Integrable4dblI integrable) {
			var antiderive = integrable.antiderivative.Compile();
			return antiderive(
				integrable.neighbor.avowed.upper.mark
			)
				-
			antiderive(
					integrable.neighbor.avowed.lower.mark
			);
		}
	}
}
