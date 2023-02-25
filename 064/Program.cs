// 64. В двумерном массиве заменить элементы
// у которых оба индекса чётные на их квадраты по значению.

int m=2;
int n=2;
// n=Convert.ToInt32(Console.ReadLine());
// m=Convert.ToInt32(Console.ReadLine());
int [,] a=new int [m,n];

Random random=new Random();
{
for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(10); // Можно ввести диапазон 1,300 например
}
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j], 5 }");
    System.Console.WriteLine();
}
for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
    if(i%2==1 && j%2==1)
        a[i,j]=a[i,j]*a[i,j];

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"   {a[i,j],5 }");
    System.Console.WriteLine();
}

