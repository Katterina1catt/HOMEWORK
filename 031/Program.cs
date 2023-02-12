// 31. Вывести на экран кубы чисел от 1 до N

int a=1;
int N,k;
N=Convert.ToInt32(Console.ReadLine());
while (N>=a)
{
    k=a*a*a;
    System.Console.WriteLine(k);
    a=a+1;
}