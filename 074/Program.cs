// 74. Найти сумму цифр числа

int F(int N)
{
    if (N==0) return 0;
    return N=N%10+F(N/10);
}
System.Console.WriteLine(F(465));