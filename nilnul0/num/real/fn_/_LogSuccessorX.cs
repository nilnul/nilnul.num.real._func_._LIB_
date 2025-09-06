using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_
{
	static public class _LogSuccessorX
	{
		/// <summary>
		/// when x gt -1.
		/// when x = -1, this is exception.
		/// when x lt -1, this is exception.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double LogSuccessor(double x) {
			return Math.Log(x + 1);
		}
	}
}
