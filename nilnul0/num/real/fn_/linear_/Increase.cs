using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_.polynomial_.linear_
{
	/// <summary>
	/// </summary>
	/// alias:
	///		plus
	public class Increase
		:
		nilnul.obj.Box_ofIn<double>
		,
		nilnul.num.real.op_.Unary4dblI
	{
		public Increase(in double val) : base(val)
		{
		}

		public Increase(double x) : base(x)
		{
		}
		public Increase():this(0)
		{

		}

		public double op(double x)
		{
			return  ( x+boxed);
		}

		static public Increase Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Increase>.Instance;
			}
		}

	}
}
