using nilnul.bit.op.set_.complete_.doublet_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.cubic_
{
	/// <summary>
	/// t^3 + pt +q;
	/// </summary>
	public class Depressed
		:nilnul.num.real.Op4dblI
		,nilnul.num.real.op_.Unary4dblI
	{
		private double _linear;

		public double linear
		{
			get { return _linear; }
			set { _linear = value; }
		}

		private double _constant;

		public double constant
		{
			get { return _constant; }
			set { _constant = value; }
		}

		public Depressed(double linear, double constant)
		{
			this._linear = linear;
			this._constant = constant;
				
		}

		public double op(double par)
		{
			return nilnul.num.real.op_._CubicX.Cubic(par) + _linear * par + _constant;
		}
	}
}
