// 36. Написать программу вычисления произведения чисел от 1 до N

int a=1;
int p=a;
int N;
N=Convert.ToInt32(Console.ReadLine());
while (N>=a)
{
    p=p*a;
    a=a+1;
}
System.Console.WriteLine(p);