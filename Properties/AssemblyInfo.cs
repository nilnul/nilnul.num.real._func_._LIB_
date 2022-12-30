using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("nilnul.num.real._func_._LIB_")]
[assembly: AssemblyDescription("real number function, a mapping from real number to real number; a set is equipotent to the power set of R")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("nilnul.com")]
[assembly: AssemblyProduct("nilnul.num.real._func_._LIB_")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("nilnul.num.real._func_._LIB_")]
[assembly: AssemblyCulture("")]

//将 ComVisible 设置为 false 将使此程序集中的类型
//对 COM 组件不可见。  如果需要从 COM 访问此程序集中的类型，
//请将此类型的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("b3837c71-94f7-47d5-80ac-850adb1a0b94")]

// 程序集的版本信息由下列四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
//可以指定所有这些值，也可以使用“生成号”和“修订号”的默认值，
// 方法是按如下所示使用“*”: :
[assembly: AssemblyVersion("1.1.0.1")]
//[assembly: AssemblyVersion("1.0.2.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]


/*
 
	 nilnul.num.real.expr shall not be a seperate assembly while nilnul.num.real.func shall in that:
	 1) nilnul.num.real.func is a set of cardinality R^R, which is Beth2, higher than R, which is Beth1. So this is a significant increase of objects being studied and goes beyond what nilnul.num.real can hold.
	 2) nilnul.nu.real.expr shall be merged with nilnul.num.real / nilnul.num.real._func. many properties of objects have to be expressed in expr; for example, the associativity of addition; so expression assembly shall be meraged to nilnul.num.real.
	 */

