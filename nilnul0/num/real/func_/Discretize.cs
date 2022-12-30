using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.func_
{
	public class Discretize<T>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="points"></param>
		/// <param name="_ranks__len_Eq_PointsLenPlus">
		/// length = points.Length+1;
		/// 
		/// </param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public T _Eval(double[] points , T[] _ranks__len_Eq_PointsLenPlus,double x)
		{

			for (int i = 0; i < _ranks__len_Eq_PointsLenPlus.Length - 1; i++)
			{
				if (x < points[i])
				{
					return _ranks__len_Eq_PointsLenPlus[i];
				}

			}

			return _ranks__len_Eq_PointsLenPlus.Last();

		}
	}
}
