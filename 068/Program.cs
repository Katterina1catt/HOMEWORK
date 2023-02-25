// 68. Написать программу, которая обменивает элементы первой строки 
// и последней строки

int m=3;
int n=3;
// n=Convert.ToInt32(Console.ReadLine());
// m=Convert.ToInt32(Console.ReadLine());
int [,] a=new int [m,n];

Random random=new Random();
for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(300); // Можно ввести диапазон 1,300 например

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}");
    System.Console.WriteLine();
}
for(int j=0;j<a.GetLength(0);j++)
    for (j=0;j<m;j++)
        {
        int t;
        t=a[0,j];
        a[0,j]=a[n-1,j];
        a[n-1,j]=t;
        }

for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"   {a[i,j], 5}");
    System.Console.WriteLine();