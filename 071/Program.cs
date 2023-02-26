// 71. Показать натуральные числа от N до 1, N задано

void Loop(int N, int i)
{
    System.Console.Write($"{N,4}");
    if (N>i) Loop(N-1, i);
}
Loop(20,1);
System.Console.WriteLine();
