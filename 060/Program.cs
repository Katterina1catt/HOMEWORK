// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами
           

int m,n;
n=Convert.ToInt32(Console.ReadLine());
m=Convert.ToInt32(Console.ReadLine());
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
     