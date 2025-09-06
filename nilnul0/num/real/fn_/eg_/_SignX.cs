namespace nilnul.num.real.fn_.eg_
{
	static public class _SignX
    {
		/// <summary>
		/// -1, 0, 1
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double Op(double x) {
			return x < 0 ? -1 :( x > 0 ? 1 : 0 );
		}
    }


}
