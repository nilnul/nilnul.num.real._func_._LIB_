using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.fn_
{

	internal class Sinc
		: nilnul.obj.OpI5<double>
		//,nilnul.num.real.op_._unary_.OfClass
	{
		public double op(in double obj)
		{
			if (obj==0)
			{
				return 1;
			}

			return Math.Sin(obj) / obj;
		}
	}
}
