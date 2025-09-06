using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real_.nonneg.fn_.increase_.polyline_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// often used to calculate tax of personal revenue;
	/// </remarks>
	/// alias:
	///		anchored
	///		moored
	static public class _OriginatedX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="grads">
		///A SEQUENCE OF <see cref="nilnul.geometry.planar.Grad"/>
		/// each member is (slope, terminal);
		/// the slope is positive
		/// 
		/// eg:
		///		(0, 0)
		///		(.03, 36000)
		///		,
		///		(.1, 144000)
		///		,
		///		(.2, 300000)
		///		,
		///		(.25, 420_000),
		///		(.3, 660_000)
		///		,
		///		(.35, 960_000)
		///		,
		///		(.45, double.PositiveInfinity)
		///, where the last one's terminal is always Inf.
		/// </param>
		/// <param name="income"></param>
		/// <returns></returns>
		/// <exception cref="UnexpectedReachException"></exception>
		static public double _Dbl_0rateNonneg9EndNondecreaseTilInf_1nonneg(
			IEnumerable<(double rate, double terminal)> grads
			,
			double income
		)
		{

			var r = 0d;

			var gradBegin = 0d;

			foreach (var item in grads)
			{
				if (item.terminal <= income)
				{
					r += item.terminal * item.rate;
				}
				else
				{
					return r + (income - gradBegin) * item.rate;
				}
				gradBegin = item.terminal;

			}

			throw new UnexpectedReachException(
				$"{income} being finite shall be lt {double.PositiveInfinity};"
			);

		}

		static public double _Dbl_0rateNonneg9EndNondecreaseTilInf_1nonneg(
			(double rate, double terminal)[] grads
			,
			double income
		)
		{

			return _Dbl_0rateNonneg9EndNondecreaseTilInf_1nonneg(
				(IEnumerable<(double rate, double terminal)>)grads
				,
				income
			);

		}

		static public double _Dbl_0rateNonneg9EndNondecrease_1nonnegRate4last_2nonneg(
			(double rate, double terminal)[] grads
			,
			double rateLast
			,
			double income
		)
		{
			return _Dbl_0rateNonneg9EndNondecreaseTilInf_1nonneg(
				grads.Append( (rateLast,double.PositiveInfinity))
				,
				income
			);

		}


	}
}
