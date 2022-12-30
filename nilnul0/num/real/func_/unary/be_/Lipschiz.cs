using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_.unary.be_
{
	/// <summary>
	/// f(a)-f(b) &lt;= k|f(a)-f(b)|
	/// 
	/// Given two metric spaces (X, dX) and (Y, dY), where dX denotes the metric on the set X and dY is the metric on set Y, a function f : X → Y is called Lipschitz continuous if 
	///		there exists a real constant K ≥ 0 such that,
	///			for all x1 and x2 in X,	d Y(f ( x 1   ) , f(x 2   ) ) ≤ K d X(x 1   , x 2   ) .
	///	Any such K is referred to as a Lipschitz constant for the function f.The smallest constant is sometimes called the(best) Lipschitz constant; however, in most cases, the latter notion is less relevant.
	///	If K = 1 the function is called a short map, and if 0 ≤ K &lt; 1 the function is called a contraction.

	/// </summary>
	 class Lipschiz
	{
	}
	/*
转寄人: ottffsse (nothing)
标  题: 满足局部lipchitz但是不满足global lipchitz的例子是啥？
发信站: 水木社区 (Thu Jan 19 12:09:38 2017)
来  源: 218.197.87.22

【以下内容由 ottffsse 转寄于 Mathematics 版】
☆─────────────────────────────────────☆
  vinbo (vinbo) 于  (Tue Jan 17 23:59:52 2017)  在
 【满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

这样的函数的例子是啥？想了半天没想出来
※ 来源:·水木社区 http://www.newsmth.net·[FROM: 211.161.244.*]


☆─────────────────────────────────────☆
  SPAM (垃圾邮件) 于  (Wed Jan 18 00:01:46 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

exp(x)
【 在 vinbo (vinbo) 的大作中提到: 】
: 这样的函数的例子是啥？想了半天没想出来
: ※ 修改:·vinbo 于 Jan 18 00:00:58 2017 修改本文·[FROM: 211.161.244.*]
: ※ 来源:·水木社区 http://www.newsmth.net·[FROM: 211.161.244.*]
: ...................



☆─────────────────────────────────────☆
  vinbo (vinbo) 于  (Wed Jan 18 09:37:41 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

thanks. 
【 在 SPAM 的大作中提到: 】
: exp(x)
: ※ 修改:·vinbo 于 Jan 18 00:00:58 2017 修改本文·[FROM: 211.161.244.*]


☆─────────────────────────────────────☆
  vinbo (vinbo) 于  (Wed Jan 18 18:38:48 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

好像x^3也可以
【 在 SPAM 的大作中提到: 】
: exp(x)
: ※ 修改:·vinbo 于 Jan 18 00:00:58 2017 修改本文·[FROM: 211.161.244.*]


☆─────────────────────────────────────☆
  bsxfun (色即是空) 于  (Wed Jan 18 18:45:54 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

任何一个在定义域上无界的连续函数的原函数都是吧


☆─────────────────────────────────────☆
  bsxfun (色即是空) 于  (Wed Jan 18 18:47:08 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

比如 sqrt(x), x^2


☆─────────────────────────────────────☆
  vinbo (vinbo) 于  (Wed Jan 18 18:49:35 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

sin(x)呢？
【 在 bsxfun 的大作中提到: 】
: 任何一个在定义域上无界的连续函数的原函数都是吧



☆─────────────────────────────────────☆
  vinbo (vinbo) 于  (Wed Jan 18 18:50:15 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

sqrt(x)不是局部lipchitz的啊
【 在 bsxfun 的大作中提到: 】
: 比如 sqrt(x), x^2



☆─────────────────────────────────────☆
  bsxfun (色即是空) 于  (Wed Jan 18 19:29:42 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

1. cos(x)是无界的吗？
2. √x 在(0, +inf)上是菊部lipchitz的


【 在 vinbo 的大作中提到: 】
: sin(x)呢？



☆─────────────────────────────────────☆
  vinbo (vinbo) 于  (Wed Jan 18 19:41:31 2017)  在
 【Re: 满足局部lipchitz但是不满足global lipchitz的例子是啥？】 的大作中提到:

哦，我会错意了，“定义域上无界”。。。我以为你说的定义域无界
【 在 bsxfun 的大作中提到: 】
: 1. cos(x)是无界的吗？
: 2. √x 在(0, +inf)上是菊部lipchitz的
: 
	 */
}
