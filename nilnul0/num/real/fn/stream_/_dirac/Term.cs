using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn.stream_._dirac
{
    class Term
    {
		double _radius;
		double _radiusSq;

		 Term(double _radius)
		{
			this._radius= _radius;
			_radiusSq = _radius * _radius;
		}

		double op(double x) {

			return Math.Exp(
				-x * x / _radiusSq
			) /
			(
				nilnul.num.real_.eg_.pi._SqrtX.AsDbl * _radius
			); /// the normal distribution density

		


		}
    }
}
