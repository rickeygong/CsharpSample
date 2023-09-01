



//指定数据源
int[] scores = { 97, 92, 81, 60 };

//定义查询表达式
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

//执行查询
foreach (int i in scoreQuery)
{
    Console.Write(i + " ");
}

Console.WriteLine();

List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
IEnumerable<int> scoreQuery2 =
    from score in ints
    where score > 4
    select score;
foreach (var item in scoreQuery2)
{
    Console.Write(item + " ");
}
Console.WriteLine();

IEnumerable<string> highScoresQuery2 =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";


foreach (var item in highScoresQuery2)
{
    Console.Write(item + " ");
}