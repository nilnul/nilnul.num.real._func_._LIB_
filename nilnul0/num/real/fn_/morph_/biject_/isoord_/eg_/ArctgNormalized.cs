using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.morph_.biject_.isoord_.eg_
{
    internal class ArctgNormalized
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="r">
		/// any real number
		/// </param>
		/// <returns>
		/// (-1,1)
		/// </returns>
		static public double Morph(double r) {
			return Math.Atan(r) /
				nilnul.num.real_.eg_._Tau4dblX.QUARTER
			;
		}
    }
}
