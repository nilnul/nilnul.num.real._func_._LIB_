using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.convert.of_.unary_
{
	/// <summary>
	/// f(x)/f'(x), used in <see cref="func_.unary_.monotone_.strict.be_.nil.solve_._Newton9raphsonX"/>
	/// </summary>
	static public  class _StepX
	{

		static public Func<double, double> _Step_1derivative(Func<double,double> f, Func<double,double> _deriv) {
			return d => f(d) / _deriv(d);
		}
	}
}
