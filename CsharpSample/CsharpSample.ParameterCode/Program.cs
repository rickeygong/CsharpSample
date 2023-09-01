#region section1
//int a = 10;
//int b = 20;
//int c = 30;
//string str = "csharp";

////调用值传递函数
//AMethod(a);
//Console.WriteLine($"(1)a的初始值=10，经过[AMethod]方法(+10)，值传递之后，i={a}");
//Console.WriteLine();

////调用引用传递函数
//BMethod(ref b);
//Console.WriteLine($"(2)b的初始值=20，经过[BMethod]方法(+10)，ref值传递之后，i={b}");
//Console.WriteLine();

////调用输出传递函数
//CMethod(out c, out str);
//Console.Write($"(3)c=30，str=csharp;经过CMethod方法，out传递之后c={c},str={str}");
//Console.WriteLine();
//Console.ReadKey();

////值传递
//static void AMethod(int i)
//{
//    i = i + 10;
//}

////引用传递
//static void BMethod(ref int i)
//{
//    i = i + 10;
//}

////输出传递
//static void CMethod(out int i, out string j)
//{
//    i = 120;//输出参数函数必须在函数内部进行初始化赋值
//    j = "c++";
//}
#endregion

#region section2 值传递
//int val = 100;
//Console.WriteLine($"调用Func函数前，val 等于 {val}");
//Func(val);
//Console.WriteLine($"调用Func函数后，val 等于 {val}");
//void Func(int val)
//{
//    val = val + 10000;
//    Console.WriteLine($"Func函数内部值，val 等于 {val}");
//}
#endregion

#region section3 引用传递
//int val = 300;
//Console.WriteLine($"调用Foo函数前，val 等于 {val}");
//Foo(ref val);
//Console.WriteLine($"调用Foo函数后，val 等于 {val}");
//void Foo(ref int val)
//{
//    val = val + 10000;
//    Console.WriteLine($"Foo函数内部值，val 等于 {val}");
//}
#endregion

#region section4 输出传递
//int val;
//Foo(out val);
//Console.WriteLine($"调用Foo函数后，val 等于 {val}");
//void Foo(out int val)
//{
//    int temp = 10;
//    val = temp;//out不能使用未赋值的参数
//    val = val + 900;
//}
#endregion

#region 求整数数组中的最大值，最小值，和，平均数
int[] arr = { 10, 20, 30, 40 };
double avg = 0;
int max = 0;
int min = 0;
int sum = 0;
sum = getIntResult(arr, ref avg, ref max, ref min);
Console.WriteLine($"最大值：{max}，最小值：{min}，和：{sum}，平均数：{avg}");

int getIntResult(int[] arr, ref double avg,ref int max ,ref int min)
{
    int sum = arr.Sum();
    max = arr.Max();
    min = arr.Min();
    avg = arr.Average();
    return sum;
}
#endregion