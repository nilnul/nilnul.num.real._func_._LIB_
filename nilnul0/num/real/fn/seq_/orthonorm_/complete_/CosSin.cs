using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace nilnul.num.real.convert.seq_.orthonorm_.complete_
{

	internal class CosSin
	{
		public static readonly double SqrtPi = Sqrt(Math.PI);
		static public IEnumerable<Expression<Func<double, double>>> Seq()
		{
			yield return x => 1 / Sqrt(nilnul.num.real_._Tau4dblX.FULL);

			for (int i = 0; ; i++)
			{
				yield return x => Cos(i * x) / SqrtPi;
				yield return x => Sin(i * x) / SqrtPi;


			}


		}
	}
}
