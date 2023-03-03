// 98. Показать треугольник Паскаля
//   *Сделать вывод в виде равнобедренного треугольника
using System;
class Program
{
    static void Main(string[] args)
    {
        int i,j,l=1;
        for (i=1;i<=10;i++)
        {
            for (j=1;j<i+1;j++)
            {
                Console.Write(l++ +" ");
            }
 
            Console.Write("\n");
        }
        Console.ReadLine();
    }
}