using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary_.rational_
{
	/// <summary>
	/// </summary>
	/// alias:
	///		logistic
	///		or logis
	public class Logistic
		:
		nilnul.num.real.op_.Unary4dblI
	{
		public double op(double x)
		{
			return 1 / (1 + Math.Exp(x));
		}

		static public Logistic Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Logistic>.Instance;
			}
		}

	}


}
