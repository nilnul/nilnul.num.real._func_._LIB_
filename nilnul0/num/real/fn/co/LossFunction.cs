using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn.co
{
	/// <summary>
	/// loss means the integrate of (f1(x) -f(x) )^2 over all x, measuring how one curve of the function fits the other;
	/// eg:
	///		fit a curve using a <see cref="num.real.fn_.polynomial_.IHexic"/>, the loss  would be a function of the coefficients k[i] where i = 0 + 6, meaning 0,1,2,..,5
	/// </summary>
	/// alias:
	///		loss = f -f1
	///		gain = f1-f
	internal class Loss
	{
	}
}
