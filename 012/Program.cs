// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a;
a=Convert.ToInt32(Console.ReadLine());
int d0,d1;
d0=a%10;
d1=a/10%10;
if (a>=10)
if (a<=99)
if (d0>d1)
{
System.Console.WriteLine($"Наибольшая цифра {d0}");
}
else 
{
System.Console.WriteLine($"Наибольшая цифра {d1}");
}