using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_.rational_.invertal_
{
	/// <summary>
	/// </summary>
	/// This is a homographic function.
	/// As a curve, it is also an equilateral hyperbola.
	public class OverIncrement
		:
		nilnul.num.real.op_.Unary4dblI
		,
		IInvertal
	{
		public double op(double x)
		{
			return 1 / (1 + x);
		}

		static public OverIncrement Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OverIncrement>.Instance;
			}
		}

	}
}
