// 8. Вывести на экран числа от -N до N

int a=-10;
int b=10; 

while (a<=b)
{
System.Console.WriteLine(a);
a=a+1;
}

// Если вводить вручную с клавиатуры, то этот код:
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
