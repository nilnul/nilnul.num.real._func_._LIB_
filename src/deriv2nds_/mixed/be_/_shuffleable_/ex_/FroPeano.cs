using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func.src.deriv2nds_.mixed.be_._shuffleable_.ex_
{
	/// <summary>
	/// 
	/// </summary>
    class FroPeano
    {
		/// <summary>
		/// df/dx = -y,
		/// df/dy =x
		///
		/// are continuous
		/// 
		/// df/dx = df/dy = 0 at (0,0);
		/// ;
		///
		/// but the deriv2nd are not continuous at (0,0):
		///  df/(dydx) =1, at (0,0)
		///  df/(dxdy) = -1
		/// ; at every other point, the symmetry holds
		/// 
		/// </summary>
		/// <remarks>
		/// 
		///
		/// </remarks>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public double Op(double x, double y) {
			if ((x,y) ==(0,0))
			{
				return 0;
			}

			double xSq = x * x;
			double ySq = y * y;
			return x * y * (xSq - ySq) / (xSq+ySq);
		}


		static public double Op_0azumuth_1amplitude(double r, double a) {
			return r*r *Math.Sin(4*a) / 4;
		}


    }
}
