using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.between_.convex.min._slv_.by_
{
	static public class _FibonacciX
	{

		static public double _Solve_0convex_2right(
			Func<double, double> convex
			,

			double left, double right

		)
		{
		  double GoldenMinorComplement =  nilnul.num.real_.eg_._GoldenRatioX.LtOneComplement;

			//var leftVal = convex(left);
			//var rightVal = convex(right);

			double leftDeviate = (right - left) * GoldenMinorComplement;

			var fibLeft = left + leftDeviate;

			//double rightDeviate = span * 0.618;

			var fibRight = right - leftDeviate;

			var fibLeftVal = convex(fibLeft);
			var fibRightVal = convex(fibRight);

			/// some of the scope might be linear, but remained part might be curvature; So we still need to go thru the whole scope;

			while (fibLeft < fibRight)
			{

				if (fibLeftVal == fibRightVal)
				{
					left = fibLeft;
					right = fibRight;

					//span = right - left;

					leftDeviate = (right - left) * GoldenMinorComplement;

					//rightDeviate = span - leftDeviate;

					fibLeft = left + leftDeviate;
					fibRight = right - leftDeviate;

					fibLeftVal = convex(fibLeft);
					fibRightVal = convex(fibRight);

				}
				else if (fibLeftVal < fibRightVal)
				{
					/// the min is between <see cref="left"/> <see cref="fibRight"/>
					///

					right = fibRight;
					//rightVal = fibRightVal;

					fibRight = fibLeft;
					fibRightVal = fibLeftVal;

					/// now the span is: <see cref="rightDeviate"/>
					///
					fibLeft = left + (leftDeviate *= GoldenMinorComplement);
					fibLeftVal = convex(fibLeft);



				}
				else
				{
					left = fibLeft;
					//leftVal = fibLeftVal;

					fibLeft = fibRight;
					fibLeftVal = fibRightVal;

					fibRight = right - (leftDeviate *= GoldenMinorComplement);
					fibRightVal = convex(fibRight);

				}

			}
			return fibLeft;


		}
		static public double _Solve_0convex_1band(
			Func<double, double> convex
			,

			(double, double) bind

		)
		{
			return _Solve_0convex_2right(convex, bind.Item1,bind.Item2);

		}


	}
}
