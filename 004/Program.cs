﻿// 4. По заданному с клавиатуры номеру дня недели вывести его название

int a=0;
Console.Write("Введите номер дня недели ");
a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
System.Console.WriteLine("Понедельник");
}
 else if (a == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (a == 3)
{
    System.Console.WriteLine("Среда");
}
else if (a == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (a == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (a == 3)
{
    System.Console.WriteLine("Суббота");
}
else if (a == 7)
{
    System.Console.WriteLine("Воскресенье");
}
