using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.unelem_
{
	/// <summary>
	/// The branches of Lambert W are the local inverses of the Elementary function f	with f(z)=zez, z∈C
	/// ; or
	/// the lambert W function:
	///		ye^y =a
	/// , which is an inversal of x-> xe^x; in other words, y=w(a) = w(ae^a)
	/// ;
	/// here we say y=w(a).eg:
	///		ye^y =3, then y= w(3);
	///
	///		
	///		
	/// </summary>
	/// <remarks>
	/// when x lt -1/e, there is no solvent;
	/// when x =-1/e, then y = -1
	/// when x is in (-1/e, 0), then y can take two values.
	/// when x ge 0, then y can take only one value; eg: x=0, and y=0.
	/// The non-elementarity of LambertW was already proved by Liouville;
	///  two hyper-operations, multiplication and exponentiation, were combined. In general, combining different hyper-operations results in unsolvable inverses
	/// </remarks>
	public interface ILambertDoubleau:IFn
	{
	}
}
