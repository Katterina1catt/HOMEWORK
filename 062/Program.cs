// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]).
//  Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.
int n,k;
n=Convert.ToInt32(Console.ReadLine());
k=Convert.ToInt32(Console.ReadLine());
int [,] a=new int [n,k];

Random random=new Random();
for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(300); // Можно ввести диапазон 1,300 например

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.WriteLine($"{a[i,j]}");
    System.Console.WriteLine();
}

for(int i=0;i<a.GetLength(0);i++)
    for(int j=0;j<a.GetLength(1);j++)
    a[i,j]=-a[i,j];
for(int i=0;i<a.GetLength(0);i++)
{
for(int j=0;j<a.GetLength(1);j++)
        System.Console.WriteLine($"{a[i,j]}");
    System.Console.WriteLine();
}