int a = 10;
int b = 20;
int c = 30;
string str = "csharp";

//调用值传递函数
AMethod(a);
Console.WriteLine($"(1)a的初始值=10，经过[AMethod]方法(+10)，值传递之后，i={a}");
Console.WriteLine();

//调用引用传递函数
BMethod(ref b);
Console.WriteLine($"(2)b的初始值=20，经过[BMethod]方法(+10)，ref值传递之后，i={b}");
Console.WriteLine();

//调用输出传递函数
CMethod(out c, out str);
Console.Write($"(3)c=30，str=csharp;经过CMethod方法，out传递之后c={c},str={str}");
Console.WriteLine();
Console.ReadKey();

//值传递
static void AMethod(int i)
{
    i = i + 10;
}

//引用传递
static void BMethod(ref int i)
{
    i = i + 10;
}

//输出传递
static void CMethod(out int i, out string j)
{
    i = 120;//输出参数函数必须在函数内部进行初始化赋值
    j = "c++";
}