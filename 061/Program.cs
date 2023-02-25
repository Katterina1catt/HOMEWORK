// 61. Показать двумерный массив размером m×n 
// заполненный вещественными случайными числами

int m,n;
n=Convert.ToInt32(Console.ReadLine());
m=Convert.ToInt32(Console.ReadLine());
double [,] a=new double [m,n];

Random random=new Random();
for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.NextDouble()*100; // 

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i, j], 6:F2}   "); 
    System.Console.WriteLine();
}
     