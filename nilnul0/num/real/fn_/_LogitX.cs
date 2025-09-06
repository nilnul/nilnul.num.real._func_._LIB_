using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.fn_
{
	static public class _LogitX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="p">
		/// <see cref="nilnul.num.real.bound_.fuzzy_.IPortion"/>:(0,1),  not partial: (0,1)
		/// </param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _Logit_0portion(double p) {
			return Math.Log(
				p/(1-p)
			);
		}
	}


}
