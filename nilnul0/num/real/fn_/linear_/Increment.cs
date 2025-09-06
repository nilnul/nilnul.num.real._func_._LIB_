using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_.polynomial_.monic_
{
	/// <summary>
	/// </summary>
	public class Increment
		:
		nilnul.num.real.op_.Unary4dblI
	{
		public double op(double x)
		{
			return  (1 + x);
		}

		static public Increment Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Increment>.Instance;
			}
		}

	}
}
